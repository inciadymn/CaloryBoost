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
        DateTime selectedDate;
        public UserProfil(User user)
        {
            InitializeComponent();
            this.user = user;
            userProfileService = new UserProfilService();
        }
        private void UserProfil_Load(object sender, EventArgs e)
        {
            lblFullName.Text = user.FirstName + " " + user.LastName;
            selectedDate = dtpSelectedDate.Value.Date;
            //lblDate.Text = DateTime.Now.ToShortDateString();
            lblTotalCal.Text = userProfileService.GetByCalory(user.ID,selectedDate).ToString()+" "+"kcal";

        }
        
        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            int mealId = 1;
            Meal meal = new Meal(user,mealId, selectedDate);
            this.Hide();
            meal.ShowDialog();
            this.Show();

            lblTotalCal.Text = userProfileService.GetByCalory(user.ID,selectedDate).ToString() + " " + "kcal";
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            int mealId = 2;
            Meal meal = new Meal(user, mealId,selectedDate);
            this.Hide();
            meal.ShowDialog();
            this.Show();

            lblTotalCal.Text = userProfileService.GetByCalory(user.ID,selectedDate).ToString() + " " + "kcal";
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            int mealId = 3;
            Meal meal = new Meal(user, mealId,selectedDate);
            this.Hide();
            meal.ShowDialog();
            this.Show();

            lblTotalCal.Text = userProfileService.GetByCalory(user.ID,selectedDate).ToString() + " " + "kcal";
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            int mealId = 4;
            Meal meal = new Meal(user, mealId,selectedDate);
            this.Hide();
            meal.ShowDialog();
            this.Show();

            lblTotalCal.Text = userProfileService.GetByCalory(user.ID,selectedDate).ToString() + " " + "kcal";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(user);
            this.Hide();
            reports.ShowDialog();
            this.Show();
        }

        private void dtpSelectedDate_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = dtpSelectedDate.Value.Date;
            lblTotalCal.Text = userProfileService.GetByCalory(user.ID, selectedDate).ToString() + " " + "kcal";
        }
    }
}
