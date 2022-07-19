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

namespace Tivi6_Project
{
    public partial class Payment : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Documents\Tivi6Db.mdf;Integrated Security=True;Connect Timeout=30");

        private void FilterByName()
        {
            Con.Open();
            string qurey = "SELECT * FROM PaymentTbl WHERE PGuest = '"+ SearchName.Text+ "'";
            SqlDataAdapter sda = new SqlDataAdapter(qurey, Con);
            SqlCommandBuilder build = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populate() // display the data on the form
        {
            Con.Open();
            string qurey = "SELECT * FROM PaymentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(qurey, Con);
            SqlCommandBuilder build = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillName()
        {
            Con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT GFName,GLName FROM GuestTBL",Con);
            SqlCommand cmd = new SqlCommand("SELECT GLName FROM GuestTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("GLName", typeof(string));
            //dt.Columns.Add("GLName", typeof(string));
            dt.Load(rdr);
            PayNameCb.ValueMember = "GLName";
            PayNameCb.DataSource = dt;
            Con.Close();
            populate();
        }
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PayNameCb.Text = "";
            PayAmtTb.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // الكنية في صندووق الاختبار
            FillName();
            populate();
        }
        //int key = 1;
        private void button3_Click(object sender, EventArgs e)
        {
            if(PayNameCb.Text == "" || PayAmtTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string PayPeriode = Periode.Value.Day.ToString() +"/"+ Periode.Value.Month.ToString() + "/" + Periode.Value.Year.ToString();
                Con.Open();
                string query = "INSERT INTO PaymentTbl VALUES ('" + PayPeriode + "','" + PayNameCb.SelectedValue.ToString() + "'," + PayAmtTb.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Amount Paid Successfully ");
                
                Con.Close();
                populate();


                /*
                string PayPeriode = Periode.Value.Month.ToString() + Periode.Value.Year.ToString(); // + Periode.Value.Day.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM PaymentTbl WHERE PGuest = '" + PayNameCb.SelectedValue.ToString() + "' AND PMonth = '"  + PayPeriode + "'",Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already Paid For This Month");
                }
                else
                {
                    string query = "INSERT INTO PaymentTbl VALUES ('"+PayPeriode+"','"+PayNameCb.SelectedValue.ToString() + "'," + PayAmtTb.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid Successfully ");
                }
                Con.Close();
                populate();
                */
            }
        }

        private void PaymentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PayNameCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FilterByName();
            SearchName.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
