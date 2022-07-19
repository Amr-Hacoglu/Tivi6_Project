using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tivi6_Project
{
    public partial class AddProgramGuest : Form
    {
        public AddProgramGuest()
        {
            InitializeComponent();
        }        

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Documents\Tivi6Db.mdf;Integrated Security=True;Connect Timeout=30");

        private void AddProgramGuest_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (FNameTb.Text == "" || PhoneTb.Text == "" || AgeTb.Text == "" || PartyTb.Text == "" || TimeTb.Text == "" || DurationTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    //string query = "insert into GuestTbl values(" + NameTb.Text + ",'" + PhoneTb.Text + "'," + AgeTb.Text + "','" + GenderCb.SelectedItem.ToString() + ",'" + PartyTb.Text + "'," + TimeTb.Text + "," + DurationTb.Text + ",'" + NoteTb.Text + "')";
                    string query = "insert into GuestTbl (GFName,GLName,GPhone,GAge,GGen,GPartyName,GTime,GDuration,GNote) values (@GFName ,@GLName ,@GPhone ,@GAge,@GGen,@GPartyName,@GTime,@GDuration,@GNote)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@GFName", FNameTb.Text);
                    cmd.Parameters.AddWithValue("@GLName", LNameTb.Text);
                    cmd.Parameters.AddWithValue("@GPhone", PhoneTb.Text);
                    cmd.Parameters.AddWithValue("@GAge", AgeTb.Text);
                    cmd.Parameters.AddWithValue("@GGen", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@GPartyName", PartyTb.Text);
                    cmd.Parameters.AddWithValue("@GTime", TimeTb.Text);
                    cmd.Parameters.AddWithValue("@GDuration", DurationTb.Text);
                    cmd.Parameters.AddWithValue("@GNote", NoteTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guest Successfully Added");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FNameTb.Text = "";
            LNameTb.Text = "";
            PhoneTb.Text = "";
            AgeTb.Text = "";
            GenderCb.SelectedIndex = 0;
            PartyTb.Text = "";
            TimeTb.Text = "";
            DurationTb.Text = "";
            NoteTb.Text = "";
        }

        private void label3_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
