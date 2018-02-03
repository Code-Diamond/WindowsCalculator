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
        string firstN = "";
        string secondN = "";
        decimal result = 0.0m;
        string mathOperation = "";
        bool operationPressed = false;




        public Form1()
        {
            InitializeComponent();

            //Make labels invis
            firstNLabel.Text = "";
            secondNLabel.Text = "";
            operatorLabel.Text = "";


        }



        

        //All of the numerical button and their click or key press events


        private void oneButton_Click(object sender, EventArgs e)
        {
            concatenateNumber("1");
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            concatenateNumber("2");
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            concatenateNumber("3");
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            concatenateNumber("4");
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            concatenateNumber("5");
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            concatenateNumber("6");
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            concatenateNumber("7");
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            concatenateNumber("8");
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            concatenateNumber("9");
        }
        private void zeroButton_Click(object sender, EventArgs e)
        {
            concatenateNumber("0");
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            concatenateNumber(".");
        }






        //All of the math operator buttons and their events


        private void plusButton_Click(object sender, EventArgs e)
        {
            mathOperation = "+";
            //operatorLabel.Text = mathOperation;
            operationPressed = true;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            mathOperation = "/";
            //operatorLabel.Text = mathOperation;
            operationPressed = true;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            mathOperation = "*";
            //operatorLabel.Text = mathOperation;
            operationPressed = true;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            mathOperation = "-";
            //operatorLabel.Text = mathOperation;
            operationPressed = true;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            calculate();
        }
 








        //functions that calculate or perform algebra

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





        //private void switchOperationPressed()
        //{
        //    operationPressed = !operationPressed;
        //}

        private void concatenateNumber(string number)
        {
            if(operationPressed)
            {
                secondN += number;
                resultLabel.Text = firstN;
                
            }
            else
            {
                firstN += number;
                resultLabel.Text = firstN;
            }
        }

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

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Variable Assignments
             firstN = "";
             secondN = "";
             result = 0.0m;
             mathOperation = "";
             operationPressed = false;
            resultLabel.Text = "0";
            firstNLabel.Text = "";
            secondNLabel.Text = "";
            operatorLabel.Text = "";


        }
    }
}
