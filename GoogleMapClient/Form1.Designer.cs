namespace GoogleMapClient
{
    partial class GoogleMapForm
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
            this.CSVTextBox = new System.Windows.Forms.TextBox();
            this.HTMLPathTextBox = new System.Windows.Forms.TextBox();
            this.CSVButton = new System.Windows.Forms.Button();
            this.HTMLButton = new System.Windows.Forms.Button();
            this.WriteFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CSVTextBox
            // 
            this.CSVTextBox.Location = new System.Drawing.Point(272, 123);
            this.CSVTextBox.Name = "CSVTextBox";
            this.CSVTextBox.Size = new System.Drawing.Size(392, 38);
            this.CSVTextBox.TabIndex = 0;
            // 
            // HTMLPathTextBox
            // 
            this.HTMLPathTextBox.Location = new System.Drawing.Point(272, 35);
            this.HTMLPathTextBox.Name = "HTMLPathTextBox";
            this.HTMLPathTextBox.Size = new System.Drawing.Size(392, 38);
            this.HTMLPathTextBox.TabIndex = 1;
            // 
            // CSVButton
            // 
            this.CSVButton.Location = new System.Drawing.Point(27, 112);
            this.CSVButton.Name = "CSVButton";
            this.CSVButton.Size = new System.Drawing.Size(199, 58);
            this.CSVButton.TabIndex = 2;
            this.CSVButton.Text = "CSV File";
            this.CSVButton.UseVisualStyleBackColor = true;
            this.CSVButton.Click += new System.EventHandler(this.CSVButton_Click);
            // 
            // HTMLButton
            // 
            this.HTMLButton.Location = new System.Drawing.Point(27, 24);
            this.HTMLButton.Name = "HTMLButton";
            this.HTMLButton.Size = new System.Drawing.Size(199, 58);
            this.HTMLButton.TabIndex = 3;
            this.HTMLButton.Text = "HTML File";
            this.HTMLButton.UseVisualStyleBackColor = true;
            this.HTMLButton.Click += new System.EventHandler(this.HTMLButton_Click);
            // 
            // WriteFileButton
            // 
            this.WriteFileButton.Location = new System.Drawing.Point(471, 256);
            this.WriteFileButton.Name = "WriteFileButton";
            this.WriteFileButton.Size = new System.Drawing.Size(209, 53);
            this.WriteFileButton.TabIndex = 4;
            this.WriteFileButton.Text = "Write to File";
            this.WriteFileButton.UseVisualStyleBackColor = true;
            this.WriteFileButton.Click += new System.EventHandler(this.WriteFileButton_Click);
            // 
            // GoogleMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 361);
            this.Controls.Add(this.WriteFileButton);
            this.Controls.Add(this.HTMLButton);
            this.Controls.Add(this.CSVButton);
            this.Controls.Add(this.HTMLPathTextBox);
            this.Controls.Add(this.CSVTextBox);
            this.Name = "GoogleMapForm";
            this.Text = "Google Map Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CSVTextBox;
        private System.Windows.Forms.TextBox HTMLPathTextBox;
        private System.Windows.Forms.Button CSVButton;
        private System.Windows.Forms.Button HTMLButton;
        private System.Windows.Forms.Button WriteFileButton;
    }
}

