namespace GoogleMapWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PrintButton = new System.Windows.Forms.Button();
            this.LocationListBox = new System.Windows.Forms.ListBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.AddressLine1Label = new System.Windows.Forms.Label();
            this.AddressLine2Label = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ZipLabel = new System.Windows.Forms.Label();
            this.CompanyTextBox = new System.Windows.Forms.TextBox();
            this.AddressLine1TextBox = new System.Windows.Forms.TextBox();
            this.AddressLine2TextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(924, 559);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(245, 50);
            this.PrintButton.TabIndex = 0;
            this.PrintButton.Text = "Print File";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // LocationListBox
            // 
            this.LocationListBox.FormattingEnabled = true;
            this.LocationListBox.ItemHeight = 31;
            this.LocationListBox.Location = new System.Drawing.Point(82, 388);
            this.LocationListBox.Name = "LocationListBox";
            this.LocationListBox.Size = new System.Drawing.Size(671, 221);
            this.LocationListBox.TabIndex = 1;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(73, 42);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(233, 32);
            this.CompanyLabel.TabIndex = 2;
            this.CompanyLabel.Text = "Company Name: ";
            // 
            // AddressLine1Label
            // 
            this.AddressLine1Label.AutoSize = true;
            this.AddressLine1Label.Location = new System.Drawing.Point(76, 101);
            this.AddressLine1Label.Name = "AddressLine1Label";
            this.AddressLine1Label.Size = new System.Drawing.Size(219, 32);
            this.AddressLine1Label.TabIndex = 3;
            this.AddressLine1Label.Text = "Address Line 1: ";
            // 
            // AddressLine2Label
            // 
            this.AddressLine2Label.AutoSize = true;
            this.AddressLine2Label.Location = new System.Drawing.Point(76, 157);
            this.AddressLine2Label.Name = "AddressLine2Label";
            this.AddressLine2Label.Size = new System.Drawing.Size(219, 32);
            this.AddressLine2Label.TabIndex = 4;
            this.AddressLine2Label.Text = "Address Line 2: ";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(76, 215);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(79, 32);
            this.CityLabel.TabIndex = 5;
            this.CityLabel.Text = "City: ";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Location = new System.Drawing.Point(76, 269);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(90, 32);
            this.StateLabel.TabIndex = 6;
            this.StateLabel.Text = "State:";
            // 
            // ZipLabel
            // 
            this.ZipLabel.AutoSize = true;
            this.ZipLabel.Location = new System.Drawing.Point(76, 326);
            this.ZipLabel.Name = "ZipLabel";
            this.ZipLabel.Size = new System.Drawing.Size(63, 32);
            this.ZipLabel.TabIndex = 7;
            this.ZipLabel.Text = "Zip:";
            // 
            // CompanyTextBox
            // 
            this.CompanyTextBox.Location = new System.Drawing.Point(312, 42);
            this.CompanyTextBox.Name = "CompanyTextBox";
            this.CompanyTextBox.Size = new System.Drawing.Size(441, 38);
            this.CompanyTextBox.TabIndex = 8;
            // 
            // AddressLine1TextBox
            // 
            this.AddressLine1TextBox.Location = new System.Drawing.Point(312, 101);
            this.AddressLine1TextBox.Name = "AddressLine1TextBox";
            this.AddressLine1TextBox.Size = new System.Drawing.Size(441, 38);
            this.AddressLine1TextBox.TabIndex = 9;
            // 
            // AddressLine2TextBox
            // 
            this.AddressLine2TextBox.Location = new System.Drawing.Point(312, 157);
            this.AddressLine2TextBox.Name = "AddressLine2TextBox";
            this.AddressLine2TextBox.Size = new System.Drawing.Size(441, 38);
            this.AddressLine2TextBox.TabIndex = 10;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(312, 215);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(441, 38);
            this.CityTextBox.TabIndex = 11;
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(312, 269);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(441, 38);
            this.StateTextBox.TabIndex = 12;
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.Location = new System.Drawing.Point(312, 326);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.Size = new System.Drawing.Size(441, 38);
            this.ZipTextBox.TabIndex = 13;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(924, 388);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(245, 51);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add Location";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 701);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ZipTextBox);
            this.Controls.Add(this.StateTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.AddressLine2TextBox);
            this.Controls.Add(this.AddressLine1TextBox);
            this.Controls.Add(this.CompanyTextBox);
            this.Controls.Add(this.ZipLabel);
            this.Controls.Add(this.StateLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.AddressLine2Label);
            this.Controls.Add(this.AddressLine1Label);
            this.Controls.Add(this.CompanyLabel);
            this.Controls.Add(this.LocationListBox);
            this.Controls.Add(this.PrintButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.ListBox LocationListBox;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Label AddressLine1Label;
        private System.Windows.Forms.Label AddressLine2Label;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.TextBox CompanyTextBox;
        private System.Windows.Forms.TextBox AddressLine1TextBox;
        private System.Windows.Forms.TextBox AddressLine2TextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.TextBox ZipTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}

