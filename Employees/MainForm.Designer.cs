﻿namespace Employees
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(78, 124);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(152, 23);
            button1.TabIndex = 0;
            button1.Text = "Enter employee";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(301, 122);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(157, 25);
            button2.TabIndex = 1;
            button2.Text = "Find employee";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button2_Click;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(551, 124);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(160, 23);
            button3.TabIndex = 2;
            button3.Text = "Delete employee";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button3_Click;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(301, 297);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(157, 23);
            button4.TabIndex = 3;
            button4.Text = "View all employees";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button4_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            Text = "Employee";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}
