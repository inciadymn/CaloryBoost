using CaloryBoost.BLL.Services;
using CaloryBoost.Model;
using CaloryBoost.Model.Entities;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;


namespace CaloryBoost
{
    public partial class Meal : Form
    {
        MealService mealService;
        public Meal(User user, int mealId)
        {
            InitializeComponent();
            this.user = user;
            this.mealId = mealId;
            mealService = new MealService();
        }
        User user;
        int mealId;
        private void Meal_Load(object sender, EventArgs e)
        {
            string mealName = mealService.GetMealName(mealId);
            grpMealName.Text = mealName;
            ListViewItem lvi;
            List<SelectedFood> addedFoods = mealService.GetFood(mealId, user.ID);
            double total = 0;
            foreach (SelectedFood item in addedFoods)
            {
                lvi = new ListViewItem();
                lvi.Text = item.FoodName;
                lvi.Tag = item.FoodId;
                lvi.SubItems.Add(item.Amount.ToString());
                lvi.SubItems.Add(item.Calory.ToString());
                lvMealDetails.Items.Add(lvi);
                total += item.Calory;
            }
            lblTotalCalory.Text = mealService.GetMealName(mealId) + " " + "Total Calory";
            lblCalory.Text = total.ToString();
            List<Food> foods = mealService.FoodsList();
            foreach (Food item in foods)
            {
                AddFoodsControls(item);
            }
            

        }

        private void AddFoodsControls(Food item)
        {
            Panel pnlFrame = new Panel();
            pnlFrame.BackColor = Color.Green;
            pnlFrame.Width = 310;

            PictureBox pbFoodPic = new PictureBox();
            pbFoodPic.BackColor = Color.Yellow;
            pbFoodPic.Height = 90;
            pbFoodPic.Width = 95;
            pbFoodPic.Image = Image.FromFile(item.PhotoPath);
            pbFoodPic.Location = new Point(5, 5);

            Label lblFoodName = new Label();
            lblFoodName.BackColor = Color.White;
            lblFoodName.Width = 150;
            lblFoodName.Text = item.Name;
            lblFoodName.Tag = $"lblFoodName_{item.ID}";
            lblFoodName.Location = new Point(110, 10);

            Label lblDescription = new Label();
            lblDescription.BackColor = Color.White;
            lblDescription.Width = 190;
            lblDescription.Text = item.Description;
            lblDescription.Location = new Point(110, 70);

            RJButton addButton = new RJButton();
            addButton.BackColor = Color.Blue;
            addButton.Width = 30;
            addButton.Height = 30;
            addButton.BorderRadius = 15;
            addButton.Tag = $"{item.ID}";
            //addButton.Image = Image.FromFile(@"..\..\İmages\plus_icon.jpg");
            //addButton2.BackgroundImageLayout = ImageLayout.Center;
            addButton.Location = new Point(270, 20);


            Label lblAmount = new Label();
            lblAmount.BackColor = Color.White;
            lblAmount.Text = "Amount :";
            lblAmount.ForeColor = Color.Black;
            lblAmount.Width = 50;
            lblAmount.Height = 15;
            lblAmount.Tag = $"lblAmount_{item.ID}";
            lblAmount.Location = new Point(110, 45);


            txtAmount.BackColor = Color.White;
            txtAmount.Tag = $"txtAmount_{item.ID}";
            txtAmount.Location = new Point(162, 42);

            pnlFrame.Controls.Add(pbFoodPic);
            pnlFrame.Controls.Add(lblFoodName);
            pnlFrame.Controls.Add(lblDescription);
            pnlFrame.Controls.Add(addButton);
            pnlFrame.Controls.Add(lblAmount);
            pnlFrame.Controls.Add(txtAmount);
            flpFoods.Controls.Add(pnlFrame);
        }

        TextBox txtAmount = new TextBox();
        Button clicked;
        private void addButton_Click(object sender, EventArgs e)
        {
            clicked = sender as Button;
            bool check = mealService.Insert(new UserMealFood
            {
                FoodID = Convert.ToInt32(clicked.Tag),
                MealID = mealId,
                UserID = user.ID,
                Portion = Convert.ToDouble(txtAmount.Text)
            });
            MessageBox.Show(check ? "Ekleme başarılı" : "Ekleme başarısız");
            lvMealDetails.Items.Clear();

        }
        int foodId;
        private void lvMealDetails_MouseClick(object sender, MouseEventArgs e)
        {
            foodId = Convert.ToInt32(lvMealDetails.SelectedItems[0].Tag);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check = mealService.Delete(foodId);
            MessageBox.Show(check ? "Silme başarılı" : "Silme başarısız");
        }
        UserMealFood userMealFood;
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            bool check = mealService.Update(new UserMealFood
            {
                FoodID = Convert.ToInt32(foodId),
                MealID = mealId,
                UserID = user.ID,
                Portion = Convert.ToDouble(txtUpdateAmount.Text)
            });
            MessageBox.Show(check ? "Güncelleme başarılı" : "Güncelleme başarısız");
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {

            flpFoods.Controls.Clear();
            List<Food> foods = mealService.FoodsList();
            foreach (Food item in foods.Where(f => f.Name.Contains(txtSearch.Text)))
            {
                AddFoodsControls(item);
            }


        }
    }

}


