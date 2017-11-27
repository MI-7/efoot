namespace FOE
{
    partial class fm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabc_main = new System.Windows.Forms.TabControl();
            this.tabp_userinfo = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.tabp_cam = new System.Windows.Forms.TabPage();
            this.btn_foot_bottom_save = new System.Windows.Forms.Button();
            this.btn_foot_bottom_analyze = new System.Windows.Forms.Button();
            this.btn_foot_bottom_takepic = new System.Windows.Forms.Button();
            this.btn_foot_innerright_save = new System.Windows.Forms.Button();
            this.btn_foot_innerright_analyze = new System.Windows.Forms.Button();
            this.btn_foot_innerright_takepic = new System.Windows.Forms.Button();
            this.btn_foot_innerleft_save = new System.Windows.Forms.Button();
            this.btn_foot_innerleft_analyze = new System.Windows.Forms.Button();
            this.btn_foot_innerleft_takepic = new System.Windows.Forms.Button();
            this.btn_foot_front_save = new System.Windows.Forms.Button();
            this.btn_foot_front_analyze = new System.Windows.Forms.Button();
            this.btn_foot_front_takepic = new System.Windows.Forms.Button();
            this.btn_foot_back_save = new System.Windows.Forms.Button();
            this.btn_foot_back_analyze = new System.Windows.Forms.Button();
            this.btn_foot_back_takepic = new System.Windows.Forms.Button();
            this.pic_cam_bottom = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_takepic = new System.Windows.Forms.Button();
            this.btn_showcam = new System.Windows.Forms.Button();
            this.cmb_cams = new System.Windows.Forms.ComboBox();
            this.pic_cam_innerright = new System.Windows.Forms.PictureBox();
            this.pic_cam_innerleft = new System.Windows.Forms.PictureBox();
            this.pic_cam_front = new System.Windows.Forms.PictureBox();
            this.pic_cam_back = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabc_main.SuspendLayout();
            this.tabp_userinfo.SuspendLayout();
            this.tabp_cam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cam_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cam_innerright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cam_innerleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cam_front)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cam_back)).BeginInit();
            this.SuspendLayout();
            // 
            // tabc_main
            // 
            this.tabc_main.Controls.Add(this.tabp_userinfo);
            this.tabc_main.Controls.Add(this.tabp_cam);
            this.tabc_main.Location = new System.Drawing.Point(12, 12);
            this.tabc_main.Name = "tabc_main";
            this.tabc_main.SelectedIndex = 0;
            this.tabc_main.Size = new System.Drawing.Size(1077, 518);
            this.tabc_main.TabIndex = 0;
            // 
            // tabp_userinfo
            // 
            this.tabp_userinfo.Controls.Add(this.label4);
            this.tabp_userinfo.Controls.Add(this.txt_gender);
            this.tabp_userinfo.Controls.Add(this.label3);
            this.tabp_userinfo.Controls.Add(this.txt_name);
            this.tabp_userinfo.Controls.Add(this.label2);
            this.tabp_userinfo.Controls.Add(this.txt_phone);
            this.tabp_userinfo.Controls.Add(this.btn_confirm);
            this.tabp_userinfo.Location = new System.Drawing.Point(4, 25);
            this.tabp_userinfo.Name = "tabp_userinfo";
            this.tabp_userinfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_userinfo.Size = new System.Drawing.Size(1069, 489);
            this.tabp_userinfo.TabIndex = 0;
            this.tabp_userinfo.Text = "tabPage1";
            this.tabp_userinfo.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "gender";
            // 
            // txt_gender
            // 
            this.txt_gender.Location = new System.Drawing.Point(9, 211);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(169, 22);
            this.txt_gender.TabIndex = 5;
            this.txt_gender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gender_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "name";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(9, 135);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(169, 22);
            this.txt_name.TabIndex = 3;
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "phone number";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(6, 51);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(172, 22);
            this.txt_phone.TabIndex = 1;
            this.txt_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phone_KeyPress);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(9, 372);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // tabp_cam
            // 
            this.tabp_cam.Controls.Add(this.btn_foot_bottom_save);
            this.tabp_cam.Controls.Add(this.btn_foot_bottom_analyze);
            this.tabp_cam.Controls.Add(this.btn_foot_bottom_takepic);
            this.tabp_cam.Controls.Add(this.btn_foot_innerright_save);
            this.tabp_cam.Controls.Add(this.btn_foot_innerright_analyze);
            this.tabp_cam.Controls.Add(this.btn_foot_innerright_takepic);
            this.tabp_cam.Controls.Add(this.btn_foot_innerleft_save);
            this.tabp_cam.Controls.Add(this.btn_foot_innerleft_analyze);
            this.tabp_cam.Controls.Add(this.btn_foot_innerleft_takepic);
            this.tabp_cam.Controls.Add(this.btn_foot_front_save);
            this.tabp_cam.Controls.Add(this.btn_foot_front_analyze);
            this.tabp_cam.Controls.Add(this.btn_foot_front_takepic);
            this.tabp_cam.Controls.Add(this.btn_foot_back_save);
            this.tabp_cam.Controls.Add(this.btn_foot_back_analyze);
            this.tabp_cam.Controls.Add(this.btn_foot_back_takepic);
            this.tabp_cam.Controls.Add(this.pic_cam_bottom);
            this.tabp_cam.Controls.Add(this.label1);
            this.tabp_cam.Controls.Add(this.btn_resume);
            this.tabp_cam.Controls.Add(this.btn_takepic);
            this.tabp_cam.Controls.Add(this.btn_showcam);
            this.tabp_cam.Controls.Add(this.cmb_cams);
            this.tabp_cam.Controls.Add(this.pic_cam_innerright);
            this.tabp_cam.Controls.Add(this.pic_cam_innerleft);
            this.tabp_cam.Controls.Add(this.pic_cam_front);
            this.tabp_cam.Controls.Add(this.pic_cam_back);
            this.tabp_cam.Location = new System.Drawing.Point(4, 25);
            this.tabp_cam.Name = "tabp_cam";
            this.tabp_cam.Padding = new System.Windows.Forms.Padding(3);
            this.tabp_cam.Size = new System.Drawing.Size(1069, 489);
            this.tabp_cam.TabIndex = 1;
            this.tabp_cam.Text = "tabPage2";
            this.tabp_cam.UseVisualStyleBackColor = true;
            // 
            // btn_foot_bottom_save
            // 
            this.btn_foot_bottom_save.Location = new System.Drawing.Point(16, 366);
            this.btn_foot_bottom_save.Name = "btn_foot_bottom_save";
            this.btn_foot_bottom_save.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_bottom_save.TabIndex = 24;
            this.btn_foot_bottom_save.Text = "save";
            this.btn_foot_bottom_save.UseVisualStyleBackColor = true;
            this.btn_foot_bottom_save.Click += new System.EventHandler(this.btn_foot_bottom_save_Click);
            // 
            // btn_foot_bottom_analyze
            // 
            this.btn_foot_bottom_analyze.Location = new System.Drawing.Point(16, 398);
            this.btn_foot_bottom_analyze.Name = "btn_foot_bottom_analyze";
            this.btn_foot_bottom_analyze.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_bottom_analyze.TabIndex = 23;
            this.btn_foot_bottom_analyze.Text = "analyze";
            this.btn_foot_bottom_analyze.UseVisualStyleBackColor = true;
            this.btn_foot_bottom_analyze.Click += new System.EventHandler(this.btn_foot_bottom_analyze_Click);
            // 
            // btn_foot_bottom_takepic
            // 
            this.btn_foot_bottom_takepic.Location = new System.Drawing.Point(16, 334);
            this.btn_foot_bottom_takepic.Name = "btn_foot_bottom_takepic";
            this.btn_foot_bottom_takepic.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_bottom_takepic.TabIndex = 22;
            this.btn_foot_bottom_takepic.Text = "pic";
            this.btn_foot_bottom_takepic.UseVisualStyleBackColor = true;
            this.btn_foot_bottom_takepic.Click += new System.EventHandler(this.btn_foot_bottom_takepic_Click);
            // 
            // btn_foot_innerright_save
            // 
            this.btn_foot_innerright_save.Location = new System.Drawing.Point(974, 366);
            this.btn_foot_innerright_save.Name = "btn_foot_innerright_save";
            this.btn_foot_innerright_save.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_innerright_save.TabIndex = 21;
            this.btn_foot_innerright_save.Text = "save";
            this.btn_foot_innerright_save.UseVisualStyleBackColor = true;
            // 
            // btn_foot_innerright_analyze
            // 
            this.btn_foot_innerright_analyze.Location = new System.Drawing.Point(974, 398);
            this.btn_foot_innerright_analyze.Name = "btn_foot_innerright_analyze";
            this.btn_foot_innerright_analyze.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_innerright_analyze.TabIndex = 20;
            this.btn_foot_innerright_analyze.Text = "analyze";
            this.btn_foot_innerright_analyze.UseVisualStyleBackColor = true;
            // 
            // btn_foot_innerright_takepic
            // 
            this.btn_foot_innerright_takepic.Location = new System.Drawing.Point(974, 334);
            this.btn_foot_innerright_takepic.Name = "btn_foot_innerright_takepic";
            this.btn_foot_innerright_takepic.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_innerright_takepic.TabIndex = 19;
            this.btn_foot_innerright_takepic.Text = "pic";
            this.btn_foot_innerright_takepic.UseVisualStyleBackColor = true;
            // 
            // btn_foot_innerleft_save
            // 
            this.btn_foot_innerleft_save.Location = new System.Drawing.Point(810, 366);
            this.btn_foot_innerleft_save.Name = "btn_foot_innerleft_save";
            this.btn_foot_innerleft_save.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_innerleft_save.TabIndex = 18;
            this.btn_foot_innerleft_save.Text = "save";
            this.btn_foot_innerleft_save.UseVisualStyleBackColor = true;
            // 
            // btn_foot_innerleft_analyze
            // 
            this.btn_foot_innerleft_analyze.Location = new System.Drawing.Point(810, 398);
            this.btn_foot_innerleft_analyze.Name = "btn_foot_innerleft_analyze";
            this.btn_foot_innerleft_analyze.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_innerleft_analyze.TabIndex = 17;
            this.btn_foot_innerleft_analyze.Text = "analyze";
            this.btn_foot_innerleft_analyze.UseVisualStyleBackColor = true;
            // 
            // btn_foot_innerleft_takepic
            // 
            this.btn_foot_innerleft_takepic.Location = new System.Drawing.Point(810, 334);
            this.btn_foot_innerleft_takepic.Name = "btn_foot_innerleft_takepic";
            this.btn_foot_innerleft_takepic.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_innerleft_takepic.TabIndex = 16;
            this.btn_foot_innerleft_takepic.Text = "pic";
            this.btn_foot_innerleft_takepic.UseVisualStyleBackColor = true;
            // 
            // btn_foot_front_save
            // 
            this.btn_foot_front_save.Location = new System.Drawing.Point(359, 366);
            this.btn_foot_front_save.Name = "btn_foot_front_save";
            this.btn_foot_front_save.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_front_save.TabIndex = 15;
            this.btn_foot_front_save.Text = "save";
            this.btn_foot_front_save.UseVisualStyleBackColor = true;
            // 
            // btn_foot_front_analyze
            // 
            this.btn_foot_front_analyze.Location = new System.Drawing.Point(359, 398);
            this.btn_foot_front_analyze.Name = "btn_foot_front_analyze";
            this.btn_foot_front_analyze.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_front_analyze.TabIndex = 14;
            this.btn_foot_front_analyze.Text = "analyze";
            this.btn_foot_front_analyze.UseVisualStyleBackColor = true;
            // 
            // btn_foot_front_takepic
            // 
            this.btn_foot_front_takepic.Location = new System.Drawing.Point(359, 334);
            this.btn_foot_front_takepic.Name = "btn_foot_front_takepic";
            this.btn_foot_front_takepic.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_front_takepic.TabIndex = 13;
            this.btn_foot_front_takepic.Text = "pic";
            this.btn_foot_front_takepic.UseVisualStyleBackColor = true;
            // 
            // btn_foot_back_save
            // 
            this.btn_foot_back_save.Location = new System.Drawing.Point(220, 366);
            this.btn_foot_back_save.Name = "btn_foot_back_save";
            this.btn_foot_back_save.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_back_save.TabIndex = 12;
            this.btn_foot_back_save.Text = "save";
            this.btn_foot_back_save.UseVisualStyleBackColor = true;
            this.btn_foot_back_save.Click += new System.EventHandler(this.btn_foot_back_save_Click);
            // 
            // btn_foot_back_analyze
            // 
            this.btn_foot_back_analyze.Location = new System.Drawing.Point(220, 398);
            this.btn_foot_back_analyze.Name = "btn_foot_back_analyze";
            this.btn_foot_back_analyze.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_back_analyze.TabIndex = 11;
            this.btn_foot_back_analyze.Text = "analyze";
            this.btn_foot_back_analyze.UseVisualStyleBackColor = true;
            // 
            // btn_foot_back_takepic
            // 
            this.btn_foot_back_takepic.Location = new System.Drawing.Point(220, 334);
            this.btn_foot_back_takepic.Name = "btn_foot_back_takepic";
            this.btn_foot_back_takepic.Size = new System.Drawing.Size(68, 26);
            this.btn_foot_back_takepic.TabIndex = 10;
            this.btn_foot_back_takepic.Text = "pic";
            this.btn_foot_back_takepic.UseVisualStyleBackColor = true;
            // 
            // pic_cam_bottom
            // 
            this.pic_cam_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_cam_bottom.Location = new System.Drawing.Point(16, 22);
            this.pic_cam_bottom.Name = "pic_cam_bottom";
            this.pic_cam_bottom.Size = new System.Drawing.Size(135, 291);
            this.pic_cam_bottom.TabIndex = 9;
            this.pic_cam_bottom.TabStop = false;
            this.pic_cam_bottom.Click += new System.EventHandler(this.pic_cam_bottom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "image save to c:\\picxxxx.png";
            // 
            // btn_resume
            // 
            this.btn_resume.Location = new System.Drawing.Point(458, 457);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(131, 23);
            this.btn_resume.TabIndex = 7;
            this.btn_resume.Text = "Resume Cam";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.btn_resume_Click);
            // 
            // btn_takepic
            // 
            this.btn_takepic.Location = new System.Drawing.Point(332, 457);
            this.btn_takepic.Name = "btn_takepic";
            this.btn_takepic.Size = new System.Drawing.Size(123, 23);
            this.btn_takepic.TabIndex = 6;
            this.btn_takepic.Text = "Take Pic";
            this.btn_takepic.UseVisualStyleBackColor = true;
            this.btn_takepic.Click += new System.EventHandler(this.btn_takepic_Click);
            // 
            // btn_showcam
            // 
            this.btn_showcam.Location = new System.Drawing.Point(220, 457);
            this.btn_showcam.Name = "btn_showcam";
            this.btn_showcam.Size = new System.Drawing.Size(106, 23);
            this.btn_showcam.TabIndex = 5;
            this.btn_showcam.Text = "Show Cam";
            this.btn_showcam.UseVisualStyleBackColor = true;
            this.btn_showcam.Click += new System.EventHandler(this.btn_showcam_Click);
            // 
            // cmb_cams
            // 
            this.cmb_cams.FormattingEnabled = true;
            this.cmb_cams.Location = new System.Drawing.Point(220, 427);
            this.cmb_cams.Name = "cmb_cams";
            this.cmb_cams.Size = new System.Drawing.Size(369, 24);
            this.cmb_cams.TabIndex = 4;
            // 
            // pic_cam_innerright
            // 
            this.pic_cam_innerright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_cam_innerright.Location = new System.Drawing.Point(866, 22);
            this.pic_cam_innerright.Name = "pic_cam_innerright";
            this.pic_cam_innerright.Size = new System.Drawing.Size(197, 291);
            this.pic_cam_innerright.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_cam_innerright.TabIndex = 3;
            this.pic_cam_innerright.TabStop = false;
            // 
            // pic_cam_innerleft
            // 
            this.pic_cam_innerleft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_cam_innerleft.Location = new System.Drawing.Point(622, 22);
            this.pic_cam_innerleft.Name = "pic_cam_innerleft";
            this.pic_cam_innerleft.Size = new System.Drawing.Size(238, 291);
            this.pic_cam_innerleft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_cam_innerleft.TabIndex = 2;
            this.pic_cam_innerleft.TabStop = false;
            // 
            // pic_cam_front
            // 
            this.pic_cam_front.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_cam_front.Location = new System.Drawing.Point(359, 22);
            this.pic_cam_front.Name = "pic_cam_front";
            this.pic_cam_front.Size = new System.Drawing.Size(257, 291);
            this.pic_cam_front.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_cam_front.TabIndex = 1;
            this.pic_cam_front.TabStop = false;
            this.pic_cam_front.Click += new System.EventHandler(this.pic_cam_front_Click);
            // 
            // pic_cam_back
            // 
            this.pic_cam_back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_cam_back.Location = new System.Drawing.Point(220, 22);
            this.pic_cam_back.Name = "pic_cam_back";
            this.pic_cam_back.Size = new System.Drawing.Size(113, 291);
            this.pic_cam_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cam_back.TabIndex = 0;
            this.pic_cam_back.TabStop = false;
            this.pic_cam_back.Click += new System.EventHandler(this.pic_cam_back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // fm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 559);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabc_main);
            this.Name = "fm_main";
            this.Text = "fm_main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fm_main_FormClosing);
            this.Load += new System.EventHandler(this.fm_main_Load);
            this.tabc_main.ResumeLayout(false);
            this.tabp_userinfo.ResumeLayout(false);
            this.tabp_userinfo.PerformLayout();
            this.tabp_cam.ResumeLayout(false);
            this.tabp_cam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cam_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cam_innerright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cam_innerleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cam_front)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cam_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabc_main;
        private System.Windows.Forms.TabPage tabp_userinfo;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TabPage tabp_cam;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_takepic;
        private System.Windows.Forms.Button btn_showcam;
        private System.Windows.Forms.ComboBox cmb_cams;
        private System.Windows.Forms.PictureBox pic_cam_innerright;
        private System.Windows.Forms.PictureBox pic_cam_innerleft;
        private System.Windows.Forms.PictureBox pic_cam_front;
        private System.Windows.Forms.PictureBox pic_cam_back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pic_cam_bottom;
        private System.Windows.Forms.Button btn_foot_innerright_save;
        private System.Windows.Forms.Button btn_foot_innerright_analyze;
        private System.Windows.Forms.Button btn_foot_innerright_takepic;
        private System.Windows.Forms.Button btn_foot_innerleft_save;
        private System.Windows.Forms.Button btn_foot_innerleft_analyze;
        private System.Windows.Forms.Button btn_foot_innerleft_takepic;
        private System.Windows.Forms.Button btn_foot_front_save;
        private System.Windows.Forms.Button btn_foot_front_analyze;
        private System.Windows.Forms.Button btn_foot_front_takepic;
        private System.Windows.Forms.Button btn_foot_back_save;
        private System.Windows.Forms.Button btn_foot_back_analyze;
        private System.Windows.Forms.Button btn_foot_back_takepic;
        private System.Windows.Forms.Button btn_foot_bottom_save;
        private System.Windows.Forms.Button btn_foot_bottom_analyze;
        private System.Windows.Forms.Button btn_foot_bottom_takepic;
    }
}