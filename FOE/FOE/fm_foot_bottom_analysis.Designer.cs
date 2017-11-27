namespace FOE
{
    partial class fm_foot_bottom_analysis
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
            this.pic_foot_bottom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_foot_bottom)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_foot_bottom
            // 
            this.pic_foot_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_foot_bottom.Location = new System.Drawing.Point(205, 12);
            this.pic_foot_bottom.Name = "pic_foot_bottom";
            this.pic_foot_bottom.Size = new System.Drawing.Size(322, 310);
            this.pic_foot_bottom.TabIndex = 0;
            this.pic_foot_bottom.TabStop = false;
            // 
            // fm_foot_bottom_analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 423);
            this.Controls.Add(this.pic_foot_bottom);
            this.Name = "fm_foot_bottom_analysis";
            this.Text = "fm_foot_bottom_analysis";
            this.Load += new System.EventHandler(this.fm_analysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_foot_bottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_foot_bottom;
    }
}