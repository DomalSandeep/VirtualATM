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
    public partial class splashscreen2 : Form
    {
        Timer tmr;

        public splashscreen2()
        {

            InitializeComponent();
            tmr = new Timer();
            tmr.Interval = 5000;
            tmr.Tick += timer1_Tick;
            tmr.Start();

        }
         private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            WITHDRAW lg = new WITHDRAW();
            lg.Show();
            this.Hide();
        }
    }
}
