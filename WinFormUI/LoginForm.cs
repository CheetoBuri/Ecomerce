using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace WinFormUI
{
    public partial class LoginForm : Form
    {
        private UserService userService;
        public LoginForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var users = userService.GetAllUsers();
            var user = users.FirstOrDefault(u => u.UserName == txtUsername.Text && u.Password == txtPassword.Text);

            if (user != null)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}
