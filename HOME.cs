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
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            this.Hide();
            bal.Show();
        }

        public static string Acc;
        private void HOME_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number  " + Login.AccNumber;
            Acc = Login.AccNumber;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DEPOSIT depo = new DEPOSIT();
            depo.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            WITHDRAW wd = new WITHDRAW();
            wd.Show();  
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            this.Hide();
            bal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DEPOSIT depo = new DEPOSIT();
            depo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePin pin = new ChangePin();
            pin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WITHDRAW wd = new WITHDRAW();
            wd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FAST_CASH Fcash = new FAST_CASH();
            Fcash.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MiniStatement mini = new MiniStatement();
            mini.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            DEPOSIT depo = new DEPOSIT();
            depo.Show();
            this.Hide();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            FAST_CASH Fcash = new FAST_CASH();
            Fcash.Show();
            this.Hide();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            ChangePin pin = new ChangePin();
            pin.Show();
            this.Hide();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            WITHDRAW wd = new WITHDRAW();
            wd.Show();
            this.Hide();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            MiniStatement mini = new MiniStatement();
            mini.Show();
            this.Hide();
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            this.Hide();
            bal.Show();
        }

        private void AccNumlbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
