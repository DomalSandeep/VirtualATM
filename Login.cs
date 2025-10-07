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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            splashscreen splashScreen = new splashscreen();
            splashScreen.Show();
            // Wait for a few seconds (you can adjust the time as needed)
            System.Threading.Thread.Sleep(3000);
            // Close splash screen
            splashScreen.Close();
           
        }
        


        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-JK6V8OIJ\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");
        private void label5_Click(object sender, EventArgs e)
        {
            account acc= new account();
            acc.Show();
            this.Hide();
        }
        public static string AccNumber;

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            {
                String Accnum, PIN;

                Accnum = textBox1.Text;
                PIN = textBox2.Text;

                // Validate account number

                // Validate PIN
                if (!int.TryParse(PIN, out int pin) || PIN.Length != 3)
                {
                    MessageBox.Show("PIN must be 3 digits and contain only numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    string query = "SELECT *FROM ATMDb WHERE Accnum = '" + Accnum + "' AND PIN ='" + PIN + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        AccNumber = Accnum;
                        HOME frm = new HOME();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid login credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.Focus();
                    }

                }
                catch
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    Con.Close();
                }

            }
        }

        private void red_reg_cl_Click(object sender, EventArgs e)
        {
            account acc = new account();
            acc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
