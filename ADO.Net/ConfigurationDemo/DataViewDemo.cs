using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configure
{
    public partial class DataViewDemo : Form
    {
        DataSet ds;
        SqlDataAdapter da1;
        SqlDataAdapter da2;
        bool flag;
        public DataViewDemo()
        {
            InitializeComponent();
        }

        private void DataViewDemo_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            SqlConnection con = new SqlConnection("User Id=SA;Password=!@#$1234QWer;Database=CSDB;Data Source=RUSHIKESH");
            da1 = new SqlDataAdapter("Select * from Emp", con);
            da2 = new SqlDataAdapter("Select * from Dept", con);

            da1.Fill(ds, "Emp");
            da2.Fill(ds, "Dept");
            dataGridView1.DataSource = ds.Tables["Emp"].DefaultView;

            
            comboBox1.DataSource = ds.Tables["Dept"];
            comboBox1.DisplayMember = "Dname";
            comboBox1.ValueMember = "Deptno";

            comboBox1.Text = "Select Department";
            flag = true;
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag)
            {
                DataView dv = ds.Tables["Emp"].DefaultView;
                dv.RowFilter = "Deptno=" + comboBox1.SelectedValue;
            }
        }
    }
}
