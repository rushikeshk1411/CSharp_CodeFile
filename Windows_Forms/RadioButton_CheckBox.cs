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
    public partial class RadioButton_CheckBox : Form
    {
        int Checkcount = 0;
        int buttonCount = 0;
        public RadioButton_CheckBox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CheckBox is Checked");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ch = sender as CheckBox;
            if (ch.Checked)
            {
                MessageBox.Show($"YOu clicked {ch.Name}");
                Checkcount++;
            }
            else
            {
                MessageBox.Show($"You unchecked {ch.Name}");
                Checkcount--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = sender as Button;
                if (button1.Name == "button1")
                {
                    MessageBox.Show($"You clicked {Checkcount}");
                }
                else
                {
                    MessageBox.Show($"You clicked {buttonCount}");
                }
            }

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton rd1 = (RadioButton)sender;
                if (rd1.Checked)
                {
                    buttonCount++;
                    MessageBox.Show($"You Checked {rd1.Name}");
                }
                else
                {
                    buttonCount--;
                    MessageBox.Show($"You uncheked {rd1.Name}");
                }
            }
        }
    }
}
