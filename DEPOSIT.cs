using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATMtuto
{
    public partial class DEPOSIT : Form
    {
        public DEPOSIT()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=LAPTOP-JK6V8OIJ\\SQLEXPRESS;Initial Catalog=ATM;Integrated Security=True");
        string Acc = Login.AccNumber;
        private void addtransaction()
        {
            Con.Open();
            string TrType = "DEPOSIT";
            try
            {
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
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == ""|| Convert.ToInt32(textBox1.Text)<=0)
            {
                MessageBox.Show("Enter Te Amount TO Deposit");
            }
            else
            {
                newbalance = oldbalance + Convert.ToInt32(textBox1.Text);
                try
                {
                    Con.Open();
                    string querry = "update ATMDb set Balance=" + newbalance + "where Accnum='" + Acc + "'";
                    SqlCommand cmd = new SqlCommand(querry,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucess Deposit");
                    Con.Close();
                    addtransaction();
                    HOME home = new HOME();
                    home.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            HOME home = new HOME();
            home.Show();
            this.Hide();
        }
        int oldbalance,newbalance;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from ATMDb where Accnum = '" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32 (dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DEPOSIT_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
