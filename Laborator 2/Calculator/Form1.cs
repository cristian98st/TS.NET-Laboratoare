using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator
{
    public partial class Form1 : Form
    {
        List<float> numbers = new List<float>();
        List<string> operations = new List<string>();

        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            float number = float.Parse(InputOutput.Text);
            numbers.Add(number);
            operations.Add("+");
            InputOutput.Text = "";
        }

        private void Substraction_Click(object sender, EventArgs e)
        {
            try{
                numbers.Add(float.Parse(InputOutput.Text));
                operations.Add("-");
                InputOutput.Text = "";
            } catch(System.FormatException){
                InputOutput.Text = "";
            }
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            numbers.Add(float.Parse(InputOutput.Text));
            operations.Add("*");
            InputOutput.Text = "";
        }

        private void Division_Click(object sender, EventArgs e)
        {
            numbers.Add(float.Parse(InputOutput.Text));
            operations.Add("/");
            InputOutput.Text = "";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                numbers.Add(float.Parse(InputOutput.Text));
                bool error = false;
                float result = 0;
                if(numbers.Count > 0)
                {
                    result = numbers[0];
                }
                if (operations.Count + 1 != numbers.Count)
                {
                    InputOutput.Text = "";
                    ErrorBox.Text = "Error: Syntax Error";
                }
                else
                {
                    for (int i = 0; i < operations.Count; i++)
                    {
                        switch (operations[i])
                        {
                            case "+":
                                result += numbers[i + 1];
                                break;
                            case "-":
                                result -= numbers[i + 1];
                                break;
                            case "*":
                                result *= numbers[i + 1];
                                break;
                            case "/":
                                result /= numbers[i + 1];
                                break;
                            default:
                                error = true;
                                break;
                        }

                        if(error == true)
                        {
                            InputOutput.Text = "";
                            ErrorBox.Text = "Error: Invalid Operands";
                            break;
                        }
                    }
                    InputOutput.Text = result.ToString("G29");
                    result = 0;
                    numbers.Clear();
                    operations.Clear();
                }
            }
            catch(System.FormatException)
            {
                string input = InputOutput.Text;
                string number = "";
                float result;
                bool stillOperand = false;
                bool hasDot = false;
                bool encounteredError = false;
                for(int i = 0; i < input.Length; i++)
                {
                    string character = Char.ToString(input[i]);
                    if(character == "+" && i == 0)
                    {
                        continue;
                    }
                    else if(character == "-" && i == 0)
                    {
                        numbers.Add(0);
                        operations.Add(character);
                    }
                    else if(character == "+" || character == "-" || character == "*" || character == "/")
                    {
                        if(number.Length > 0){
                            numbers.Add(float.Parse(number));
                            number = "";
                            hasDot = false;
                        }
                        if(i == 0){
                            InputOutput.Text = "";
                            ErrorBox.Text = "Error: Invalid First Character";
                            encounteredError = true;
                            break;
                        } else
                            if(stillOperand == false){
                                operations.Add(character);  
                                stillOperand = true;
                                hasDot = false;
                            }
                    }
                    else if("1234567890".Contains(character))
                    {
                        number += character;
                        stillOperand = false;
                    }
                    else if(character == "." && hasDot == false)
                    {
                        number += character;
                        hasDot = true;
                    } 
                    else if(character == " "){
                        continue;
                    }
                    else {
                        InputOutput.Text = "";
                        ErrorBox.Text = "Error: Syntax Errror";
                        encounteredError = true;
                        break;
                    }
                }

                if(number.Length > 0){
                    numbers.Add(float.Parse(number));
                }

                if (operations.Count + 1 != numbers.Count)
                {
                    InputOutput.Text = "";
                    ErrorBox.Text = "Error";
                }
                else if (!encounteredError)
                {
                    bool error = false;
                    result = numbers[0];
                    for (int i = 0; i < operations.Count; i++)
                    {
                        switch (operations[i])
                        {
                            case "+":
                                result += numbers[i + 1];
                                break;
                            case "-":
                                result -= numbers[i + 1];
                                break;
                            case "*":
                                result *= numbers[i + 1];
                                break;
                            case "/":
                                result /= numbers[i + 1];
                                break;
                            default:
                                error = true;
                                break;
                        }
                    }

                    if(error == true)
                    {
                        InputOutput.Text = "";
                        ErrorBox.Text = "Error";
                    } else {
                        InputOutput.Text = result.ToString("G29");
                    }
                }

                result = 0;
                numbers.Clear();
                operations.Clear();
            }

        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            InputOutput.Text += ".";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputOutput.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputOutput.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputOutput.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InputOutput.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            InputOutput.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InputOutput.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InputOutput.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InputOutput.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            InputOutput.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            InputOutput.Text += "0";
        }

        private void Erase_Click(object sender, EventArgs e)
        {
            try
            {
                InputOutput.Text = InputOutput.Text.Remove(InputOutput.Text.Length - 1);
            }
            catch (System.ArgumentOutOfRangeException)
            {
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            InputOutput.Text = "";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            operations.Clear();
            InputOutput.Text = "";
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    Equal.PerformClick();
                    break;
                default:
                    Debug.WriteLine(e.KeyCode.ToString());
                    ErrorBox.Text = "";
                    break;
            }
        }
    }
}
