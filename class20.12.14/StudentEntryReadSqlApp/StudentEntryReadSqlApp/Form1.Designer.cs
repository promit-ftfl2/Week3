namespace StudentEntryReadSqlApp
{
    partial class Form1
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.showListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addressLebel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameUpTextBox = new System.Windows.Forms.TextBox();
            this.emailUpTextBox = new System.Windows.Forms.TextBox();
            this.addressUpTextBox = new System.Windows.Forms.TextBox();
            this.phoneUpTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.idUpTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(195, 69);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(337, 69);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // showListView
            // 
            this.showListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.showListView.FullRowSelect = true;
            this.showListView.GridLines = true;
            this.showListView.Location = new System.Drawing.Point(132, 187);
            this.showListView.Name = "showListView";
            this.showListView.Size = new System.Drawing.Size(360, 176);
            this.showListView.TabIndex = 5;
            this.showListView.UseCompatibleStateImageBehavior = false;
            this.showListView.View = System.Windows.Forms.View.Details;
            this.showListView.SelectedIndexChanged += new System.EventHandler(this.showListView_SelectedIndexChanged);
            this.showListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.showListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adress";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email";
            // 
            // addressLebel
            // 
            this.addressLebel.AutoSize = true;
            this.addressLebel.Location = new System.Drawing.Point(554, 111);
            this.addressLebel.Name = "addressLebel";
            this.addressLebel.Size = new System.Drawing.Size(45, 13);
            this.addressLebel.TabIndex = 6;
            this.addressLebel.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(554, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone";
            // 
            // nameUpTextBox
            // 
            this.nameUpTextBox.Location = new System.Drawing.Point(654, 44);
            this.nameUpTextBox.Name = "nameUpTextBox";
            this.nameUpTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameUpTextBox.TabIndex = 7;
            // 
            // emailUpTextBox
            // 
            this.emailUpTextBox.Location = new System.Drawing.Point(654, 77);
            this.emailUpTextBox.Name = "emailUpTextBox";
            this.emailUpTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailUpTextBox.TabIndex = 7;
            // 
            // addressUpTextBox
            // 
            this.addressUpTextBox.Location = new System.Drawing.Point(654, 103);
            this.addressUpTextBox.Name = "addressUpTextBox";
            this.addressUpTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressUpTextBox.TabIndex = 7;
            // 
            // phoneUpTextBox
            // 
            this.phoneUpTextBox.Location = new System.Drawing.Point(654, 140);
            this.phoneUpTextBox.Name = "phoneUpTextBox";
            this.phoneUpTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneUpTextBox.TabIndex = 7;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(663, 190);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 8;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Id";
            this.label6.Click += new System.EventHandler(this.ID);
            // 
            // idUpTextBox
            // 
            this.idUpTextBox.Enabled = false;
            this.idUpTextBox.Location = new System.Drawing.Point(657, 11);
            this.idUpTextBox.Name = "idUpTextBox";
            this.idUpTextBox.Size = new System.Drawing.Size(100, 20);
            this.idUpTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 375);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.phoneUpTextBox);
            this.Controls.Add(this.addressUpTextBox);
            this.Controls.Add(this.emailUpTextBox);
            this.Controls.Add(this.idUpTextBox);
            this.Controls.Add(this.nameUpTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addressLebel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.showListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView showListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label addressLebel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameUpTextBox;
        private System.Windows.Forms.TextBox emailUpTextBox;
        private System.Windows.Forms.TextBox addressUpTextBox;
        private System.Windows.Forms.TextBox phoneUpTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idUpTextBox;
    }
}

