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
    public partial class fm_login : Form
    {
        public fm_login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form main = new fm_main();
            main.Show();
            this.Close();
        }
    }
}
