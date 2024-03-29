﻿using System;
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
    public partial class VeiwGuests : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\90538\Documents\Tivi6Db.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void populate() // display the data on the form
        {
            Con.Open();
            string qurey = "SELECT GId AS ID , GFName AS Adı , GLName AS SoyAdı , GPhone AS TelNumarası , GAge AS Yaş , GGen AS Cinsiyet , GPartyName AS PartyAdı , GTime AS Saat , GDuration AS Süre , GNote AS Note FROM GuestTbl";
            SqlDataAdapter sda = new SqlDataAdapter(qurey, Con);
            SqlCommandBuilder build = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            GuestSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        public VeiwGuests()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VeiwGuests_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
        private void FilterByName()
        {
            Con.Open();
            string qurey = "SELECT * FROM GuestTBL WHERE GLName = '" + SearchGuest.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(qurey, Con);
            SqlCommandBuilder build = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            GuestSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FilterByName();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void GuestSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
