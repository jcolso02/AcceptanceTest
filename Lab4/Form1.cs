// Lab 4
// S5034
// October 3, 2021
// CIS 199-50



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e) // Execute function when the "Calculate" button is clicked
        {
            // Get User Input

            double gpa;
            gpa = Convert.ToDouble(gpaTextBox.Text);

            double test;
            test = Convert.ToDouble(testTextBox.Text);



            // Check User Input

            if(gpa < 0 || gpa > 4.0)
                gpaErrorLabel.Visible = true;
            else
                gpaErrorLabel.Visible = false;

            if (test < 0 || test > 100)
                testErrorLabel.Visible = true;
            else
                testErrorLabel.Visible = false;



            // Logic Check

            if(gpaErrorLabel.Visible == false && testErrorLabel.Visible == false)
            {
                if ((gpa >= 3.0 && test >= 60) || (gpa < 3.0 && test >= 80))
                {
                    outputTextBox.Text = "Accept";
                    acceptTextBox.Text = Convert.ToString(Convert.ToDouble(acceptTextBox.Text) + 1);
                }
                else
                {
                    outputTextBox.Text = "Reject";
                    rejectTextBox.Text = Convert.ToString(Convert.ToDouble(rejectTextBox.Text) + 1);
                }
            }
            else
            {
                outputTextBox.Text = "";
            }
        }
    }
}
