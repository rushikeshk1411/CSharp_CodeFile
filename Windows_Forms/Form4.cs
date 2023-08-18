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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = "";
            if (sender is Button)
            {
                Button b = (Button)sender;
                if (b.Name == "button1")
                    MessageBox.Show("Button1 is clicked by the user.");
                else
                    MessageBox.Show("Button2 is clicked by the user.");
            }
            else if (sender is TextBox)
                MessageBox.Show("You clikced on the textbox");

            else
                MessageBox.Show("hellow you clicked on Form");

        }

    }
}
