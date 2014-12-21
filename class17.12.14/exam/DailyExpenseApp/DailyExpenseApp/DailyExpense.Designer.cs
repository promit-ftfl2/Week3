namespace DailyExpenseApp
{
    partial class DailyExpense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.particularTextBox = new System.Windows.Forms.TextBox();
            this.totalExpenseTextBox = new System.Windows.Forms.TextBox();
            this.maxExpenseTextBox = new System.Windows.Forms.TextBox();
            this.totalCatTextBox = new System.Windows.Forms.TextBox();
            this.showListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.summaryShowButton = new System.Windows.Forms.Button();
            this.categoryShowButton = new System.Windows.Forms.Button();
            this.categorycomboBox1 = new System.Windows.Forms.ComboBox();
            this.categoryComboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Daily Expense Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Particular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "View Summary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Expense";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Maximum Expense";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "View Category Expense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Category";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 459);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(153, 91);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(147, 20);
            this.amountTextBox.TabIndex = 10;
            // 
            // particularTextBox
            // 
            this.particularTextBox.Location = new System.Drawing.Point(153, 189);
            this.particularTextBox.Multiline = true;
            this.particularTextBox.Name = "particularTextBox";
            this.particularTextBox.Size = new System.Drawing.Size(147, 61);
            this.particularTextBox.TabIndex = 12;
            // 
            // totalExpenseTextBox
            // 
            this.totalExpenseTextBox.Location = new System.Drawing.Point(153, 404);
            this.totalExpenseTextBox.Name = "totalExpenseTextBox";
            this.totalExpenseTextBox.Size = new System.Drawing.Size(147, 20);
            this.totalExpenseTextBox.TabIndex = 13;
            // 
            // maxExpenseTextBox
            // 
            this.maxExpenseTextBox.Location = new System.Drawing.Point(153, 456);
            this.maxExpenseTextBox.Name = "maxExpenseTextBox";
            this.maxExpenseTextBox.Size = new System.Drawing.Size(147, 20);
            this.maxExpenseTextBox.TabIndex = 14;
            // 
            // totalCatTextBox
            // 
            this.totalCatTextBox.Location = new System.Drawing.Point(506, 453);
            this.totalCatTextBox.Name = "totalCatTextBox";
            this.totalCatTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalCatTextBox.TabIndex = 16;
            // 
            // showListBox
            // 
            this.showListBox.FormattingEnabled = true;
            this.showListBox.Location = new System.Drawing.Point(363, 196);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(243, 225);
            this.showListBox.TabIndex = 17;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(200, 268);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // summaryShowButton
            // 
            this.summaryShowButton.Location = new System.Drawing.Point(200, 343);
            this.summaryShowButton.Name = "summaryShowButton";
            this.summaryShowButton.Size = new System.Drawing.Size(75, 23);
            this.summaryShowButton.TabIndex = 19;
            this.summaryShowButton.Text = "Show";
            this.summaryShowButton.UseVisualStyleBackColor = true;
            this.summaryShowButton.Click += new System.EventHandler(this.summaryShowButton_Click);
            // 
            // categoryShowButton
            // 
            this.categoryShowButton.Location = new System.Drawing.Point(531, 143);
            this.categoryShowButton.Name = "categoryShowButton";
            this.categoryShowButton.Size = new System.Drawing.Size(75, 23);
            this.categoryShowButton.TabIndex = 20;
            this.categoryShowButton.Text = "Show";
            this.categoryShowButton.UseVisualStyleBackColor = true;
            this.categoryShowButton.Click += new System.EventHandler(this.categoryShowButton_Click);
            // 
            // categorycomboBox1
            // 
            this.categorycomboBox1.FormattingEnabled = true;
            this.categorycomboBox1.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categorycomboBox1.Location = new System.Drawing.Point(154, 143);
            this.categorycomboBox1.Name = "categorycomboBox1";
            this.categorycomboBox1.Size = new System.Drawing.Size(146, 21);
            this.categorycomboBox1.TabIndex = 22;
            // 
            // categoryComboBox2
            // 
            this.categoryComboBox2.FormattingEnabled = true;
            this.categoryComboBox2.Items.AddRange(new object[] {
            "House Rent",
            "Utility Bill",
            "Conveyance",
            "Grocery",
            "Misc"});
            this.categoryComboBox2.Location = new System.Drawing.Point(485, 95);
            this.categoryComboBox2.Name = "categoryComboBox2";
            this.categoryComboBox2.Size = new System.Drawing.Size(121, 21);
            this.categoryComboBox2.TabIndex = 23;
            // 
            // DailyExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 512);
            this.Controls.Add(this.categoryComboBox2);
            this.Controls.Add(this.categorycomboBox1);
            this.Controls.Add(this.categoryShowButton);
            this.Controls.Add(this.summaryShowButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.showListBox);
            this.Controls.Add(this.totalCatTextBox);
            this.Controls.Add(this.maxExpenseTextBox);
            this.Controls.Add(this.totalExpenseTextBox);
            this.Controls.Add(this.particularTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DailyExpense";
            this.Text = "DailyExpense";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox categoryComboBox2;
        private System.Windows.Forms.ComboBox categorycomboBox1;
        private System.Windows.Forms.Button categoryShowButton;
        private System.Windows.Forms.Button summaryShowButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox showListBox;
        private System.Windows.Forms.TextBox totalCatTextBox;
        private System.Windows.Forms.TextBox maxExpenseTextBox;
        private System.Windows.Forms.TextBox totalExpenseTextBox;
        private System.Windows.Forms.TextBox particularTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
    }
}

