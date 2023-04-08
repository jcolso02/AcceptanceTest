// Lab 4
// S5034
// October 3, 2021
// CIS 199-50



namespace Lab4
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
            this.gpaLabel = new System.Windows.Forms.Label();
            this.testLabel = new System.Windows.Forms.Label();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.acceptTextBox = new System.Windows.Forms.TextBox();
            this.rejectTextBox = new System.Windows.Forms.TextBox();
            this.acceptLabel = new System.Windows.Forms.Label();
            this.rejectLabel = new System.Windows.Forms.Label();
            this.gpaErrorLabel = new System.Windows.Forms.Label();
            this.testErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(118, 30);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(60, 13);
            this.gpaLabel.TabIndex = 0;
            this.gpaLabel.Text = "Enter GPA:";
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Location = new System.Drawing.Point(33, 81);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(145, 13);
            this.testLabel.TabIndex = 1;
            this.testLabel.Text = "Enter Admissions Test Score:";
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(200, 27);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(100, 20);
            this.gpaTextBox.TabIndex = 2;
            // 
            // testTextBox
            // 
            this.testTextBox.Location = new System.Drawing.Point(200, 78);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(100, 20);
            this.testTextBox.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(121, 119);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Enabled = false;
            this.outputTextBox.Location = new System.Drawing.Point(121, 176);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(100, 20);
            this.outputTextBox.TabIndex = 5;
            // 
            // acceptTextBox
            // 
            this.acceptTextBox.Enabled = false;
            this.acceptTextBox.Location = new System.Drawing.Point(513, 28);
            this.acceptTextBox.Name = "acceptTextBox";
            this.acceptTextBox.Size = new System.Drawing.Size(84, 20);
            this.acceptTextBox.TabIndex = 6;
            this.acceptTextBox.Text = "0";
            // 
            // rejectTextBox
            // 
            this.rejectTextBox.Enabled = false;
            this.rejectTextBox.Location = new System.Drawing.Point(513, 79);
            this.rejectTextBox.Name = "rejectTextBox";
            this.rejectTextBox.Size = new System.Drawing.Size(84, 20);
            this.rejectTextBox.TabIndex = 7;
            this.rejectTextBox.Text = "0";
            // 
            // acceptLabel
            // 
            this.acceptLabel.AutoSize = true;
            this.acceptLabel.Location = new System.Drawing.Point(451, 31);
            this.acceptLabel.Name = "acceptLabel";
            this.acceptLabel.Size = new System.Drawing.Size(56, 13);
            this.acceptLabel.TabIndex = 9;
            this.acceptLabel.Text = "Accepted:";
            // 
            // rejectLabel
            // 
            this.rejectLabel.AutoSize = true;
            this.rejectLabel.Location = new System.Drawing.Point(455, 82);
            this.rejectLabel.Name = "rejectLabel";
            this.rejectLabel.Size = new System.Drawing.Size(53, 13);
            this.rejectLabel.TabIndex = 10;
            this.rejectLabel.Text = "Rejected:";
            // 
            // gpaErrorLabel
            // 
            this.gpaErrorLabel.AutoSize = true;
            this.gpaErrorLabel.Location = new System.Drawing.Point(77, 212);
            this.gpaErrorLabel.Name = "gpaErrorLabel";
            this.gpaErrorLabel.Size = new System.Drawing.Size(183, 13);
            this.gpaErrorLabel.TabIndex = 11;
            this.gpaErrorLabel.Text = "Error: GPA must be between 0.0 - 4.0";
            this.gpaErrorLabel.Visible = false;
            // 
            // testErrorLabel
            // 
            this.testErrorLabel.AutoSize = true;
            this.testErrorLabel.Location = new System.Drawing.Point(77, 239);
            this.testErrorLabel.Name = "testErrorLabel";
            this.testErrorLabel.Size = new System.Drawing.Size(207, 13);
            this.testErrorLabel.TabIndex = 12;
            this.testErrorLabel.Text = "Error: Test Score must be between 0 - 100";
            this.testErrorLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 279);
            this.Controls.Add(this.testErrorLabel);
            this.Controls.Add(this.gpaErrorLabel);
            this.Controls.Add(this.rejectLabel);
            this.Controls.Add(this.acceptLabel);
            this.Controls.Add(this.rejectTextBox);
            this.Controls.Add(this.acceptTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.testTextBox);
            this.Controls.Add(this.gpaTextBox);
            this.Controls.Add(this.testLabel);
            this.Controls.Add(this.gpaLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox acceptTextBox;
        private System.Windows.Forms.TextBox rejectTextBox;
        private System.Windows.Forms.Label acceptLabel;
        private System.Windows.Forms.Label rejectLabel;
        private System.Windows.Forms.Label gpaErrorLabel;
        private System.Windows.Forms.Label testErrorLabel;
    }
}

