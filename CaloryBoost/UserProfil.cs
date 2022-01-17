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
    public partial class UserProfil : Form
    {
        User user;
        UserProfilService userProfileService;
        public UserProfil(User user)
        {
            InitializeComponent();
            this.user = user;
            userProfileService = new UserProfilService();
        }
        private void UserProfil_Load(object sender, EventArgs e)
        {

            lblFullName.Text = user.FirstName + " " + user.LastName;
            lblDate.Text = DateTime.Now.Date.ToString();
            lblTotalCal.Text = userProfileService.GetByCalory(user.ID).ToString();
        }
        
        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            int mealId = 1;
            Meal meal = new Meal(user,mealId);
            this.Hide();
            meal.ShowDialog();
            this.Show();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            int mealId = 2;
            Meal meal = new Meal(user, mealId);
            this.Hide();
            meal.ShowDialog();
            this.Show();
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            int mealId = 3;
            Meal meal = new Meal(user, mealId);
            this.Hide();
            meal.ShowDialog();
            this.Show();
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            int mealId = 4;
            Meal meal = new Meal(user, mealId);
            this.Hide();
            meal.ShowDialog();
            this.Show();
        }
    }
}
