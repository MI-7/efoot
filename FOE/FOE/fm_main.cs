using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using AForge.Video;
using AForge.Video.DirectShow;

using MySql.Data.MySqlClient;
using FOE.DataAccess;
using FOE.Models;

namespace FOE
{
    public partial class fm_main : Form
    {
        private FilterInfoCollection VideoDevices;
        private VideoCaptureDevice VideoSource;
        private VideoCaptureDevice VideoSource_Foot_Bottom;

        private NewFrameEventHandler back_handler;
        private NewFrameEventHandler front_handler;
        private NewFrameEventHandler bottom_handler;
        private bool is_back_rendering, is_front_rendering, is_bottom_rendering;
        
        public fm_main()
        {
            InitializeComponent();
        }

        private void getPatientInfo()
        {
            //tabc_main.SelectedTab = tabp_cam;
            String phonenumber = txt_phone.Text;

            if (phonenumber == null || phonenumber == "")
            {
                return;
            }

            // try loading the patient data from db
            label5.Text = "尝试与CRM通信";
            Patient p = null;

            try
            {
                p = PatientService.GetPatientByPhone(phonenumber);
            }
            catch (MySqlException mse)
            {
                label5.Text = "CRM通信失败";
                return;
            }

            // if loading failed, add a new one with full info
            if (p == null)
            {
                label5.Text = "病人信息不存在";
                // todo: show confirmation dialog

                DialogResult result = MessageBox.Show("病人信息不存在，添加病人信息吗？", "确认", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    String name = txt_name.Text;
                    String gender = txt_gender.Text;

                    if (name == "")
                    {
                        MessageBox.Show("请填写病人姓名", "确认", MessageBoxButtons.OK);
                        txt_name.Focus();
                        return;
                    }

                    if (gender == "")
                    {
                        MessageBox.Show("请选择病人性别", "确认", MessageBoxButtons.OK);
                        txt_gender.Focus();
                        return;
                    }

                    p = new Patient(-1, name, phonenumber, gender);

                    try
                    {
                        PatientService.CreatePatient(p);
                        label5.Text = "病人信息已保存";
                        tabc_main.SelectedTab = tabp_cam;
                    }
                    catch (MySqlException mse)
                    {
                        label5.Text = "病人信息保存失败";
                        return;
                    }
                }
            }
            else
            {
                label5.Text = "病人信息已获取";
                // fill in patient information
                txt_name.Text = p.name;
                txt_gender.Text = p.gender;

                // go to second tab
                tabc_main.SelectedTab = tabp_cam;
            }

            GlobalSettings.SetCurrentPatient(p);
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            getPatientInfo();
        }

        private void fm_main_Load(object sender, EventArgs e)
        {
            VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in VideoDevices)
            {
                cmb_cams.Items.Add(device.Name);
            }

            VideoSource = new VideoCaptureDevice();

            cmb_cams.SelectedIndex = 0;

            back_handler = new NewFrameEventHandler(VideoSource_NewFrame_Back);
            front_handler = new NewFrameEventHandler(VideoSource_NewFrame_Front);
            bottom_handler = new NewFrameEventHandler(VideoSource_NewFrame_Bottom);

            is_back_rendering = false;
            is_front_rendering = false;
            is_bottom_rendering = false;

            VideoSource = new VideoCaptureDevice(VideoDevices[cmb_cams.SelectedIndex].MonikerString);
            // VideoSource.NewFrame No Event for now
            VideoSource.Start();

            // VideoSource_Foot_Bottom = new ...  The second cam for Foot Bottom

            // 自选图片可选择摄像头
        }

        private void btn_showcam_Click(object sender, EventArgs e)
        {
            /*
            if (videoSource.IsRunning)
            {
                // Do Nothing
            }
            else
            {
                if (cmb_cams.SelectedIndex == -1)
                {
                    // Do Nothing
                }
                else
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cmb_cams.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                    videoSource.Start();
                }
            }
            */
        }

        private void btn_resume_Click(object sender, EventArgs e)
        {
            /*
            if (videoSource.IsRunning)
            {
                // Do Nothing
            }
            else
            {
                if (cmb_cams.SelectedIndex == -1)
                {
                    // Do Nothing
                }
                else
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cmb_cams.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                    videoSource.Start();
                }
            }
            */
        }

        private void fm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (VideoSource.IsRunning)
            {
                VideoSource.Stop();
            }
        }

        private void btn_takepic_Click(object sender, EventArgs e)
        {
            pic_cam_front.Image.Save("c:\\pic791234568.png");
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                getPatientInfo();
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                getPatientInfo();
            }
        }

        private void txt_gender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                getPatientInfo();
            }
        }



        private void VideoSource_NewFrame_Back(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            pic_cam_back.Image = image;
        }

        private void VideoSource_NewFrame_Front(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            pic_cam_front.Image = image;
        }

        private void VideoSource_NewFrame_Bottom(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            pic_cam_bottom.Image = image;
        }

        private void pic_cam_back_Click(object sender, EventArgs e)
        {
            if (!is_back_rendering)
            {
                VideoSource.NewFrame += back_handler;
                is_back_rendering = true;
            }
            else
            {
                VideoSource.NewFrame -= back_handler;
                is_back_rendering = false;
            }
        }

        private void btn_foot_back_save_Click(object sender, EventArgs e)
        {
            GlobalSettings.GetCurrentPatient().foot_back = pic_cam_back.Image;
        }

        private void btn_foot_bottom_takepic_Click(object sender, EventArgs e)
        {
            // Do Nothing for now
        }

        private void pic_cam_bottom_Click(object sender, EventArgs e)
        {
            if (!is_bottom_rendering)
            {
                VideoSource.NewFrame += bottom_handler;
                is_bottom_rendering = true;
            }
            else
            {
                VideoSource.NewFrame -= bottom_handler;
                is_bottom_rendering = false;
            }
        }

        private void btn_foot_bottom_save_Click(object sender, EventArgs e)
        {
            GlobalSettings.GetCurrentPatient().foot_bottom = pic_cam_bottom.Image;
        }

        private void btn_foot_bottom_analyze_Click(object sender, EventArgs e)
        {
            Form foot_bottom_analysis = new fm_foot_bottom_analysis();
            foot_bottom_analysis.ShowDialog();
        }

        private void pic_cam_front_Click(object sender, EventArgs e)
        {
            if (!is_front_rendering)
            {
                VideoSource.NewFrame += front_handler;
                is_front_rendering = true;
            }
            else
            {
                VideoSource.NewFrame -= front_handler;
                is_front_rendering = false;
            }
        }
    }
}
