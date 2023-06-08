namespace Employees
{
    partial class DeleteEmployee
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
            DeleteEmployeeButton = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // EnterTheNameLabel
            // 
            EnterTheNameLabel.AutoSize = true;
            EnterTheNameLabel.Location = new System.Drawing.Point(100, 120);
            EnterTheNameLabel.Name = "EnterTheNameLabel";
            EnterTheNameLabel.Size = new System.Drawing.Size(87, 15);
            EnterTheNameLabel.TabIndex = 7;
            EnterTheNameLabel.Text = "Enter the name";
            // 
            // DeleteEmployeeButton
            // 
            DeleteEmployeeButton.Location = new System.Drawing.Point(245, 153);
            DeleteEmployeeButton.Name = "DeleteEmployeeButton";
            DeleteEmployeeButton.Size = new System.Drawing.Size(75, 23);
            DeleteEmployeeButton.TabIndex = 8;
            DeleteEmployeeButton.Text = "Delete";
            DeleteEmployeeButton.UseVisualStyleBackColor = true;
            DeleteEmployeeButton.Click += DeleteEmployeeButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(100, 154);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(100, 23);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // DeleteEmployee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(DeleteEmployeeButton);
            Controls.Add(EnterTheNameLabel);
            Name = "DeleteEmployee";
            Text = "DeleteEmployee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label EnterTheNameLabel;
        private System.Windows.Forms.Button DeleteEmployeeButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}