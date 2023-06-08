using Employees.Context;
using Employees.Helper;
using Employees.Models;
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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmploeeButton_Click(object sender, EventArgs e)
        {
            
            Car car;
            while (!Enum.TryParse(DropDownForCarAdd.Text, out car))
            {
                MessageBox.Show($"car should be entered");
                return;
            }

            EmployeeRepositorycs.AddEmployee(AddNameTextBox.Text, (int)DropDownForAgeAdd.Value, car);
            MessageBox.Show("Succesfully added");
        }

        private void DropDownForAgeAdd_ValueChanged(object sender, EventArgs e)
        {
    
        }

        private void DropDownForCarAdd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddNameTextBox_TextChanged(object sender, EventArgs e)
       {
            var box = sender as TextBox;
            TextBoxValidateAndChangeInput.TextBoxValidator(box);
        }
    }
}
