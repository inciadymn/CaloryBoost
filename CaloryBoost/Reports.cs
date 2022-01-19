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


        }
    }
}
