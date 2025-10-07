using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMtuto
{
    public partial class WITHDRAW : Form
    {
        public WITHDRAW()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-JK6V8OIJ\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");
        string Acc = Login.AccNumber;
        int bal;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from ATMDb where Accnum = '" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelbl.Text = "Balance RS " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void addtransaction()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO TeansactionTbl values('" + Acc + "','" + TrType + "','" + textBox1.Text + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cd = new SqlCommand(query, Con);
                cd.ExecuteNonQuery();
                // MessageBox.Show("Account created sucessfully");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void WITHDRAW_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        int oldbalance, newbalance;

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            HOME hOME = new HOME();
            hOME.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter The amount for processing");
            }
            else if (Convert.ToInt32(textBox1.Text) <= 0)
            {
                MessageBox.Show("Enter valid amount");
            }
            else if (Convert.ToInt32(textBox1.Text) > bal)
            {
                MessageBox.Show("Balance cannot be negative");
            }
            else
            {
                splashscreen2 splash = new splashscreen2();
                splash.Show();
                this.Enabled = false;
                Thread t = new Thread(() =>
                {
                    try
                    {
                        newbalance = bal - Convert.ToInt32(textBox1.Text);
                        try
                        {
                            Con.Open();
                            string querry = "update ATMDb set Balance=" + newbalance + "where Accnum='" + Acc + "'";
                            SqlCommand cmd = new SqlCommand(querry, Con);
                            cmd.ExecuteNonQuery();
                            Con.Close();
                            addtransaction();
                            this.Invoke(new Action(() =>
                            {
                                splash.Hide();
                                this.Enabled = true;
                                HOME home = new HOME();
                                home.Show();
                                this.Hide();
                            }));
                        }
                        catch (Exception ex)
                        {
                            this.Invoke(new Action(() =>
                            {
                                MessageBox.Show(ex.Message);
                                splash.Hide();
                                this.Enabled = true;
                            }));
                        }
                    }
                    catch (Exception ex)
                    {
                        this.Invoke(new Action(() =>
                        {
                            MessageBox.Show(ex.Message);
                            splash.Hide();
                            this.Enabled = true;
                        }));
                    }
                });
                t.Start();
            }
        }
    }
}