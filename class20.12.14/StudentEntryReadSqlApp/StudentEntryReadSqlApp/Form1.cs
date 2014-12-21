using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace StudentEntryReadSqlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();
        private void searchButton_Click(object sender, EventArgs e)
        {
            showListView.Items.Clear();
            students.Clear();
            string connectionString = @"Data Source=LICT\sqlexpress;Database=University;Integrated security=true";
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM tStudents";
            string inputId=idTextBox.Text;
            if(!string.IsNullOrEmpty(inputId))
            {
                query = "SELECT * FROM tStudents WHERE Id='" + inputId + "' ";
                    
            }
            
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Student aStudent = new Student();
                aStudent.id = reader["Id"].ToString();
                aStudent.name = reader["Name"].ToString();
                aStudent.email = reader["Email"].ToString();
                aStudent.address = reader["Address"].ToString();
                aStudent.phone = reader["Phone"].ToString();
                students.Add(aStudent);
            }
            foreach (Student student in students)
            {
                ListViewItem listViewItem=new ListViewItem();
                listViewItem.Text = student.id;
                listViewItem.SubItems.Add(student.name);
                listViewItem.SubItems.Add(student.id);
                listViewItem.SubItems.Add(student.email);
                listViewItem.SubItems.Add(student.address);
                listViewItem.SubItems.Add(student.phone);
                listViewItem.Tag = student;
                showListView.Items.Add(listViewItem);

            }
            connection.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
            students.Clear();
            showListView.Items.Clear();
            //take user id
            string name = nameUpTextBox.Text;
            string email = emailUpTextBox.Text;
            string address = addressUpTextBox.Text;
            string phone = phoneUpTextBox.Text;
            //connect with database
            //a)connection string
            //b)build a connection
            string connectionString = @"Data Source=LICT\sqlexpress;Database=University;Integrated security=true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //insert data in DB
            string query = String.Format("UPDATE tStudents set Name='{0}',Email='{1}',Address='{2}',phone='{3}' WHERE id='{4}'",
                nameUpTextBox.Text, emailUpTextBox.Text, addressUpTextBox.Text, phoneUpTextBox.Text, idUpTextBox.Text); 
            SqlCommand command = new SqlCommand(query, connection);
            int rowAffected = command.ExecuteNonQuery();
            
            connection.Close();
            string query1 = "SELECT * FROM tStudents";
            connection.Open();
            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlDataReader reader = command1.ExecuteReader();
            while (reader.Read())
            {
                Student aStudent = new Student();
                aStudent.id = reader["Id"].ToString();
                aStudent.name = reader["Name"].ToString();
                aStudent.email = reader["Email"].ToString();
                aStudent.address = reader["Address"].ToString();
                aStudent.phone = reader["Phone"].ToString();
                students.Add(aStudent);
            }
            foreach (Student student in students)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = student.id;
                listViewItem.SubItems.Add(student.name);
                listViewItem.SubItems.Add(student.id);
                listViewItem.SubItems.Add(student.email);
                listViewItem.SubItems.Add(student.address);
                listViewItem.SubItems.Add(student.phone);
                listViewItem.Tag = student;
                showListView.Items.Add(listViewItem);

            }
            connection.Close();
            if (rowAffected > 0)
            {
                MessageBox.Show("Successfully added");
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }

        private void showListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem aItem = showListView.SelectedItems[0];
            Student aStudent = (Student) aItem.Tag;
            idUpTextBox.Text = aStudent.id;
            nameUpTextBox.Text = aStudent.name;
            emailUpTextBox.Text = aStudent.email;
            addressUpTextBox.Text = aStudent.address;
            phoneUpTextBox.Text = aStudent.phone;
        }

        private void ID(object sender, EventArgs e)
        {

        }

       
    }
}
