using RJCodeAdvance.RJControls;
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
    public partial class Meal : Form
    {
        public Meal()
        {
            InitializeComponent();
        }

        private void Meal_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Panel pnlFrame = new Panel();
                pnlFrame.BackColor = Color.Green;
                pnlFrame.Width = 310;
                

                PictureBox pbFoodPic = new PictureBox();
                pbFoodPic.BackColor = Color.Yellow;
                pbFoodPic.Height = 90;
                pbFoodPic.Width =95;
                pbFoodPic.Location = new Point(5, 5);

                Label lblFoodName = new Label();
                lblFoodName.BackColor = Color.White;
                lblFoodName.Width = 150;
                lblFoodName.Location = new Point(110, 10);

                Label lblDescription = new Label();
                lblDescription.BackColor = Color.White;
                lblDescription.Width = 190;
                lblDescription.Location = new Point(110, 70);
             
                RJButton addButton2 = new RJButton();               
                addButton2.BackColor = Color.Blue;
                addButton2.Width = 30;
                addButton2.Height = 30;
                addButton2.BorderRadius = 15;               
                //addButton2.Image = Image.FromFile(@"..\..\İmages\plus_icon.jpg");
                //addButton2.BackgroundImageLayout = ImageLayout.Center;
                addButton2.Location = new Point(270, 20);

                Label lblAmount = new Label();
                lblAmount.BackColor = Color.White;
                lblAmount.Text = "Amount :";
                lblAmount.ForeColor = Color.Black;
                lblAmount.Width = 50;
                lblAmount.Height= 15;
                lblAmount.Location = new Point(110, 45);

                TextBox txtAmount = new TextBox();
                txtAmount.BackColor = Color.White;
                txtAmount.Location = new Point(162, 42);




                pnlFrame.Controls.Add(pbFoodPic);
                pnlFrame.Controls.Add(lblFoodName);
                pnlFrame.Controls.Add(lblDescription);                
                pnlFrame.Controls.Add(addButton2);
                pnlFrame.Controls.Add(lblAmount);
                pnlFrame.Controls.Add(txtAmount);
               

                flpFoods.Controls.Add(pnlFrame);


            }
        }
    }
}
