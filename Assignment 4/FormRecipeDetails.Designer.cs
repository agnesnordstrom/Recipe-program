namespace Assignment_4
{
    partial class FormRecipeDetails
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
            lstIngredients = new ListBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblNumberOfIngredientsLabel = new Label();
            lblNumberOfIngredients = new Label();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnCancel = new Button();
            btnOk = new Button();
            txtIngredient = new TextBox();
            lblNameAmount = new Label();
            SuspendLayout();
            // 
            // lstIngredients
            // 
            lstIngredients.FormattingEnabled = true;
            lstIngredients.ItemHeight = 25;
            lstIngredients.Location = new Point(40, 158);
            lstIngredients.Name = "lstIngredients";
            lstIngredients.Size = new Size(348, 229);
            lstIngredients.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(40, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(158, 118);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(276, 118);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // lblNumberOfIngredientsLabel
            // 
            lblNumberOfIngredientsLabel.AutoSize = true;
            lblNumberOfIngredientsLabel.Location = new Point(40, 405);
            lblNumberOfIngredientsLabel.Name = "lblNumberOfIngredientsLabel";
            lblNumberOfIngredientsLabel.Size = new Size(192, 25);
            lblNumberOfIngredientsLabel.TabIndex = 4;
            lblNumberOfIngredientsLabel.Text = "Number of ingredients";
            // 
            // lblNumberOfIngredients
            // 
            lblNumberOfIngredients.AutoSize = true;
            lblNumberOfIngredients.BorderStyle = BorderStyle.FixedSingle;
            lblNumberOfIngredients.Location = new Point(308, 406);
            lblNumberOfIngredients.Name = "lblNumberOfIngredients";
            lblNumberOfIngredients.Size = new Size(24, 27);
            lblNumberOfIngredients.TabIndex = 5;
            lblNumberOfIngredients.Text = "0";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(414, 81);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(272, 25);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description/Cooking instructions";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(414, 118);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(347, 269);
            txtDescription.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(649, 446);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(531, 446);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(112, 34);
            btnOk.TabIndex = 9;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtIngredient
            // 
            txtIngredient.Location = new Point(40, 75);
            txtIngredient.Name = "txtIngredient";
            txtIngredient.Size = new Size(348, 31);
            txtIngredient.TabIndex = 11;
            // 
            // lblNameAmount
            // 
            lblNameAmount.AutoSize = true;
            lblNameAmount.Location = new Point(40, 35);
            lblNameAmount.Name = "lblNameAmount";
            lblNameAmount.Size = new Size(161, 25);
            lblNameAmount.TabIndex = 10;
            lblNameAmount.Text = "Name and amount";
            // 
            // FormRecipeDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 504);
            Controls.Add(txtIngredient);
            Controls.Add(lblNameAmount);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(lblNumberOfIngredients);
            Controls.Add(lblNumberOfIngredientsLabel);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(lstIngredients);
            Name = "FormRecipeDetails";
            Text = "FormRecipeDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstIngredients;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblNumberOfIngredientsLabel;
        private Label lblNumberOfIngredients;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnCancel;
        private Button btnOk;
        private TextBox txtIngredient;
        private Label lblNameAmount;
    }
}