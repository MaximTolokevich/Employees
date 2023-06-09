using Employees.Helper;
using Employees.Repositories;
using System;
using System.Linq;
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
            TextBoxValidateAndChangeInput.TextBoxValidator(name);
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
                var countBefore = EmployeeRepositoryc.GetAllEmployees().Count();
                EmployeeRepositoryc.RemoveByName(textBox1.Text);
                var after = EmployeeRepositoryc.GetAllEmployees().Count();
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
