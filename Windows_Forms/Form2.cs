
namespace Windows_Form_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the windows application Developement");
        }

        private void Form2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are clicked on the Form");
        }
    }
}
