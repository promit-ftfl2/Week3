using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentEntrySqlApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
           //take user id
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            string phone = phoneTextBox.Text;
            //connect with database
            //a)connection string
            //b)build a connection
            string connectionString = @"Data Source=LICT\sqlexpress;Database=University;Integrated security=true";
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            connection.Open();
            //insert data in DB
            string query = "UPDATE INTO tStudents VALUES('" + name + "','" + email + "','" + address + "','" + phone + "')";
            System.Data.SqlClient.SqlCommand command = new System.Data.SqlClient.SqlCommand(query, connection);
            int rowAffected = command.ExecuteNonQuery();
            if(rowAffected>0)
            {
                MessageBox.Show("Successfully added");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
