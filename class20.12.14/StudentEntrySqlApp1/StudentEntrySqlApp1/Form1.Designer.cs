namespace StudentEntrySqlApp1
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(253, 343);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 14;
            this.CloseButton.Text = "Button1";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(113, 343);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(182, 257);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 10;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(182, 194);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 11;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(182, 124);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 12;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(182, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 13;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(85, 260);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 13);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Phone";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(82, 201);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(45, 13);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Address";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(82, 131);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Email";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(82, 67);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Name";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 425);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CloseButton;
        internal System.Windows.Forms.Button SaveButton;
        internal System.Windows.Forms.TextBox phoneTextBox;
        internal System.Windows.Forms.TextBox addressTextBox;
        internal System.Windows.Forms.TextBox emailTextBox;
        internal System.Windows.Forms.TextBox nameTextBox;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

