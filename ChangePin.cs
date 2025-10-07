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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {   HOME h1 = new HOME();
            this.Hide();
            h1.Show();
        }
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-JK6V8OIJ\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");
        string Acc = Login.AccNumber;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Pin1lbl.Text == "" || Pin2lbl.Text == "") 
            {
                MessageBox.Show("Enter and confirm the new pin ");
            } 
            else if (Pin1lbl.Text != Pin2lbl.Text)
            {
                MessageBox.Show("Pin2lbl 1 and 2 are not same");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update ATMDb set PIN =" + Pin1lbl.Text + "where Accnum='" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin updated sucessfully");
                    Con.Close();
                    Login hOME = new Login();
                    hOME.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        } 

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (Pin1lbl.Text == "" || Pin2lbl.Text == "")
            {
                MessageBox.Show("Enter and confirm the new pin ");
            }
            else if (Pin1lbl.Text != Pin2lbl.Text)
            {
                MessageBox.Show("Pin2lbl 1 and 2 are not same");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update ATMDb set PIN =" + Pin1lbl.Text + "where Accnum='" + Acc + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin updated sucessfully");
                    Con.Close();
                    Login hOME = new Login();
                    hOME.Show();
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
