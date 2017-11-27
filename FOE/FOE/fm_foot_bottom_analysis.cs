using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FOE
{
    public partial class fm_foot_bottom_analysis : Form
    {
        List<int[]> cords = new List<int[]>();

        public fm_foot_bottom_analysis()
        {
            InitializeComponent();
        }

        private void fm_analysis_Load(object sender, EventArgs e)
        {
            pic_foot_bottom.Image = GlobalSettings.GetCurrentPatient().foot_bottom;
        }

        /*
        private void pic_cam_bottom_Paint(object sender, PaintEventArgs e)
        {
            foreach (int [] cord in cords)
            {
                int x = cord[0];
                int y = cord[1];
                e.Graphics.FillRectangle(Brushes.Black, x-2, y-2, 4, 4);
            }
        }

        // capture (x, y) when mouse down on the picture box
        private void pic_cam_bottom_MouseDown(object sender, MouseEventArgs e)
        {
            cords.Add(new int[] { e.X, e.Y });
            label5.Text = "mouse clicked @ " + e.X + "," + e.Y;
            pic_cam_bottom.Refresh();
        }

        // clear all the dots, and choose again.
        private void pic_cam_bottom_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cords.Clear();
            pic_cam_bottom.Refresh();
        }
        */
    }
}
