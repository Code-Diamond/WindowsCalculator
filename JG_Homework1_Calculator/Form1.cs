using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JG_Homework1_Calculator
{
    public partial class Form1 : Form
    {
        //Variable Assignments
        //Stores the value of the first number entered
        string firstN = "";
        //Stores the value of the second number entered
        string secondN = "";
        //Stores the value of the result after calculation
        decimal result = 0.0m;
        //Stores the math operation being used in the form of a string
        string mathOperation = "";
        
        //Boolean Conditions
        bool operationPressed = false;
        bool resetResultLabel = false;



        //Form constructor
        public Form1()
        {
            InitializeComponent();
            //Make labels empty at start of program
            firstNLabel.Text = "";
            secondNLabel.Text = "";
            operatorLabel.Text = "";
        }



        

        //All of the numerical button and their click or key press events

        
        private void oneButton_Click(object sender, EventArgs e)
        {
            if(operationPressed && resetResultLabel)
            {
                resultLabel.Text = "";
                resetResultLabel = false;
            }
            concatenateNumber("1");

            equalButton.Focus();

        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (operationPressed && resetResultLabel)
            {
                resultLabel.Text = "";
                resetResultLabel = false;
            }
            concatenateNumber("2");

            equalButton.Focus();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (operationPressed && resetResultLabel)
            {
                resultLabel.Text = "";
                resetResultLabel = false;
            }
            concatenateNumber("3");

            equalButton.Focus();
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (operationPressed && resetResultLabel)
            {
                resultLabel.Text = "";
                resetResultLabel = false;
            }
            concatenateNumber("4");

            equalButton.Focus();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (operationPressed && resetResultLabel)
            {
                resultLabel.Text = "";
                resetResultLabel = false;
            }
            concatenateNumber("5");

            equalButton.Focus();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (operationPressed && resetResultLabel)
            {
                resultLabel.Text = "";
                resetResultLabel = false;
            }
            concatenateNumber("6");

            equalButton.Focus();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (operationPressed && resetResultLabel)
            {
                resultLabel.Text = "";
                resetResultLabel = false;
            }
            concatenateNumber("7");

            equalButton.Focus();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (operationPressed && resetResultLabel)
            {
                resultLabel.Text = "";
                resetResultLabel = false;
            }
            concatenateNumber("8");

            equalButton.Focus();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (operationPressed && resetResultLabel)
            {
                resultLabel.Text = "";
                resetResultLabel = false;
            }
            concatenateNumber("9");
        }
        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (operationPressed && resetResultLabel)
            {
                resultLabel.Text = "";
                resetResultLabel = false;
            }
            concatenateNumber("0");

            equalButton.Focus();
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            concatenateNumber(".");

            equalButton.Focus();
        }


        private void concatenateNumber(string number)
        {
            if (operationPressed)
            {
                secondN += number;
                resultLabel.Text += number;
            }
            else
            {
                firstN += number;
                resultLabel.Text = firstN;
            }
        }




        //All of the math operator buttons and their events


        private void plusButton_Click(object sender, EventArgs e)
        {
            if (!operationPressed)
            {
                mathOperation = "+";
                operationPressed = true;
                resetResultLabel = true;
                equalButton.Focus();
            }
            else
            {
                mathOperation = "+";
                calculate();
                equalButton.Focus();
            }
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if(!operationPressed)
            {
                mathOperation = "/";
                resetResultLabel = true;
                operationPressed = true;
                equalButton.Focus();
            }
            else
            {
                mathOperation = "/";
                calculate();
                equalButton.Focus();
            }

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (!operationPressed)
            {
                mathOperation = "*";
                resetResultLabel = true;
                operationPressed = true;
                equalButton.Focus();
            }
            else
            {
                mathOperation = "*";
                calculate();
                equalButton.Focus();
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (!operationPressed)
            {
                mathOperation = "-";
                resetResultLabel = true;
                operationPressed = true;
                equalButton.Focus();
            }
            else
            {
                mathOperation = "-";
                calculate();
                equalButton.Focus();

            }
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            calculate();
        }
 








        //Functions that calculate or perform algebra

        private void calculate()
        {
            try
            {
                performAlgebra();
                resultLabel.Text = Convert.ToString(result);
                operatorLabel.Text = mathOperation;
                firstNLabel.Text = firstN;
                secondNLabel.Text = secondN;
                firstN = Convert.ToString(result);
                secondN = "";
                operationPressed = true;
                resetResultLabel = true;
            }
            catch
            {
            }


        }

        private void performAlgebra()
        {
            switch(mathOperation)
            {
                case "*":
                    result = decimal.Parse(firstN) * decimal.Parse(secondN);
                    break;
                case "/":
                    result = decimal.Parse(firstN) / decimal.Parse(secondN);
                    break;
                case "+":
                    result = decimal.Parse(firstN) + decimal.Parse(secondN);
                    break;
                case "-":
                    result = decimal.Parse(firstN) - decimal.Parse(secondN);
                    break;
            }
        }

        //Extra hotkey assignments
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Multiply)
            {
                mathOperation = "*";
                operationPressed = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                calculate();
            }
        }
        //Clears all values and restarts
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Variable Assignments
            firstN = "";
            secondN = "";
            result = 0.0m;
            mathOperation = "";
            operationPressed = false;
            resetResultLabel = false;
            resultLabel.Text = "0";
            firstNLabel.Text = "";
            secondNLabel.Text = "";
            operatorLabel.Text = "";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
