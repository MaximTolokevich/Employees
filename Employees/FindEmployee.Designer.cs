using System.Collections.Generic;
using System.Windows.Forms;

namespace Employees
{
    partial class FindEmployee
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
            FindEmployeeButton = new Button();
            EnterTheNameLabel = new Label();
            EnterTheAgeLabel = new Label();
            EnterTheCarLabel = new Label();
            AddNameTextBox = new TextBox();
            DropDownForCarAdd = new ComboBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // FindEmployeeButton
            // 
            FindEmployeeButton.Location = new System.Drawing.Point(578, 166);
            FindEmployeeButton.Name = "FindEmployeeButton";
            FindEmployeeButton.Size = new System.Drawing.Size(75, 23);
            FindEmployeeButton.TabIndex = 0;
            FindEmployeeButton.Text = "Find";
            FindEmployeeButton.UseVisualStyleBackColor = true;
            FindEmployeeButton.Click += FindEmployeeButton_Click;
            // 
            // EnterTheNameLabel
            // 
            EnterTheNameLabel.AutoSize = true;
            EnterTheNameLabel.Location = new System.Drawing.Point(158, 125);
            EnterTheNameLabel.Name = "EnterTheNameLabel";
            EnterTheNameLabel.Size = new System.Drawing.Size(87, 15);
            EnterTheNameLabel.TabIndex = 6;
            EnterTheNameLabel.Text = "Enter the name";
            // 
            // EnterTheAgeLabel
            // 
            EnterTheAgeLabel.AutoSize = true;
            EnterTheAgeLabel.Location = new System.Drawing.Point(289, 125);
            EnterTheAgeLabel.Name = "EnterTheAgeLabel";
            EnterTheAgeLabel.Size = new System.Drawing.Size(76, 15);
            EnterTheAgeLabel.TabIndex = 7;
            EnterTheAgeLabel.Text = "Enter the age";
            // 
            // EnterTheCarLabel
            // 
            EnterTheCarLabel.AutoSize = true;
            EnterTheCarLabel.Location = new System.Drawing.Point(428, 125);
            EnterTheCarLabel.Name = "EnterTheCarLabel";
            EnterTheCarLabel.Size = new System.Drawing.Size(75, 15);
            EnterTheCarLabel.TabIndex = 8;
            EnterTheCarLabel.Text = "Enter the Car";
            // 
            // AddNameTextBox
            // 
            AddNameTextBox.Location = new System.Drawing.Point(158, 167);
            AddNameTextBox.MaxLength = 50;
            AddNameTextBox.Name = "AddNameTextBox";
            AddNameTextBox.Size = new System.Drawing.Size(100, 23);
            AddNameTextBox.TabIndex = 9;
            AddNameTextBox.TextChanged += AddNameTextBox_TextChanged;
            // 
            // DropDownForCarAdd
            // 
            DropDownForCarAdd.DropDownStyle = ComboBoxStyle.DropDownList;
            DropDownForCarAdd.FormattingEnabled = true;
            DropDownForCarAdd.Items.AddRange(new object[] { "Bmw", "Vw", "Skoda" });
            DropDownForCarAdd.Location = new System.Drawing.Point(428, 167);
            DropDownForCarAdd.Name = "DropDownForCarAdd";
            DropDownForCarAdd.Size = new System.Drawing.Size(121, 23);
            DropDownForCarAdd.TabIndex = 11;
            DropDownForCarAdd.SelectedIndexChanged += DropDownForCarAdd_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "0", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99" });
            comboBox1.Location = new System.Drawing.Point(289, 167);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 23);
            comboBox1.TabIndex = 12;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FindEmployee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(DropDownForCarAdd);
            Controls.Add(AddNameTextBox);
            Controls.Add(EnterTheCarLabel);
            Controls.Add(EnterTheAgeLabel);
            Controls.Add(EnterTheNameLabel);
            Controls.Add(FindEmployeeButton);
            Name = "FindEmployee";
            Text = "FindEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ComboBox1_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void DropDownForCarAdd_TextChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private Button FindEmployeeButton;
        private Label EnterTheNameLabel;
        private Label EnterTheAgeLabel;
        private Label EnterTheCarLabel;
        private TextBox AddNameTextBox;
        private ComboBox DropDownForCarAdd;
        private ComboBox comboBox1;
    }
}