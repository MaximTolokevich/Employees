namespace Employees
{
    partial class AddEmployee
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
            EnterTheNameLabel = new System.Windows.Forms.Label();
            EnterTheAgeLabel = new System.Windows.Forms.Label();
            EnterTheCarLabel = new System.Windows.Forms.Label();
            DropDownForAgeAdd = new System.Windows.Forms.NumericUpDown();
            DropDownForCarAdd = new System.Windows.Forms.ComboBox();
            AddEmploeeButton = new System.Windows.Forms.Button();
            AddNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)DropDownForAgeAdd).BeginInit();
            SuspendLayout();
            // 
            // EnterTheNameLabel
            // 
            EnterTheNameLabel.AutoSize = true;
            EnterTheNameLabel.Location = new System.Drawing.Point(75, 109);
            EnterTheNameLabel.Name = "EnterTheNameLabel";
            EnterTheNameLabel.Size = new System.Drawing.Size(87, 15);
            EnterTheNameLabel.TabIndex = 1;
            EnterTheNameLabel.Text = "Enter the name";
            // 
            // EnterTheAgeLabel
            // 
            EnterTheAgeLabel.AutoSize = true;
            EnterTheAgeLabel.Location = new System.Drawing.Point(262, 109);
            EnterTheAgeLabel.Name = "EnterTheAgeLabel";
            EnterTheAgeLabel.Size = new System.Drawing.Size(76, 15);
            EnterTheAgeLabel.TabIndex = 2;
            EnterTheAgeLabel.Text = "Enter the age";
            // 
            // EnterTheCarLabel
            // 
            EnterTheCarLabel.AutoSize = true;
            EnterTheCarLabel.Location = new System.Drawing.Point(456, 109);
            EnterTheCarLabel.Name = "EnterTheCarLabel";
            EnterTheCarLabel.Size = new System.Drawing.Size(75, 15);
            EnterTheCarLabel.TabIndex = 3;
            EnterTheCarLabel.Text = "Enter the Car";
            // 
            // DropDownForAgeAdd
            // 
            DropDownForAgeAdd.Location = new System.Drawing.Point(265, 153);
            DropDownForAgeAdd.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            DropDownForAgeAdd.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            DropDownForAgeAdd.Name = "DropDownForAgeAdd";
            DropDownForAgeAdd.Size = new System.Drawing.Size(120, 23);
            DropDownForAgeAdd.TabIndex = 5;
            DropDownForAgeAdd.Value = new decimal(new int[] { 18, 0, 0, 0 });
            DropDownForAgeAdd.ValueChanged += DropDownForAgeAdd_ValueChanged;
            // 
            // DropDownForCarAdd
            // 
            DropDownForCarAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            DropDownForCarAdd.FormattingEnabled = true;
            DropDownForCarAdd.Items.AddRange(new object[] { "Bmw", "Vw", "Skoda" });
            DropDownForCarAdd.Location = new System.Drawing.Point(457, 152);
            DropDownForCarAdd.Name = "DropDownForCarAdd";
            DropDownForCarAdd.Size = new System.Drawing.Size(121, 23);
            DropDownForCarAdd.TabIndex = 6;
            DropDownForCarAdd.SelectedIndexChanged += DropDownForCarAdd_SelectedIndexChanged;
            // 
            // AddEmploeeButton
            // 
            AddEmploeeButton.Location = new System.Drawing.Point(655, 153);
            AddEmploeeButton.Name = "AddEmploeeButton";
            AddEmploeeButton.Size = new System.Drawing.Size(75, 23);
            AddEmploeeButton.TabIndex = 7;
            AddEmploeeButton.Text = "Add";
            AddEmploeeButton.UseVisualStyleBackColor = true;
            AddEmploeeButton.Click += AddEmploeeButton_Click;
            // 
            // AddNameTextBox
            // 
            AddNameTextBox.Location = new System.Drawing.Point(75, 152);
            AddNameTextBox.MaxLength = 50;
            AddNameTextBox.Name = "AddNameTextBox";
            AddNameTextBox.Size = new System.Drawing.Size(100, 23);
            AddNameTextBox.TabIndex = 8;
            AddNameTextBox.TextChanged += AddNameTextBox_TextChanged;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(AddNameTextBox);
            Controls.Add(AddEmploeeButton);
            Controls.Add(DropDownForCarAdd);
            Controls.Add(DropDownForAgeAdd);
            Controls.Add(EnterTheCarLabel);
            Controls.Add(EnterTheAgeLabel);
            Controls.Add(EnterTheNameLabel);
            Name = "AddEmployee";
            Text = "AddEmployee";
            ((System.ComponentModel.ISupportInitialize)DropDownForAgeAdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label EnterTheNameLabel;
        private System.Windows.Forms.Label EnterTheAgeLabel;
        private System.Windows.Forms.Label EnterTheCarLabel;
        private System.Windows.Forms.NumericUpDown DropDownForAgeAdd;
        private System.Windows.Forms.ComboBox DropDownForCarAdd;
        private System.Windows.Forms.Button AddEmploeeButton;
        private System.Windows.Forms.TextBox AddNameTextBox;
    }
}