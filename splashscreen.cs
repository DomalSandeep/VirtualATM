using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMtuto
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();

        }
        Timer tmr;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tmr = new Timer();
            tmr.Interval = 300;
            tmr.Start();
            tmr.Tick += Tmr_Tick;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            Login lg = new Login(); 
            lg.Show();
            this.Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
