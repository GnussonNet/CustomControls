using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Textbox_with_max_value
{
    public partial class RandomTest : UserControl
    {
        public RandomTest()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Properties for current operation and the two values
        /// </summary>
        #region Properties

        // Random engine
        Random r = new Random();


        // First number
        private double _number1;

        // Do not show in properties tab
        [Browsable(false)]
        public double number1
        {
            get { return _number1; }
            set 
            { 
                _number1 = value;
                
                // Update lbl with new number
                lblNumber1.Text = _number1.ToString();
            }
        }


        // Secound number
        private double _number2;

        // Do not show in properties tab
        [Browsable(false)]
        public double number2
        {
            get { return _number2; }
            set 
            { 
                _number2 = value;

                // Update lbl with new number
                lblNumber2.Text = _number2.ToString();
            }
        }


        // Current operation ex. +, -, * and /
        private string _operation;

        // Do not show in properties tab
        [Browsable(false)]
        public string operation
        {
            get
            {
                return _operation;
            }
            set
            {
                _operation = value;

                // Update lbl with operation and reset textbox
                lblOperation.Text = _operation;
                txtAnswer.Text = "";
                txtAnswer.BackColor = Color.White;
            }
        }
        #endregion

        /// <summary>
        /// Events for radiobuttons, load and answer text change
        /// </summary>
        #region Events
        private void RandomTest_Load(object sender, EventArgs e)
        {
            // Generate two random numbers
            number1 = r.Next(1, 101);
            number2 = r.Next(1, 101);

            // Set default operation
            operation = "+";
        }


        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {          
            // Try parse textbox text to double.
            double number;
            if (double.TryParse(txtAnswer.Text, out number))
            {
                // Check which operation are active
                switch (operation)
                {
                    case "+":
                        // If the two numbers is equal to the textbox parsed value, show green background. Else show red backgorund
                        if (number1 + number2 == number)
                            txtAnswer.BackColor = Color.Green;
                        else
                            txtAnswer.BackColor = Color.Red;
                        break;
                    case "-":
                        if (number1 - number2 == number)
                            txtAnswer.BackColor = Color.Green;
                        else
                            txtAnswer.BackColor = Color.Red;
                        break;
                    case "*":
                        if (number1 * number2 == number)
                            txtAnswer.BackColor = Color.Green;
                        else
                            txtAnswer.BackColor = Color.Red;
                        break;
                    case "/":
                        // Round of decimals to 2
                        if (Math.Round(number1 / number2, 2) == number)
                            txtAnswer.BackColor = Color.Green;
                        else
                            txtAnswer.BackColor = Color.Red;
                        break;
                }
            }
            else
            {
                // Reset textbox when null
                if (txtAnswer.Text == "")
                    txtAnswer.BackColor = Color.White;
                else if (txtAnswer.Text == "-" || txtAnswer.Text == ".")
                {
                    // Do nothing if textbox starts with "-" and "."
                }
                else
                {
                    // Display error message
                    txtAnswer.Text = "";
                    MessageBox.Show("Invalid input! Only numbers allowed...");
                }            
            }
        }


        private void rbtnAddition_CheckedChanged(object sender, EventArgs e)
        {
            // Change operation to "+"
            if (rbtnAddition.Checked)
                operation = "+";
        }


        private void rbtnSubtraction_CheckedChanged(object sender, EventArgs e)
        {
            // Change operation to "-"
            if (rbtnSubtraction.Checked)
                operation = "-";
        }


        private void rbtnMultiplication_CheckedChanged(object sender, EventArgs e)
        {
            // Change operation to "*"
            if (rbtnMultiplication.Checked)
                operation = "*";
        }


        private void rbtnDivision_CheckedChanged(object sender, EventArgs e)
        {
            // Change operation to "/"
            if (rbtnDivision.Checked)
                operation = "/";
        }
        #endregion
    }
}
