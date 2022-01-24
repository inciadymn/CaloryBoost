using CaloryBoost.BLL.Services;
using CaloryBoost.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaloryBoost
{
    public partial class UserLogin : Form
    {
        UserService userService;
        public UserLogin()
        {
            InitializeComponent();
            userService = new UserService();
        }
        User user;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Texts.Trim();
            string password = txtPassword.Texts.Trim();
            try
            {
                user = userService.CheckLogin(email, password);
                if (user != null)
                {
                    UserProfil userProfile = new UserProfil(user);
                    userProfile.ShowDialog();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                this.Close();
            }
        }

        private void lbkToRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
        }
    }
}
