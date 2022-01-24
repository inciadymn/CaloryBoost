﻿using CaloryBoost.BLL.Services;
using CaloryBoost.Model;
using CaloryBoost.Model.Entities;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace CaloryBoost
{

    public partial class Meal : Form
    {
        DateTime selectedDate;
        MealService mealService;
        public Meal(User user, int mealId, DateTime selectedDate)
        {
            InitializeComponent();
            this.selectedDate = selectedDate;
            this.user = user;
            this.mealId = mealId;
            mealService = new MealService();
        }

        User user;
        int mealId;
        double total = 0;

        private void Meal_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;


            string mealName = mealService.GetMealName(mealId);
            grpMealName.Text = mealName;

            FillListView();

            lblTotalCalory.Text = mealService.GetMealName(mealId) + " " + "Total Calory";

            List<Food> foods = mealService.FoodsList();
            foreach (Food item in foods)
            {
                AddFoodsControls(item);
            }
        }

        private void FillListView()
        {
            ListViewItem lvi;
            List<SelectedFood> addedFoods = mealService.GetFood(mealId, user.ID, selectedDate);
            total = 0;
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

            lblCalory.Text = total.ToString();
        }


        private void AddFoodsControls(Food item)
        {
            Panel pnlFrame = new Panel();
            pnlFrame.BackColor = Color.Transparent;
            pnlFrame.Width = 310;

            PictureBox pbFoodPic = new PictureBox();
            pbFoodPic.BackColor = Color.White;
            pbFoodPic.Height = 90;
            pbFoodPic.Width = 90;
            pbFoodPic.Image = Image.FromFile(item.PhotoPath);
            pbFoodPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFoodPic.Location = new Point(5, 5);

            Label lblFoodName = new Label();
            lblFoodName.BackColor = Color.Transparent;
            lblFoodName.ForeColor = Color.Black;
            lblFoodName.Font = new Font("Tahoma", 20);
            lblFoodName.Width = 150;
            lblFoodName.Text = item.Name;
            lblFoodName.Tag = $"lblFoodName_{item.ID}";
            lblFoodName.Location = new Point(110, 10);

            Label lblDescription = new Label();
            lblDescription.BackColor = Color.Transparent;
            lblDescription.ForeColor = Color.Black;
            lblFoodName.Font = new Font("Tahoma", 8);
            lblDescription.Width = 190;
            lblDescription.Text = item.Description;
            lblDescription.Location = new Point(110, 70);

            RJButton addButton = new RJButton();
            addButton.BackColor = Color.Black;
            addButton.Width = 35;
            addButton.Height = 35;
            addButton.BorderRadius = 7;
            addButton.Tag = $"{item.ID}";
            addButton.Text = "+";
            addButton.Font = new Font("Tahoma", 14, FontStyle.Bold);
            addButton.TextAlign = ContentAlignment.MiddleCenter;
            addButton.Location = new Point(270, 20);

            Label lblAmount = new Label();
            lblAmount.BackColor = Color.Transparent;
            lblAmount.Text = "Amount :";
            lblAmount.ForeColor = Color.Black;
            lblAmount.Font = new Font("Tahoma", 8);
            lblAmount.Width = 50;
            lblAmount.Height = 15;
            lblAmount.Tag = $"lblAmount_{item.ID}";
            lblAmount.Location = new Point(110, 45);

            TextBox txtAmount = new TextBox();
            txtAmount.BackColor = Color.White;
            txtAmount.Tag = $"txtAmount_{item.ID}";
            txtAmount.Location = new Point(162, 42);

            addButton.Click += (sender, e) => { AddClickedButton(sender, e, txtAmount); };

            pnlFrame.Controls.Add(pbFoodPic);
            pnlFrame.Controls.Add(lblFoodName);
            pnlFrame.Controls.Add(lblDescription);
            pnlFrame.Controls.Add(addButton);
            pnlFrame.Controls.Add(lblAmount);
            pnlFrame.Controls.Add(txtAmount);
            flpFoods.Controls.Add(pnlFrame);
        }

        Button clicked;
        private void AddClickedButton(object sender, EventArgs e, TextBox txtAmont)
        {
            try
            {
                clicked = sender as Button;
                bool check = mealService.Insert(new UserMealFood
                {
                    FoodID = Convert.ToInt32(clicked.Tag),
                    MealID = mealId,
                    UserID = user.ID,
                    CreatedDate = selectedDate,
                    Portion = Convert.ToDouble(txtAmont.Text.ToString().Replace('.', ',').Trim())
                });
                MessageBox.Show(check ? "Ekleme başarılı" : "Ekleme başarısız");
                lvMealDetails.Items.Clear();

                FillListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtAmont.Clear();
            }
        }

        int foodId;
        private void lvMealDetails_MouseClick(object sender, MouseEventArgs e)
        {
            foodId = Convert.ToInt32(lvMealDetails.SelectedItems[0].Tag);
            if (lvMealDetails.SelectedItems.Count == 1)
            {
                btnDelete.Enabled = true;
            }
            if (lvMealDetails.SelectedItems.Count == 1 && txtUpdateAmount.Texts != string.Empty)
            {
                btnUpdate.Enabled = true;
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = mealService.Delete(new UserMealFood
                {
                    FoodID = Convert.ToInt32(foodId),
                    MealID = mealId,
                    UserID = user.ID
                }, selectedDate);
                MessageBox.Show(check ? "Silme başarılı" : "Silme başarısız");
                lvMealDetails.Items.Clear();
                FillListView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnDelete.Enabled = false;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = mealService.Update(new UserMealFood
                {
                    FoodID = Convert.ToInt32(foodId),
                    MealID = mealId,
                    UserID = user.ID,
                    Portion = Convert.ToDouble(txtUpdateAmount.Texts.ToString().Replace('.', ',').Trim())
                }, selectedDate);
                if (lvMealDetails.SelectedItems.Count > -1 && txtUpdateAmount.Texts != null)
                {
                    btnUpdate.Enabled = true;
                }
                MessageBox.Show(check ? "Güncelleme başarılı" : "Güncelleme başarısız");

                txtUpdateAmount.Texts = "";
                lvMealDetails.Items.Clear();
                FillListView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                btnUpdate.Enabled = false;
            }

        }


        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            flpFoods.Controls.Clear();
            string searchFood = txtSearch.Texts;
            List<Food> foods = mealService.FoodsList(searchFood);

            foreach (Food item in foods)
            {
                AddFoodsControls(item);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}


