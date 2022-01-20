﻿
namespace CaloryBoost
{
    partial class Meal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meal));
            this.flpFoods = new System.Windows.Forms.FlowLayoutPanel();
            this.lvMealDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpMealName = new ReaLTaiizor.Controls.GroupBox();
            this.txtUpdateAmount = new RJCodeAdvance.RJControls.RJTextBox();
            this.btnUpdate = new RJCodeAdvance.RJControls.RJButton();
            this.btnDelete = new RJCodeAdvance.RJControls.RJButton();
            this.lblCalory = new ReaLTaiizor.Controls.HeaderLabel();
            this.headerLabel1 = new ReaLTaiizor.Controls.HeaderLabel();
            this.lblTotalCalory = new ReaLTaiizor.Controls.HeaderLabel();
            this.txtSearch = new RJCodeAdvance.RJControls.RJTextBox();
            this.headerLabel2 = new ReaLTaiizor.Controls.HeaderLabel();
            this.btnClose = new RJCodeAdvance.RJControls.RJButton();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.grpMealName.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpFoods
            // 
            this.flpFoods.AutoScroll = true;
            this.flpFoods.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flpFoods.Location = new System.Drawing.Point(12, 303);
            this.flpFoods.Name = "flpFoods";
            this.flpFoods.Size = new System.Drawing.Size(338, 295);
            this.flpFoods.TabIndex = 1;
            // 
            // lvMealDetails
            // 
            this.lvMealDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMealDetails.GridLines = true;
            this.lvMealDetails.HideSelection = false;
            this.lvMealDetails.Location = new System.Drawing.Point(11, 31);
            this.lvMealDetails.Name = "lvMealDetails";
            this.lvMealDetails.Size = new System.Drawing.Size(336, 121);
            this.lvMealDetails.TabIndex = 0;
            this.lvMealDetails.UseCompatibleStateImageBehavior = false;
            this.lvMealDetails.View = System.Windows.Forms.View.Details;
            this.lvMealDetails.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvMealDetails_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FoodName";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Calory";
            this.columnHeader3.Width = 132;
            // 
            // grpMealName
            // 
            this.grpMealName.BackColor = System.Drawing.Color.Transparent;
            this.grpMealName.BackGColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.grpMealName.BaseColor = System.Drawing.Color.Transparent;
            this.grpMealName.BorderColorG = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(161)))));
            this.grpMealName.BorderColorH = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(180)))), ((int)(((byte)(186)))));
            this.grpMealName.Controls.Add(this.txtUpdateAmount);
            this.grpMealName.Controls.Add(this.btnUpdate);
            this.grpMealName.Controls.Add(this.btnDelete);
            this.grpMealName.Controls.Add(this.lblCalory);
            this.grpMealName.Controls.Add(this.headerLabel1);
            this.grpMealName.Controls.Add(this.lblTotalCalory);
            this.grpMealName.Controls.Add(this.lvMealDetails);
            this.grpMealName.Font = new System.Drawing.Font("Tahoma", 9F);
            this.grpMealName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.grpMealName.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.grpMealName.Location = new System.Drawing.Point(1, 32);
            this.grpMealName.MinimumSize = new System.Drawing.Size(136, 50);
            this.grpMealName.Name = "grpMealName";
            this.grpMealName.Padding = new System.Windows.Forms.Padding(5, 28, 5, 5);
            this.grpMealName.Size = new System.Drawing.Size(358, 231);
            this.grpMealName.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.grpMealName.TabIndex = 2;
            this.grpMealName.Text = "groupBox1";
            // 
            // txtUpdateAmount
            // 
            this.txtUpdateAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtUpdateAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtUpdateAmount.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtUpdateAmount.BorderRadius = 15;
            this.txtUpdateAmount.BorderSize = 2;
            this.txtUpdateAmount.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUpdateAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUpdateAmount.Location = new System.Drawing.Point(153, 193);
            this.txtUpdateAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtUpdateAmount.Multiline = false;
            this.txtUpdateAmount.Name = "txtUpdateAmount";
            this.txtUpdateAmount.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUpdateAmount.PasswordChar = false;
            this.txtUpdateAmount.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUpdateAmount.PlaceholderText = "";
            this.txtUpdateAmount.Size = new System.Drawing.Size(51, 31);
            this.txtUpdateAmount.TabIndex = 3;
            this.txtUpdateAmount.Texts = "";
            this.txtUpdateAmount.UnderlinedStyle = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(273, 198);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 26);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(105)))), ((int)(((byte)(30)))));
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 15;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(273, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 26);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblCalory
            // 
            this.lblCalory.AutoSize = true;
            this.lblCalory.BackColor = System.Drawing.Color.Transparent;
            this.lblCalory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblCalory.Location = new System.Drawing.Point(187, 155);
            this.lblCalory.Name = "lblCalory";
            this.lblCalory.Size = new System.Drawing.Size(18, 18);
            this.lblCalory.TabIndex = 1;
            this.lblCalory.Text = "0";
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.headerLabel1.Location = new System.Drawing.Point(8, 201);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(134, 18);
            this.headerLabel1.TabIndex = 1;
            this.headerLabel1.Text = "Update Amount : ";
            // 
            // lblTotalCalory
            // 
            this.lblTotalCalory.AutoSize = true;
            this.lblTotalCalory.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCalory.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalCalory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotalCalory.Location = new System.Drawing.Point(11, 155);
            this.lblTotalCalory.Name = "lblTotalCalory";
            this.lblTotalCalory.Size = new System.Drawing.Size(108, 18);
            this.lblTotalCalory.TabIndex = 1;
            this.lblTotalCalory.Text = "Total Calory :";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtSearch.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.Location = new System.Drawing.Point(105, 265);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.Size = new System.Drawing.Size(245, 31);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = false;
            this.txtSearch._TextChanged += new System.EventHandler(this.txtSearch__TextChanged);
            // 
            // headerLabel2
            // 
            this.headerLabel2.AutoSize = true;
            this.headerLabel2.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerLabel2.ForeColor = System.Drawing.Color.Black;
            this.headerLabel2.Location = new System.Drawing.Point(31, 271);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Size = new System.Drawing.Size(69, 18);
            this.headerLabel2.TabIndex = 1;
            this.headerLabel2.Text = "Search :";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 15;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(315, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bigLabel1.Location = new System.Drawing.Point(115, 4);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(135, 25);
            this.bigLabel1.TabIndex = 5;
            this.bigLabel1.Text = "CALORYBOOST";
            this.bigLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 610);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grpMealName);
            this.Controls.Add(this.flpFoods);
            this.Controls.Add(this.headerLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Meal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meal";
            this.Load += new System.EventHandler(this.Meal_Load);
            this.grpMealName.ResumeLayout(false);
            this.grpMealName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpFoods;
        private System.Windows.Forms.ListView lvMealDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private ReaLTaiizor.Controls.GroupBox grpMealName;
        private ReaLTaiizor.Controls.HeaderLabel lblCalory;
        private ReaLTaiizor.Controls.HeaderLabel lblTotalCalory;
        private RJCodeAdvance.RJControls.RJButton btnUpdate;
        private RJCodeAdvance.RJControls.RJButton btnDelete;
        private RJCodeAdvance.RJControls.RJTextBox txtSearch;
        private RJCodeAdvance.RJControls.RJTextBox txtUpdateAmount;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel1;
        private ReaLTaiizor.Controls.HeaderLabel headerLabel2;
        private RJCodeAdvance.RJControls.RJButton btnClose;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}