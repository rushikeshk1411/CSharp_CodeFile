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

namespace Configure
{
    public partial class ConfigureLable : Form
    {
        DataSet ds;
        SqlDataAdapter da;

        public ConfigureLable()
        {
            InitializeComponent();
        }

        private void ConfigureLable_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            da = new SqlDataAdapter();
            label1.Text = ConfigurationManager.AppSettings.Get("ComapnyName").ToString();
            label2.Text = "Address: " + ConfigurationManager.AppSettings.Get("Address").ToString();
            label3.Text = "Contact: " + ConfigurationManager.AppSettings.Get("contact").ToString();
            label4.Text = "Email: " + ConfigurationManager.AppSettings.Get("email").ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            button1.Text = str;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["ExcelCon"].ConnectionString;
            button2.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
