using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmplyeeInfoApp
{
    public partial class EmployeeInformation : Form
    {
        public EmployeeInformation()
        {
            InitializeComponent();
        }

        Employee employee1=new Employee();

        private void showButton_Click(object sender, EventArgs e)
        {
            employee1.id = idTextBox.Text;
            employee1.name = nameTextBox.Text;
            employee1.salary = salaryTextBox.Text;
            MessageBox.Show("Id:"+employee1.id+"\n"+"Name:"+employee1.name+"\n"+"Salary:"+employee1.salary);
            idTextBox.Clear();
            nameTextBox.Clear();
            salaryTextBox.Clear();
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = employee1.id;
            nameTextBox.Text = employee1.name;
            salaryTextBox.Text = employee1.salary;
        }
    }
}
