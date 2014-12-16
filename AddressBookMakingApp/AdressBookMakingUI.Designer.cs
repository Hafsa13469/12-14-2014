namespace AddressBookMakingApp
{
    partial class AdressBookMakingUI
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailAdressTextBox = new System.Windows.Forms.TextBox();
            this.personalContactNoTextBox = new System.Windows.Forms.TextBox();
            this.homeContactNoTextBox = new System.Windows.Forms.TextBox();
            this.homeAdressTextBox = new System.Windows.Forms.TextBox();
            this.selectComboBox = new System.Windows.Forms.ComboBox();
            this.showButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Label();
            this.insertDataTextBox = new System.Windows.Forms.TextBox();
            this.searchListBox = new System.Windows.Forms.ListBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Person\'s Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email Adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Personal Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Home Contact Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Home Adress";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(201, 47);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(204, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // emailAdressTextBox
            // 
            this.emailAdressTextBox.Location = new System.Drawing.Point(201, 84);
            this.emailAdressTextBox.Name = "emailAdressTextBox";
            this.emailAdressTextBox.Size = new System.Drawing.Size(204, 20);
            this.emailAdressTextBox.TabIndex = 6;
            // 
            // personalContactNoTextBox
            // 
            this.personalContactNoTextBox.Location = new System.Drawing.Point(201, 122);
            this.personalContactNoTextBox.Name = "personalContactNoTextBox";
            this.personalContactNoTextBox.Size = new System.Drawing.Size(204, 20);
            this.personalContactNoTextBox.TabIndex = 7;
            // 
            // homeContactNoTextBox
            // 
            this.homeContactNoTextBox.Location = new System.Drawing.Point(201, 162);
            this.homeContactNoTextBox.Name = "homeContactNoTextBox";
            this.homeContactNoTextBox.Size = new System.Drawing.Size(204, 20);
            this.homeContactNoTextBox.TabIndex = 8;
            // 
            // homeAdressTextBox
            // 
            this.homeAdressTextBox.Location = new System.Drawing.Point(201, 198);
            this.homeAdressTextBox.Name = "homeAdressTextBox";
            this.homeAdressTextBox.Size = new System.Drawing.Size(204, 20);
            this.homeAdressTextBox.TabIndex = 9;
            // 
            // selectComboBox
            // 
            this.selectComboBox.FormattingEnabled = true;
            this.selectComboBox.Items.AddRange(new object[] {
            "Name",
            "Email Adress",
            "Personal Contact Number"});
            this.selectComboBox.Location = new System.Drawing.Point(201, 291);
            this.selectComboBox.Name = "selectComboBox";
            this.selectComboBox.Size = new System.Drawing.Size(204, 21);
            this.selectComboBox.TabIndex = 10;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(303, 235);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 11;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Select";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(418, 235);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Insert
            // 
            this.Insert.AutoSize = true;
            this.Insert.Location = new System.Drawing.Point(120, 338);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(75, 13);
            this.Insert.TabIndex = 15;
            this.Insert.Text = "Input the Data";
            // 
            // insertDataTextBox
            // 
            this.insertDataTextBox.Location = new System.Drawing.Point(201, 335);
            this.insertDataTextBox.Name = "insertDataTextBox";
            this.insertDataTextBox.Size = new System.Drawing.Size(204, 20);
            this.insertDataTextBox.TabIndex = 16;
            // 
            // searchListBox
            // 
            this.searchListBox.FormattingEnabled = true;
            this.searchListBox.Location = new System.Drawing.Point(180, 434);
            this.searchListBox.Name = "searchListBox";
            this.searchListBox.Size = new System.Drawing.Size(298, 238);
            this.searchListBox.TabIndex = 17;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(422, 384);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 18;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // AdressBookMakingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 696);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchListBox);
            this.Controls.Add(this.insertDataTextBox);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.selectComboBox);
            this.Controls.Add(this.homeAdressTextBox);
            this.Controls.Add(this.homeContactNoTextBox);
            this.Controls.Add(this.personalContactNoTextBox);
            this.Controls.Add(this.emailAdressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdressBookMakingUI";
            this.Text = "AdressBookMakingUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailAdressTextBox;
        private System.Windows.Forms.TextBox personalContactNoTextBox;
        private System.Windows.Forms.TextBox homeContactNoTextBox;
        private System.Windows.Forms.TextBox homeAdressTextBox;
        private System.Windows.Forms.ComboBox selectComboBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label Insert;
        private System.Windows.Forms.TextBox insertDataTextBox;
        private System.Windows.Forms.ListBox searchListBox;
        private System.Windows.Forms.Button searchbutton;
    }
}

