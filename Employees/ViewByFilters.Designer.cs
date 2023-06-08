using System.Windows.Forms;

namespace Employees
{
    partial class ViewByFilters
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            employeeRepositorycsBindingSource = new System.Windows.Forms.BindingSource(components);
            employeeRepositorycsBindingSource1 = new System.Windows.Forms.BindingSource(components);
            employeeContextBindingSource = new System.Windows.Forms.BindingSource(components);
            employeeBindingSource = new System.Windows.Forms.BindingSource(components);
            nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            carDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeRepositorycsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeRepositorycsBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeContextBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { nameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, carDataGridViewTextBoxColumn });
            dataGridView1.DataSource = employeeBindingSource;
            dataGridView1.Location = new System.Drawing.Point(0, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(444, 308);
            dataGridView1.TabIndex = 0;
            // 
            // employeeRepositorycsBindingSource
            // 
            employeeRepositorycsBindingSource.DataSource = typeof(Repositories.EmployeeRepositorycs);
            // 
            // employeeRepositorycsBindingSource1
            // 
            employeeRepositorycsBindingSource1.DataSource = typeof(Repositories.EmployeeRepositorycs);
            // 
            // employeeContextBindingSource
            // 
            employeeContextBindingSource.DataSource = typeof(Context.EmployeeContext);
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Models.Employee);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carDataGridViewTextBoxColumn
            // 
            carDataGridViewTextBoxColumn.DataPropertyName = "Car";
            carDataGridViewTextBoxColumn.HeaderText = "Car";
            carDataGridViewTextBoxColumn.Name = "carDataGridViewTextBoxColumn";
            carDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewByFilters
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "ViewByFilters";
            Text = "ViewByFilters";
            Load += ViewEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeRepositorycsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeRepositorycsBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeContextBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.BindingSource employeeRepositorycsBindingSource;
        private System.Windows.Forms.BindingSource employeeRepositorycsBindingSource1;
        private System.Windows.Forms.BindingSource employeeContextBindingSource;
    }
}