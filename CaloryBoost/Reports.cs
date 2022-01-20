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
    public partial class Reports : Form
    {
        ReportService reportService;
        public Reports(User user)
        {
            InitializeComponent();
            this.user = user;
            reportService = new ReportService();
        }

        User user;
        int breakFastMealID=1;
        int lunchMealID = 2;
        int dinnerMealID = 3;
        int snackMealID = 4;
        private void Reports_Load(object sender, EventArgs e)
        {
            lblBreakFastFoodName.Text = reportService.GetFoodName(user.ID, breakFastMealID);
            lblLunchFoodName.Text = reportService.GetFoodName(user.ID, lunchMealID);
            lblDinnerFoodName.Text = reportService.GetFoodName(user.ID, dinnerMealID);
            lblSnackFoodName.Text = reportService.GetFoodName(user.ID, snackMealID);

            double weeklyAverage = Math.Round(reportService.GetWeeklyAverageCalory(user.ID),2);
            lblWeeklyCaloryAverage.Text = weeklyAverage.ToString();

            double monthlyAverage = Math.Round(reportService.GetMonthlyAverageCalory(user.ID), 2);
            lblMonhtlyCaloryAverage.Text = monthlyAverage.ToString();

            double userWeeklyAverage = Math.Round(reportService.GetWeeklyAverageCaloryByUser(user.ID),2);
            lblUserWeeklyCalory.Text = userWeeklyAverage.ToString();

            double userMonthlyAverage = Math.Round(reportService.GetMonthlyAverageCaloryByUser(user.ID), 2);
            lblUserMonhtlyCalory.Text = userMonthlyAverage.ToString();

            lblUserWeeklyCalory.ForeColor = weeklyAverage > userWeeklyAverage ? Color.Green : Color.Red;

            lblUserMonhtlyCalory.ForeColor = monthlyAverage > userMonthlyAverage ? Color.Green : Color.Red;


            grpFullName.Text = user.FirstName.ToUpper() + " " + user.LastName.ToUpper();

            pcRed.BackColor = Color.Red;
            pcGreen.BackColor = Color.Green;

            lblAboveAverage.ForeColor = Color.Red;
            lblBelowAverage.ForeColor = Color.Green;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
