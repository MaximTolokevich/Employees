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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new();
            addEmployee.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FindEmployee findEmployee = new();
            findEmployee.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DeleteEmployee deleteEmployee = new();
            deleteEmployee.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ViewEmployees viewEmployees = new();
            viewEmployees.Show();
        }
    }
}
