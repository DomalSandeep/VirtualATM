using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMtuto
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-JK6V8OIJ\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from ATMDb where Accnum = '" + AccNum.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BALANCEINRS.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            AccNum.Text = HOME.Acc;
            getbalance();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            this.Hide();
            home.Show();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            AccNum.Text = HOME.Acc;
            getbalance();
        }

        private void AccNum_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
