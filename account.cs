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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-JK6V8OIJ\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void account_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            

            //validate name
            if (!textBox2.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Please enter a valid name containing only letters and spaces.");
                return;
            }

            //Validate Father's Name
            if (!textBox3.Text.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Please enter a valid father's name containing only letters and spaces.");
                return;
            }

            //Validate Date of Birth
            if (!DateTime.TryParse(dateTimePicker1.Text, out DateTime dob))
            {
                MessageBox.Show("Please enter a valid date of birth.");
                return;
            }

            //Validate Phone Number
            if (!long.TryParse(textBox5.Text, out long phone) || textBox5.Text.Length != 10)
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.");
                return;
            }

            //Validate PIN
            if (!int.TryParse(textBox6.Text, out int pin) || textBox6.Text.Length != 3)
            {
                MessageBox.Show("Please enter a valid 3-digit PIN.");
                return;
            }

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cd = new SqlCommand("INSERT INTO ATMDb(Accnum,Name,FaName,Dob,Phone,Address,Education,Occupation,Balance,PIN)values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + textBox7.Text + "','" + textBox6.Text + "')", Con);
                    cd.ExecuteNonQuery();
                    MessageBox.Show("Account created sucessfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
