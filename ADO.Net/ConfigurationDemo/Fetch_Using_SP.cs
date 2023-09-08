using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Configure
{
    public partial class Fetch_Using_SP : Form
    {
        SqlDataReader dr;
        SqlConnection conn;
        SqlCommand cmd;

        public Fetch_Using_SP()
        {
            InitializeComponent();
        }

        private void Fetch_Using_SP_Load(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            conn = new SqlConnection(str);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd = new SqlCommand("Select_Emp", conn);
            
            conn.Open();
            dr = cmd.ExecuteReader();
            textBox1.Text = dr["Empno"].ToString();
            textBox2.Text = dr["Ename"].ToString();
            textBox3.Text = dr["Job"].ToString();
            textBox4.Text = dr["Salary"].ToString();

        }
    }
}
