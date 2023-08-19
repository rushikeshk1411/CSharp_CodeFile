using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Project
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Button btn1 = sender as Button;
            if (btn1.Name == "btnReset")
            {
                foreach (Control c1 in this.Controls)
                {
                    if (c1 is TextBox)
                    {
                        TextBoxBase t1 = sender as TextBoxBase;
                        t1.Clear();
                    }
                }

            }
            else if(btn1.Name == "btnSave") 
            {
                MessageBox.Show("Thank you for registration", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
