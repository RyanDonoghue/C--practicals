using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1_Menu
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void one_Click(object sender, EventArgs e)
        {
            displayfield.Text += "1";
        }
        private void two_Click(object sender, EventArgs e)
        {
            displayfield.Text += "2";
        }
        private void three_Click(object sender, EventArgs e)
        {
            displayfield.Text += "3";
        }
        private void four_Click(object sender, EventArgs e)
        {
            displayfield.Text += "4";
        }
        private void five_Click(object sender, EventArgs e)
        {
            displayfield.Text += "5";
        }
        private void six_Click(object sender, EventArgs e)
        {
            displayfield.Text += "6";
        }
        private void seven_Click(object sender, EventArgs e)
        {
            displayfield.Text += "7";
        }
        private void eight_Click(object sender, EventArgs e)
        {
            displayfield.Text += "8";
        }
        private void nine_Click(object sender, EventArgs e)
        {
            displayfield.Text += "9";
        }
        private void zero_Click(object sender, EventArgs e)
        {
            displayfield.Text += "0";
        }
        private void plus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(displayfield.Text))
            {
                errorcheck = true;
                displayfield.Text += "Error, please enter an operand first ";
            }
            else
            {
                if (previous == false)
                {
                    num1 = displayfield.Text;
                    displayfield.Text = "";
                    operand = 'p';
                }
                else
                {
                    num1 = storedresult.ToString();
                    operand = 'p';
                    displayfield.Text = "";
                }
            }
        }
        private void minus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(displayfield.Text))
            {
                errorcheck = true;
                displayfield.Text += "Error, please enter an operand first ";
            }
            else
            {
                if (previous == false)
                {
                    num1 = displayfield.Text;
                    displayfield.Text = "";
                    operand = 'p';
                }
                else
                {
                    num1 = storedresult.ToString();
                    operand = 'p';
                    displayfield.Text = "";
                }
            }
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(displayfield.Text))
            {
                errorcheck = true;
                displayfield.Text += "Error, please enter an operand first ";
            }
            else
            {
                if (previous == false)
                {
                    num1 = displayfield.Text;
                    displayfield.Text = "";
                    operand = 'p';
                }
                else
                {
                    num1 = storedresult.ToString();
                    operand = 'p';
                    displayfield.Text = "";
                }
            }
        }
        private void divide_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(displayfield.Text))
            {
                errorcheck = true;
                displayfield.Text += "Error, please enter an operand first ";
            }
            else
            {
                if (previous == false)
                {
                    num1 = displayfield.Text;
                    displayfield.Text = "";
                    operand = 'p';
                }
                else
                {
                    num1 = storedresult.ToString();
                    operand = 'p';
                    displayfield.Text = "";
                }
            }
        }
        private void equals_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(num1))
            {
                errorcheck = true;
                displayfield.Text += "Error, please an operand ";
            }
            else
            {
                if (string.IsNullOrEmpty(displayfield.Text))
                {
                    displayfield.Text += "Error, please a second oeprand ";
                }
                else
                {
                    num2 = displayfield.Text;
                    switch (operand)
                    {
                        case 'p':
                            parsed1 = Decimal.Parse(num1);
                            parsed2 = Decimal.Parse(num2);
                            result = parsed1 + parsed2;
                            displayfield.Text = result.ToString();
                            storedresult = result;
                            previous = true;
                            break;
                        case 's':
                            parsed1 = Decimal.Parse(num1);
                            parsed2 = Decimal.Parse(num2);
                            result = parsed1 - parsed2;
                            displayfield.Text = result.ToString();
                            storedresult = result;
                            previous = true;
                            break;
                        case 'm':
                            parsed1 = Decimal.Parse(num1);
                            parsed2 = Decimal.Parse(num2);
                            result = parsed1 * parsed2;
                            displayfield.Text = result.ToString();
                            storedresult = result;
                            previous = true;
                            break;
                        case 'd':
                            parsed1 = Decimal.Parse(num1);
                            parsed2 = Decimal.Parse(num2);
                            result = parsed1 / parsed2;
                            displayfield.Text = result.ToString();
                            storedresult = result;
                            previous = true;
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }
                }
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {

        }
        public bool errorCheck()
        {
            if (string.IsNullOrEmpty(displayfield.Text))
            {
                errorcheck = true;
                return true;
            }
            else
            {
                errorcheck = false;
                return false;
            }
        }
        private void one_MouseLeave(object sender, EventArgs e)
        {
            one.BackColor = Color.White;
        }
        private void one_MouseEnter(object sender, EventArgs e)
        {
            one.BackColor = Color.Gray;
        }
        private void two_MouseLeave(object sender, EventArgs e)
        {
            two.BackColor = Color.White;
        }
        private void two_MouseEnter(object sender, EventArgs e)
        {
            two.BackColor = Color.Gray;
        }
        private void three_MouseLeave(object sender, EventArgs e)
        {
            three.BackColor = Color.White;
        }
        private void three_MouseEnter(object sender, EventArgs e)
        {
            three.BackColor = Color.Gray;
        }
        private void four_MouseLeave(object sender, EventArgs e)
        {
            four.BackColor = Color.White;
        }
        private void four_MouseEnter(object sender, EventArgs e)
        {
            four.BackColor = Color.Gray;
        }
        private void five_MouseLeave(object sender, EventArgs e)
        {
            five.BackColor = Color.White;
        }
        private void five_MouseEnter(object sender, EventArgs e)
        {
            five.BackColor = Color.Gray;
        }
        private void six_MouseLeave(object sender, EventArgs e)
        {
            six.BackColor = Color.White;
        }
        private void six_MouseEnter(object sender, EventArgs e)
        {
            six.BackColor = Color.Gray;
        }
        private void seven_MouseLeave(object sender, EventArgs e)
        {
            seven.BackColor = Color.White;
        }
        private void seven_MouseEnter(object sender, EventArgs e)
        {
            seven.BackColor = Color.Gray;
        }
        private void eight_MouseLeave(object sender, EventArgs e)
        {
            eight.BackColor = Color.White;
        }
        private void eight_MouseEnter(object sender, EventArgs e)
        {
            eight.BackColor = Color.Gray;
        }
        private void nine_MouseLeave(object sender, EventArgs e)
        {
            nine.BackColor = Color.White;
        }
        private void nine_MouseEnter(object sender, EventArgs e)
        {
            nine.BackColor = Color.Gray;
        }
        private void zero_MouseLeave(object sender, EventArgs e)
        {
            zero.BackColor = Color.White;
        }
        private void zero_MouseEnter(object sender, EventArgs e)
        {
            zero.BackColor = Color.Gray;
        }
        private void plus_MouseLeave(object sender, EventArgs e)
        {
            plus.BackColor = Color.White;
        }
        private void plus_MouseEnter(object sender, EventArgs e)
        {
            plus.BackColor = Color.Gray;
        }
        private void minus_MouseLeave(object sender, EventArgs e)
        {
            minus.BackColor = Color.White;
        }
        private void minus_MouseEnter(object sender, EventArgs e)
        {
            minus.BackColor = Color.Gray;
        }
        private void multiply_MouseLeave(object sender, EventArgs e)
        {
            multiply.BackColor = Color.White;
        }
        private void multiply_MouseEnter(object sender, EventArgs e)
        {
            multiply.BackColor = Color.Gray;
        }
        private void divide_MouseLeave(object sender, EventArgs e)
        {
            divide.BackColor = Color.White;
        }
        private void divide_MouseEnter(object sender, EventArgs e)
        {
            divide.BackColor = Color.Gray;
        }
        private void equals_MouseLeave(object sender, EventArgs e)
        {
            equals.BackColor = Color.White;
        }
        private void equals_MouseEnter(object sender, EventArgs e)
        {
            equals.BackColor = Color.Gray;
        }
        private void clear_MouseLeave(object sender, EventArgs e)
        {
            clear.BackColor = Color.White;
        }
        private void clear_MouseEnter(object sender, EventArgs e)
        {
            clear.BackColor = Color.Gray;
        }
    }
}
