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
    public partial class Admission_Form2cs : Form
    {
        int Count = 0;

        public Admission_Form2cs()
        {
            InitializeComponent();
        }

        private void Admission_Form2cs_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Welcome to Naresh it");
        }

        private void cbC_CheckedChanged(object sender, EventArgs e)
        {
            rbNormal.Checked = true;
            int amount = int.Parse(tbFee.Text);
            CheckBox c1 = sender as CheckBox;

            if (c1.Checked)
            {
                Count += 1;
                amount += Convert.ToInt32(c1.Tag);
            }
            else
            {
                Count -= 1;
                amount -= Convert.ToInt32(c1.Tag);
            }
            // MessageBox.Show(tbFee.Text);
            tbFee.Text = amount.ToString();
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rb1 = sender as RadioButton;
            int amount = int.Parse(tbFee.Text);

            if (rb1.Checked)
            {
                amount += (Count * Convert.ToInt32(rb1.Tag));
            }
            else
            {
                amount -= (Count * Convert.ToInt32(rb1.Tag));
            }
            tbFee.Text = amount.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Are you want to reset the information", "Caution", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            
            if (msg.ToString() == "Yes")
            {
                foreach (Control c1 in gbCourses.Controls)
                {
                    CheckBox checkbox = c1 as CheckBox;
                    checkbox.Checked = false;
                }


                foreach (Control c2 in gbTrack.Controls)
                {
                    RadioButton radio = c2 as RadioButton;
                    radio.Checked = false;
                }
                foreach (Control control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox control1 = (TextBox)control;
                        control1.Clear();
                    }
                }
                tbFee.Text = "0";
                tbName.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                MessageBox.Show("Select at least 1 Course");
            }
            else
            {
                MessageBox.Show("Thank you for intrest! Our team shortly contact with you", "NareshIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

