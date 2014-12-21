using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace DailyExpenseApp
{
    public partial class DailyExpense : Form
    {
        public DailyExpense()
        {
            InitializeComponent();
        }

        private string fileLocation = @"E:\DailyExpense.csv";
        private void saveButton_Click(object sender, EventArgs e)
        {
            
            FileStream aStream=new FileStream(fileLocation,FileMode.Append);
            CsvFileWriter aWriter=new CsvFileWriter(aStream);
            List<string> infoList=new List<string>();
            infoList.Add(amountTextBox.Text);
            infoList.Add(categorycomboBox1.Text);
            infoList.Add(particularTextBox.Text);
            aWriter.WriteRow(infoList);
            aStream.Close();
            MessageBox.Show("A new entry added");
            amountTextBox.Clear();
            particularTextBox.Clear();
        }

        private void summaryShowButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileLocation))
            {
                long totalExpense = 0;
                long maxexpense = 0;
                FileStream aStream = new FileStream(fileLocation, FileMode.Open);
                CsvFileReader aReader = new CsvFileReader(aStream);
                List<string> infoList = new List<string>();
                while (aReader.ReadRow(infoList))
                {
                    totalExpense += long.Parse(infoList[0]);
                    if (maxexpense < long.Parse(infoList[0]))
                    {
                        maxexpense = long.Parse(infoList[0]);
                    }

                }
                aStream.Close();
                totalExpenseTextBox.Text = totalExpense.ToString();
                maxExpenseTextBox.Text = maxexpense.ToString();
            }
            else
            {
                MessageBox.Show("No entry");
            }
        }

        private void categoryShowButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileLocation))
            {
                showListBox.Items.Clear();
                long categorytotal = 0;
                FileStream aStream = new FileStream(fileLocation, FileMode.Open);
                CsvFileReader aReader = new CsvFileReader(aStream);
                List<string> infoList = new List<string>();

                if (categoryComboBox2.Text == "House Rent")
                {
                    while (aReader.ReadRow(infoList))
                    {
                        if (infoList[1] == categoryComboBox2.Text)
                        {
                            showListBox.Items.Add(infoList[0]+"  "+infoList[2]);
                            categorytotal += long.Parse(infoList[0]);
                        }
                    }
                }
                if (categoryComboBox2.Text == "Utility Bill")
                {
                    while (aReader.ReadRow(infoList))
                    {
                        if (infoList[1] == categoryComboBox2.Text)
                        {
                            showListBox.Items.Add(infoList[0] + "  " + infoList[2]);
                            categorytotal += long.Parse(infoList[0]);
                        }
                    }
                }
                if (categoryComboBox2.Text == "Conveyance")
                {
                    while (aReader.ReadRow(infoList))
                    {
                        if (infoList[1] == categoryComboBox2.Text)
                        {
                            showListBox.Items.Add(infoList[0] + "  " + infoList[2]);
                            categorytotal += long.Parse(infoList[0]);
                        }
                    }
                }
                if (categoryComboBox2.Text == "Grocery")
                {
                    while (aReader.ReadRow(infoList))
                    {
                        if (infoList[1] == categoryComboBox2.Text)
                        {
                            showListBox.Items.Add(infoList[0] + "  " + infoList[2]);
                            categorytotal += long.Parse(infoList[0]);
                        }
                    }
                }
                if (categoryComboBox2.Text == "Misc")
                {
                    while (aReader.ReadRow(infoList))
                    {
                        if (infoList[1] == categoryComboBox2.Text)
                        {
                            showListBox.Items.Add(infoList[0] + "  " + infoList[2]);
                            categorytotal += long.Parse(infoList[0]);
                        }
                    }
                }

                totalCatTextBox.Text = categorytotal.ToString();
                aStream.Close();

            }
            else
                MessageBox.Show("No entry exists");
        }

    }
}
