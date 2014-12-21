using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Student aStudent=new Student();

        public void ClearTextBox()
        {
            regnoTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            aStudent.regno = regnoTextBox.Text;
            aStudent.firstname = firstNameTextBox.Text;
            aStudent.lastname = lastNameTextBox.Text;
            string fullname = aStudent.GetFullName();
            MessageBox.Show(fullname + " your regno is:" + aStudent.regno);
            ClearTextBox();
        }

        private void retriveButton_Click(object sender, EventArgs e)
        {
            regnoTextBox.Text = aStudent.regno;
            firstNameTextBox.Text = aStudent.firstname;
            lastNameTextBox.Text = aStudent.lastname;
        }
    }
}
