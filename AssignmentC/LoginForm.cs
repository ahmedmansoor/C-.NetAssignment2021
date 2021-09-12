using System;
using System.Windows.Forms;

namespace AssignmentC
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.email = textBox_email.Text;
            login.password = textBox_password.Text;
            bool valid = login.Validation(login);

            if (valid)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Details");
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

            textBox_password.UseSystemPasswordChar = true;
        }
    }
}
