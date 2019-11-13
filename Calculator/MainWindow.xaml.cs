using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public decimal number1 = 0;
        public decimal number2 = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        public void numAppend(int btnNum)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + btnNum;
                txtDisplay.Text = number1.ToString();
                
            }
            else
            {
                number2 = (number2 * 10) + btnNum;
                txtDisplay.Text = number2.ToString();
            }
        }

        private void btnClearEntry_Click(object sender, RoutedEventArgs e)
        {
            if (number2 > 0)
            {
                number2 = 0;
                txtDisplay.Text = "0";
            }
            else if (number1 > 0)
            {
                number1 = 0;
                txtDisplay.Text = "0";
            }
            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txtDisplay.Text = $"{number1}";
            labelCurrentOperation.Content = " ";
        }

        private void btnBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                string tempNumber1 = number1.ToString();
                tempNumber1 = tempNumber1.Remove(tempNumber1.Length - 1);
                txtDisplay.Text = tempNumber1;
                number1 = long.Parse(tempNumber1);

            }
            else
            {
                string tempNumber2 = number2.ToString();
                tempNumber2 = tempNumber2.Remove(tempNumber2.Length - 1);
                txtDisplay.Text = tempNumber2;
                number2 = long.Parse(tempNumber2);
            }
            
            
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "+";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            numAppend(7);
            
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            numAppend(8);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            numAppend(9);
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "-";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            numAppend(4);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            numAppend(5);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            numAppend(6);
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "*";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            numAppend(1);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            numAppend(2);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            numAppend(3);
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "/";
        }

        private void btnPositiveNegative_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                number1 *= -1;
                txtDisplay.Text = $"{number1}";
            }
            else
            {
                number2 *= -1;
                txtDisplay.Text = $"{number2}";

            }
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            numAppend(0);

        }

        private void btnDecimal_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                string tempNumber1 = number1.ToString();
                txtDisplay.Text = tempNumber1 + ",";
                number1 = Convert.ToDecimal(tempNumber1);
                

            }
            else
            {
                txtDisplay.Text = number2 + ",";
            }

            
        }

        private void btnEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            
            {
                case "+":
                    {
                        txtDisplay.Text = $"{number1 + number2}";
                        labelCurrentOperation.Content = $"{number1} + {number2}";
                    }
                break;

                case "-":
                    
                        txtDisplay.Text = $"{number1 - number2}";
                        labelCurrentOperation.Content = $"{number1} - {number2}";

                    break;

                case "/":
                    
                        txtDisplay.Text = $"{number1 / number2}";
                        labelCurrentOperation.Content = $"{number1} / {number2}";
                    break;

                case "*": 
                    
                        txtDisplay.Text = $"{number1 * number2}";
                        labelCurrentOperation.Content = $"{number1} * {number2}";

                    break;


                    
            }
        }

        private void txtDisplay_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
