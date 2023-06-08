using Employees.FindResult;
using Employees.Helper;
using Employees.Models;
using Employees.Repositories;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Employees
{
    public partial class FindEmployee : Form
    {
        public FindEmployee()
        {
            InitializeComponent();
        }

        private void AddNameTextBox_TextChanged(object sender, EventArgs e)
        {
            var box = sender as TextBox;
            TextBoxValidateAndChangeInput.TextBoxValidator(box);
        }

        private void FindEmployeeButton_Click(object sender, EventArgs e)
        {
            var result = EmployeeRepositorycs.GetAllEmployees();
            if (!string.IsNullOrEmpty(AddNameTextBox.Text))
            {
                result = result.Where(x => x.Name.Equals(AddNameTextBox.Text));
            }
            if (!DropDownForCarAdd.Text.Equals(Car.None.ToString()) && !string.IsNullOrEmpty(DropDownForCarAdd.Text))
            {
                result = result.Where(x => x.Car.ToString().Equals(DropDownForCarAdd.Text));
            }
            var selectedAge = comboBox1.Text;
            if (!string.IsNullOrEmpty(selectedAge))
            {
                result = result.Where(x => x.Age.Equals(selectedAge));
            }
            FindResultSource.findResult = result.ToList();

            ViewByFilters viewByFilters = new ViewByFilters();
            viewByFilters.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DropDownForCarAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
