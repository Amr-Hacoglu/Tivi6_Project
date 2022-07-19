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

        }
    }
}
