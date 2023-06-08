using Employees.Repositories;
using Employees.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class DeleteEmployee : Form
    {

        public DeleteEmployee()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            var name = sender as TextBox;
            while (!NameValidator.IsValidName(name.Text) && !string.IsNullOrEmpty(name.Text))
            {

                MessageBox.Show("Every symbol of name should be a letter");
                name.Text = name.Text.Remove(name.SelectionStart - 1, 1);
                name.SelectionStart = name.Text.Length;
                return;
            }
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Name should be entered");
                return;
            }
            else
            {
                var countBefore = EmployeeRepositorycs.GetAllEmployees().Count();
                EmployeeRepositorycs.RemoveByName(textBox1.Text);
                var after = EmployeeRepositorycs.GetAllEmployees().Count();
                if (countBefore != after)
                {
                    MessageBox.Show("deleted successfully");
                }
                else
                {
                    MessageBox.Show("records with this name were not found");
                }
            }
        }
    }
}
