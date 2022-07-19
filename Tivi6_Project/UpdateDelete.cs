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
    public partial class UpdateDelete : Form
    {

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Documents\Tivi6Db.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate() // display the data on the form
        {
            Con.Open();
            string qurey = "SELECT * FROM GuestTBL";
            SqlDataAdapter sda = new SqlDataAdapter(qurey, Con);
            SqlCommandBuilder build = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            GuestSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        public UpdateDelete()
        {
            InitializeComponent();
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {

        }

        private void UpdateDelete_Load_1(object sender, EventArgs e)
        {
            populate();
        }

        int key=0;
        private void GuestSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // عرض البيانات على اليسار للتعديل عليهن او حذفهن
            
            key = Convert.ToInt32(GuestSDGV.SelectedRows[0].Cells[0].Value.ToString());
            FNameTb.Text = GuestSDGV.SelectedRows[0].Cells[1].Value.ToString();
            LNameTb.Text = GuestSDGV.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = GuestSDGV.SelectedRows[0].Cells[3].Value.ToString();
            AgeTb.Text = GuestSDGV.SelectedRows[0].Cells[4].Value.ToString();
            GenderCb.Text = GuestSDGV.SelectedRows[0].Cells[5].Value.ToString();
            PartyTb.Text = GuestSDGV.SelectedRows[0].Cells[6].Value.ToString();
            TimeTb.Text = GuestSDGV.SelectedRows[0].Cells[7].Value.ToString();
            DurationTb.Text = GuestSDGV.SelectedRows[0].Cells[8].Value.ToString();
            NoteTb.Text = GuestSDGV.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            mainf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(key == 0)
            {
                MessageBox.Show("Select The Guest To Be Deleted ");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM GuestTBL WHERE GID = " + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guest Deleted Successfully");
                    Con.Close();
                    populate();
                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0 || FNameTb.Text == "" || LNameTb.Text == "" || PhoneTb.Text == "" || AgeTb.Text == "" || GenderCb.Text == "" || PartyTb.Text == "" || TimeTb.Text == "" || DurationTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE GuestTBL SET GFName='" + FNameTb.Text + "', GLName = '" + LNameTb.Text + "',GPhone = '" + PhoneTb.Text + "',GAge = '" + AgeTb.Text + "', GGen = '" + GenderCb.Text + "', GPartyName = '" + PartyTb.Text + "', GTime = '" + TimeTb.Text + "', GDuration =  '" + DurationTb.Text + "', GNote =  '" + NoteTb.Text + "' WHERE GId = " + key + ";";
                    
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guest Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
