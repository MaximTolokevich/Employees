using Employees.Context;
using Employees.Models;
using Employees.Repositories;
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
    public partial class ViewEmployees : Form
    {

        public ViewEmployees()
        {
            InitializeComponent();
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {

            employeeBindingSource.DataSource = EmployeeRepositorycs.GetAllEmployees().ToList();

        }
    }
}
