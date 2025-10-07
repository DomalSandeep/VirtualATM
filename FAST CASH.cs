using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATMtuto
{
    public partial class FAST_CASH : Form
    {
        public FAST_CASH()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bal < 100)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 100;
                try
                {
                    Con.Open();
                    string querry = "update ATMDb set Balance=" + newbalance + "where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(querry, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucess withdrawal");
                    Con.Close();
                    addtransaction1();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            HOME hOME= new HOME();
            hOME.Show();
            this.Hide();
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
        private void FAST_CASH_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        private void addtransaction1()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO TeansactionTbl values('" + Acc + "','" + TrType + "','"+100+"','" + DateTime.Today.Date.ToString() + "')";
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
        private void addtransaction2()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO TeansactionTbl values('" + Acc + "','" + TrType + "','" + 500 + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cd = new SqlCommand(query, Con); cd.ExecuteNonQuery();
                // MessageBox.Show("Account created sucessfully");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addtransaction3()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO TeansactionTbl values('" + Acc + "','" + TrType + "','" + 1000 + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cd = new SqlCommand(query, Con); cd.ExecuteNonQuery();
                // MessageBox.Show("Account created sucessfully");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addtransaction4()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO TeansactionTbl values('" + Acc + "','" + TrType + "','" + 2000 + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cd = new SqlCommand(query, Con); cd.ExecuteNonQuery();
                // MessageBox.Show("Account created sucessfully");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addtransaction5()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO TeansactionTbl values('" + Acc + "','" + TrType + "','" + 5000 + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cd = new SqlCommand(query, Con); cd.ExecuteNonQuery();
                // MessageBox.Show("Account created sucessfully");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void addtransaction6()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "INSERT INTO TeansactionTbl values('" + Acc + "','" + TrType + "','" + 10000 + "','" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cd = new SqlCommand(query, Con); cd.ExecuteNonQuery();
                // MessageBox.Show("Account created sucessfully");
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bal < 500)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 500;
                try
                {
                    Con.Open();
                    string querry = "update ATMDb set Balance=" + newbalance + "where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(querry, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucess withdrawal");
                    Con.Close();
                    addtransaction2();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bal < 1000)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 1000;
                try
                {
                    Con.Open();
                    string querry = "update ATMDb set Balance=" + newbalance + "where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(querry, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucess withdrawal");
                    Con.Close();
                    addtransaction3();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bal < 2000)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 2000;
                try
                {
                    Con.Open();
                    string querry = "update ATMDb set Balance=" + newbalance + "where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(querry, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucess withdrawal");
                    Con.Close();
                    addtransaction4();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bal < 5000)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 5000;
                try
                {
                    Con.Open();
                    string querry = "update ATMDb set Balance=" + newbalance + "where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(querry, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucess withdrawal");
                    Con.Close();
                    addtransaction5();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bal < 10000)
            {
                MessageBox.Show("Balance Can Not Be Negative");
            }
            else
            {
                int newbalance = bal - 10000;
                try
                {
                    Con.Open();
                    string querry = "update ATMDb set Balance=" + newbalance + "where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(querry, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucess withdrawal");
                    Con.Close();
                    addtransaction6();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
