using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FFSJ
{
    public partial class frmSplashScreen : Form
    {

        int count = 0;
        public frmSplashScreen()
        {
            InitializeComponent();
            timer1.Interval = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (count < 100)
            {
                count += 20;
                pbar.Value = count;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                frmLogin obj = new frmLogin();
                obj.Show();
            }
            
        }
    }
}
