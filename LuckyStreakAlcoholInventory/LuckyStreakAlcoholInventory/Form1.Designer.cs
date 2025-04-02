namespace LuckyStreakAlcoholInventory
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeadingText = new Label();
            grbxProducts = new GroupBox();
            rdoNonAlcohol = new RadioButton();
            rdoWine = new RadioButton();
            rdoRTD = new RadioButton();
            rdoLiquor = new RadioButton();
            rdoSeltzers = new RadioButton();
            rdoBeerCans = new RadioButton();
            rdoBeerBot = new RadioButton();
            cmbBrands = new ComboBox();
            grbxProducts.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeadingText
            // 
            lblHeadingText.AutoSize = true;
            lblHeadingText.Font = new Font("Elephant", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeadingText.Location = new Point(126, 40);
            lblHeadingText.Name = "lblHeadingText";
            lblHeadingText.Size = new Size(553, 27);
            lblHeadingText.TabIndex = 0;
            lblHeadingText.Text = "Lucky Streak Loung Alcohol Inventory Tracker";
            // 
            // grbxProducts
            // 
            grbxProducts.Controls.Add(rdoNonAlcohol);
            grbxProducts.Controls.Add(rdoWine);
            grbxProducts.Controls.Add(rdoRTD);
            grbxProducts.Controls.Add(rdoLiquor);
            grbxProducts.Controls.Add(rdoSeltzers);
            grbxProducts.Controls.Add(rdoBeerCans);
            grbxProducts.Controls.Add(rdoBeerBot);
            grbxProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbxProducts.Location = new Point(29, 103);
            grbxProducts.Name = "grbxProducts";
            grbxProducts.Size = new Size(255, 151);
            grbxProducts.TabIndex = 1;
            grbxProducts.TabStop = false;
            grbxProducts.Text = "Products";
            // 
            // rdoNonAlcohol
            // 
            rdoNonAlcohol.AutoSize = true;
            rdoNonAlcohol.Location = new Point(137, 87);
            rdoNonAlcohol.Name = "rdoNonAlcohol";
            rdoNonAlcohol.Size = new Size(103, 19);
            rdoNonAlcohol.TabIndex = 6;
            rdoNonAlcohol.TabStop = true;
            rdoNonAlcohol.Text = "Non-Alcoholic";
            rdoNonAlcohol.UseVisualStyleBackColor = true;
            // 
            // rdoWine
            // 
            rdoWine.AutoSize = true;
            rdoWine.Location = new Point(137, 62);
            rdoWine.Name = "rdoWine";
            rdoWine.Size = new Size(54, 19);
            rdoWine.TabIndex = 5;
            rdoWine.TabStop = true;
            rdoWine.Text = "Wine";
            rdoWine.UseVisualStyleBackColor = true;
            // 
            // rdoRTD
            // 
            rdoRTD.AutoSize = true;
            rdoRTD.Location = new Point(137, 37);
            rdoRTD.Name = "rdoRTD";
            rdoRTD.Size = new Size(109, 19);
            rdoRTD.TabIndex = 4;
            rdoRTD.TabStop = true;
            rdoRTD.Text = "Ready To Drink";
            rdoRTD.UseVisualStyleBackColor = true;
            // 
            // rdoLiquor
            // 
            rdoLiquor.AutoSize = true;
            rdoLiquor.Location = new Point(6, 113);
            rdoLiquor.Name = "rdoLiquor";
            rdoLiquor.Size = new Size(60, 19);
            rdoLiquor.TabIndex = 3;
            rdoLiquor.TabStop = true;
            rdoLiquor.Text = "Liquor";
            rdoLiquor.UseVisualStyleBackColor = true;
            // 
            // rdoSeltzers
            // 
            rdoSeltzers.AutoSize = true;
            rdoSeltzers.Location = new Point(6, 87);
            rdoSeltzers.Name = "rdoSeltzers";
            rdoSeltzers.Size = new Size(70, 19);
            rdoSeltzers.TabIndex = 2;
            rdoSeltzers.TabStop = true;
            rdoSeltzers.Text = "Seltzers";
            rdoSeltzers.UseVisualStyleBackColor = true;
            // 
            // rdoBeerCans
            // 
            rdoBeerCans.AutoSize = true;
            rdoBeerCans.Location = new Point(6, 62);
            rdoBeerCans.Name = "rdoBeerCans";
            rdoBeerCans.Size = new Size(88, 19);
            rdoBeerCans.TabIndex = 1;
            rdoBeerCans.TabStop = true;
            rdoBeerCans.Text = "Beer - Cans";
            rdoBeerCans.UseVisualStyleBackColor = true;
            // 
            // rdoBeerBot
            // 
            rdoBeerBot.AutoSize = true;
            rdoBeerBot.Location = new Point(6, 37);
            rdoBeerBot.Name = "rdoBeerBot";
            rdoBeerBot.Size = new Size(103, 19);
            rdoBeerBot.TabIndex = 0;
            rdoBeerBot.TabStop = true;
            rdoBeerBot.Text = "Beer - Bottles";
            rdoBeerBot.UseVisualStyleBackColor = true;
            rdoBeerBot.CheckedChanged += rdoBeerBot_CheckedChanged;
            // 
            // cmbBrands
            // 
            cmbBrands.FormattingEnabled = true;
            cmbBrands.Location = new Point(337, 103);
            cmbBrands.Name = "cmbBrands";
            cmbBrands.Size = new Size(121, 23);
            cmbBrands.TabIndex = 4;
            cmbBrands.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbBrands);
            Controls.Add(grbxProducts);
            Controls.Add(lblHeadingText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grbxProducts.ResumeLayout(false);
            grbxProducts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeadingText;
        private GroupBox grbxProducts;
        private RadioButton rdoNonAlcohol;
        private RadioButton rdoWine;
        private RadioButton rdoRTD;
        private RadioButton rdoLiquor;
        private RadioButton rdoSeltzers;
        private RadioButton rdoBeerCans;
        private RadioButton rdoBeerBot;
        private ComboBox cmbBrands;
    }
}
