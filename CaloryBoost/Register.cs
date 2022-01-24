﻿using CaloryBoost.BLL.Services;
using CaloryBoost.Model.Entities;
using System;
using System.Windows.Forms;

namespace CaloryBoost
{
    public partial class Register : Form
    {
        UserService userService;
        public Register()
        {
            InitializeComponent();
            userService = new UserService();
        }

        User user;
        bool check;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                user = new User()
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    BirthDate = dtpcDate.Value,
                    Gender = rdMale.Checked ? rdMale.Text.Trim() : rdFemale.Text.Trim(),
                    Phone = mtxtPhone.Text.Trim()
                };

                check = userService.Insert(user);

                MessageBox.Show(check ? "Kayıt gerçekleşti" : "Bilgilerinizi kontrol ediniz");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (check)
            {
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
