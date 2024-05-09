using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _num1 = "0";
            _num2 = "0";
            _mathOperator = null;
        }

        private string _num1;
        private string _num2;
        private string _mathOperator;


        /******************BUTTON METHODS******************/

        //Función para el botón CE
        private void ceButton_Click(object sender, EventArgs e)
        {
            resetCalculator();
            enableButtons();
        }

        //Función para los botones de números
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            numberDisplayUpdate(button.Text);
        }

        //Función para los botones de operadores aritmeticos
        private void mathOperatorButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var optr = button.Text;

            variableUpdate();
            
            if(_mathOperator != null && _num2 != "0")
            {
                arithmeticOperation();
                historyTextUpdate(optr);
                _mathOperator = optr;
            } else
            {
                historyTextUpdate(optr);
                _mathOperator = optr;
            }
        }

        //Función para el botón de cambio de signo
        private void signButton_Click(object sender, EventArgs e)
        {
            if (numberDisplay.Text == "0")
            {

            } else
            {
                numberDisplay.Text = numberDisplay.Text.StartsWith("-") ? 
                    numberDisplay.Text.Substring(1) : 
                    "-" + numberDisplay.Text;
            }
        }

        //Función del botón del punto decimal
        private void decimalButton_Click(object sender, EventArgs e)
        {
            numberDisplay.Text = numberDisplay.Text.Contains(".") ?
                numberDisplay.Text :
                numberDisplay.Text + ".";
            variableUpdate();
        }

        //Función del botón de la raíz cuadrada
        private void rootButton_Click(object sender, EventArgs e)
        {
            if(numberDisplay.Text.StartsWith("-"))
            {
                invalidInput();
            } else
            {
                double d = double.Parse(numberDisplay.Text);
                numberDisplay.Text = Math.Sqrt(d).ToString();
                variableUpdate();
            }
        }

        //Función del botón de porcentaje
        private void percentageButton_Click(object sender, EventArgs e)
        {
            //this is the percent that we want to figure out (like 20%, 50%, etc)
            var percentage = decimal.Parse(_num2) / 100;
            //this is the value of the percentage (like the number 20 if we want to figure out 20% of 100)
            var percentageValue = decimal.Parse(_num1) * percentage;

            if (_mathOperator == null)
            {
                resetCalculator();
            } else if(_mathOperator == "×")
            {
                _num2 = percentage.ToString();
                arithmeticOperation();
            } else
            {
                _num2 = percentageValue.ToString();
                arithmeticOperation();
            }
            historyText.Visible = false;
        }

        //Función del botón de igual
        private void resultBotton_Click(object sender, EventArgs e)
        {
            variableUpdate();
            arithmeticOperation();
            historyText.Visible = false;
            _mathOperator = null;
        }

        /******************INTERNAL LOGIC METHODS******************/

        //Reset variables
        private void resetCalculator()
        {
            numberDisplay.Text = "0";
            _num1 = "0";
            _num2 = "0";
            _mathOperator = null;
            historyText.Visible = false;
        }

        private void arithmeticOperation()
        {
            bool divByZero = false;
            decimal a = decimal.Parse(_num1);
            decimal b = decimal.Parse(_num2);

            switch (_mathOperator)
            {
                case "+": a = a + b; break;
                case "-": a = a - b; break;
                case "×": a = a * b; break;
                case "÷": 
                    if(b == 0)
                    {
                        divByZero = true;
                    } else
                    {
                        a = a / b;
                    }
                    break;
            }

            if (divByZero)
            {
                invalidInput();
            } else
            {
                _num1 = a.ToString();
                _num2 = "0";

                numberDisplay.Text = _num1;
            }
        }

        private void historyTextUpdate(string buttonOperator)
        {
            historyText.Text = numberDisplay.Text + " " + buttonOperator;
            historyText.Visible = true;
        }

        private void numberDisplayUpdate(string num)
        {
            if (_mathOperator == null)
            {
                if (_num1 == "0" && num == "0")
                {
                    _num1 = "0";
                }
                else if (_num1 == "0")
                {
                    _num1 = num;
                }
                else
                {
                    _num1 += num;
                }

                numberDisplay.Text = _num1;
            }
            else
            {
                if (_num2 == "0" && num == "0")
                {
                    _num2 = "0";
                }
                else if (_num2 == "0")
                {
                    _num2 = num;
                }
                else
                {
                    _num2 += num;
                }

                numberDisplay.Text = _num2;
            }
        }

        private void variableUpdate()
        {
            if (_mathOperator == null)
            {
                _num1 = numberDisplay.Text;
            }
            else
            {
                _num2 = numberDisplay.Text;
            }
        }

        private void invalidInput()
        {
            numberDisplay.Text = "Invalid Input";
            disableButtons();
        }

        private void disableButtons()
        {
            rootButton.Enabled = false;
            percentageButton.Enabled = false;
            divisionButton.Enabled = false;
            multiplicationButton.Enabled = false;
            minusButton.Enabled = false;
            plusButton.Enabled = false;
            signButton.Enabled = false;
            decimalButton.Enabled = false;
            resultBotton.Enabled = false;
            buttonNumber0.Enabled = false;
            buttonNumber1.Enabled = false;
            buttonNumber2.Enabled = false;
            buttonNumber3.Enabled = false;
            buttonNumber4.Enabled = false;
            buttonNumber5.Enabled = false;
            buttonNumber6.Enabled = false;
            buttonNumber7.Enabled = false;
            buttonNumber8.Enabled = false;
            buttonNumber9.Enabled = false;
        }

        private void enableButtons()
        {
            rootButton.Enabled = true;
            percentageButton.Enabled = true;
            divisionButton.Enabled = true;
            multiplicationButton.Enabled = true;
            minusButton.Enabled = true;
            plusButton.Enabled = true;
            signButton.Enabled = true;
            decimalButton.Enabled = true;
            resultBotton.Enabled = true;
            buttonNumber0.Enabled = true;
            buttonNumber1.Enabled = true;
            buttonNumber2.Enabled = true;
            buttonNumber3.Enabled = true;
            buttonNumber4.Enabled = true;
            buttonNumber5.Enabled = true;
            buttonNumber6.Enabled = true;
            buttonNumber7.Enabled = true;
            buttonNumber8.Enabled = true;
            buttonNumber9.Enabled = true;
        }


    }
}
