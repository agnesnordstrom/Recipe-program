namespace Assignment_4
{
    partial class MainForm
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
            btnAddImage = new Button();
            btnChange = new Button();
            btnDelete = new Button();
            BtnClearInput = new Button();
            btnAddRecipe = new Button();
            txtRecipeName = new TextBox();
            lblRecipeName = new Label();
            lblCategory = new Label();
            btnAddIngredients = new Button();
            groupBox1 = new GroupBox();
            cmbCategory = new ComboBox();
            pctImage = new PictureBox();
            lstRecipes = new ListBox();
            lblRecipeInstructions = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctImage).BeginInit();
            SuspendLayout();
            // 
            // btnAddImage
            // 
            btnAddImage.Location = new Point(606, 290);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(303, 38);
            btnAddImage.TabIndex = 7;
            btnAddImage.Text = "Add image";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(42, 685);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(140, 57);
            btnChange.TabIndex = 9;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(213, 685);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 57);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // BtnClearInput
            // 
            BtnClearInput.Location = new Point(384, 685);
            BtnClearInput.Name = "BtnClearInput";
            BtnClearInput.Size = new Size(140, 57);
            BtnClearInput.TabIndex = 10;
            BtnClearInput.Text = "Clear input";
            BtnClearInput.UseVisualStyleBackColor = true;
            BtnClearInput.Click += BtnClearInput_Click;
            // 
            // btnAddRecipe
            // 
            btnAddRecipe.Location = new Point(42, 269);
            btnAddRecipe.Name = "btnAddRecipe";
            btnAddRecipe.Size = new Size(459, 59);
            btnAddRecipe.TabIndex = 3;
            btnAddRecipe.Text = "Add recipe";
            btnAddRecipe.UseVisualStyleBackColor = true;
            btnAddRecipe.Click += btnAddRecipe_Click;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(171, 51);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(311, 31);
            txtRecipeName.TabIndex = 1;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(22, 57);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(112, 25);
            lblRecipeName.TabIndex = 4;
            lblRecipeName.Text = "Recipe name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(22, 96);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 25);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "Category";
            // 
            // btnAddIngredients
            // 
            btnAddIngredients.Location = new Point(6, 148);
            btnAddIngredients.Name = "btnAddIngredients";
            btnAddIngredients.Size = new Size(476, 59);
            btnAddIngredients.TabIndex = 6;
            btnAddIngredients.Text = "Add ingredients and instructions";
            btnAddIngredients.UseVisualStyleBackColor = true;
            btnAddIngredients.Click += btnAddIngredients_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddIngredients);
            groupBox1.Controls.Add(lblCategory);
            groupBox1.Controls.Add(lblRecipeName);
            groupBox1.Controls.Add(txtRecipeName);
            groupBox1.Controls.Add(cmbCategory);
            groupBox1.Location = new Point(42, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 218);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Recipe details";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(253, 92);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(229, 33);
            cmbCategory.TabIndex = 2;
            // 
            // pctImage
            // 
            pctImage.Location = new Point(584, 40);
            pctImage.Name = "pctImage";
            pctImage.Size = new Size(354, 244);
            pctImage.TabIndex = 6;
            pctImage.TabStop = false;
            // 
            // lstRecipes
            // 
            lstRecipes.CausesValidation = false;
            lstRecipes.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstRecipes.FormattingEnabled = true;
            lstRecipes.ItemHeight = 20;
            lstRecipes.Location = new Point(42, 341);
            lstRecipes.Name = "lstRecipes";
            lstRecipes.Size = new Size(482, 324);
            lstRecipes.TabIndex = 0;
            lstRecipes.SelectedIndexChanged += lstRecipes_SelectedIndexChanged;
            // 
            // lblRecipeInstructions
            // 
            lblRecipeInstructions.Location = new Point(540, 343);
            lblRecipeInstructions.Name = "lblRecipeInstructions";
            lblRecipeInstructions.Size = new Size(541, 399);
            lblRecipeInstructions.TabIndex = 13;
            lblRecipeInstructions.Text = " ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 763);
            Controls.Add(lblRecipeInstructions);
            Controls.Add(btnDelete);
            Controls.Add(BtnClearInput);
            Controls.Add(btnChange);
            Controls.Add(btnAddImage);
            Controls.Add(pctImage);
            Controls.Add(groupBox1);
            Controls.Add(lstRecipes);
            Controls.Add(btnAddRecipe);
            Name = "MainForm";
            Text = "APU Cookbook by Agnes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pctImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddImage;
        private Button btnChange;
        private Button btnDelete;
        private Button BtnClearInput;
        private Button btnAddRecipe;
        private TextBox txtRecipeName;
        private Label lblRecipeName;
        private Label lblCategory;
        private Button btnAddIngredients;
        private GroupBox groupBox1;
        private ComboBox cmbCategory;
        private PictureBox pctImage;
        private ListBox lstRecipes;
        private Label lblRecipeInstructions;
    }
}
