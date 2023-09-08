using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.OleDb;

namespace Configure
{
    public partial class BuildRelation : Form
    {
        DataSet ds;
        SqlDataAdapter ad1;
        SqlDataAdapter ad2;
        DataRelation rp;
        public BuildRelation()
        {
            InitializeComponent();
        }

        private void BuildRelation_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            string SqlCon = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            ad1 = new SqlDataAdapter("Select * from Dept", SqlCon);
            ad1.Fill(ds, "Dept");
            dataGridView1.DataSource = ds.Tables["Dept"];

            ad2 = new SqlDataAdapter("Select * from Emp", SqlCon);
            ad2.Fill(ds, "Employee");
            dataGridView2.DataSource = ds.Tables["Employee"];

            rp = new DataRelation("ParentChild", ds.Tables["Dept"].Columns["Deptno"], ds.Tables["Employee"].Columns["Deptno"]);

            ds.Tables["Employee"].Columns["Deptno"].DefaultValue = 10;
            ds.Relations.Add(rp);
            rp.ChildKeyConstraint.DeleteRule = Rule.SetDefault;
        }
    }
}
