using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class kalkulator : Form
    {
        double firstNumber;
        string operation;
       
        public kalkulator()
        {

            InitializeComponent();


        }

       /* private void klawiatura()
        {

            String daneKlawiatura;
            daneKlawiatura = Console.ReadLine();
            textBox1.Text = daneKlawiatura;

        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1 != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = textBox1.Text + "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void przecinek_Click(object sender, EventArgs e)
        {
            string przecinek = ",";
            if (textBox1.Text.Contains(przecinek))
            {
                textBox1.Text = " Za duzo przecinków";

            } else

                textBox1.Text = textBox1.Text + ",";
        }





        private void del_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
                
            }
            else
            {
                textBox1.Text = "0";
               
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void wynik_Click(object sender, EventArgs e)
        {
           
            double secondNumber;                                            
            double result;                                                    

            try
            {
                secondNumber = Convert.ToDouble(textBox1.Text);                     


                if (operation == "+")                                               
                {

                    result = (firstNumber + secondNumber);                          
                    textBox1.Text = Convert.ToString(result);                       
                    firstNumber = result;                                        
                }
                if (operation == "-")
                {
                    result = (firstNumber - secondNumber);
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;
                }
                if (operation == "x")
                {
                    result = (firstNumber * secondNumber);
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;

                }
                if (operation == "/")
                {
                    if (firstNumber == 0 || secondNumber == 0)
                    {
                        textBox1.Text = "Nie dzielimy przez 0";
                            
                    }
                    else
                    {
                        result = (firstNumber / secondNumber);
                        textBox1.Text = Convert.ToString(result);
                        firstNumber = result;
                    }
                }
                if (operation == "%")
                {


                    result = (secondNumber * (firstNumber / 100.0));
                    textBox1.Text = Convert.ToString(result + " %");
                    firstNumber = (result);

                }
                
            }
            catch
            {
                textBox1.Text = "Błędne dane";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            

            
                firstNumber = Convert.ToDouble(textBox1.Text);                      
                textBox1.Text = "0";                                               
                operation = "+";
                
                
            }
            
        
    

        private void minus_Click(object sender, EventArgs e)
        {
            
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "-";
        
        }

        private void pomnoz_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "x";
        }

        private void podziel_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            operation = "/";
               
        }

        private void procent_Click(object sender, EventArgs e)
        {
            
            firstNumber = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = (textBox1.Text + proc);
            textBox1.Text = "0";
            operation = "%";
        }

        private void pierwiastek_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            firstNumber = Math.Sqrt(firstNumber);
            textBox1.Text = Convert.ToString(firstNumber);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            firstNumber = Math.Log10(firstNumber);
            textBox1.Text = Convert.ToString(firstNumber);
        }

        private void kalkulator_Load(object sender, EventArgs e)
        {

        }
    }
}
