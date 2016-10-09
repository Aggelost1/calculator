using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }


        double bufferactive = 0;
        double bufferpassive = 0;
        double memory = 0;
        double result = 0;
        string indicate = null;
       
//this is here so I can have a second form to use for the scientific calculator
        Form2 scientificForm = new Form2();
       private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //this line was from when i wanted to make it pop up an extra form with scientific buttons 
            //(in the end i desided i will not learn anything new from that  so i let it be) so go to wolfram and dont complain :P

            /* scientificForm.Visible = checkBox1.Checked; */
            if (checkBox1.Checked == true) { System.Diagnostics.Process.Start("http://www.wolframalpha.com"); } 
        }
        // Block that constricts my text box to take only numbers (still need to fix the copy paste case)
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                MessageBox.Show("you have not input a number");
                e.Handled = true;
            }
           

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        
       
//number buttons 0 through 9 just append the number at the end of the string on press
        private void seven_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = a + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = a + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = a + "9";
        }

        private void four_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = a + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = a + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = a + "6";
        }

        private void one_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = a + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = a + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = a + "3";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = a + "0";
        }
        //number buttons end
//the decimal button
        private void deciml_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            textBox1.Text = a + ".";
        }
//math operation  buttons start
        // minus button
        private void minus_Click(object sender, EventArgs e)
        {
            indicate = "-";
            bufferpassive = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text + " - " ;
            textBox1.Text = null;
        }
        //divition button
        private void over_Click(object sender, EventArgs e)
        {
            indicate = "/";
            bufferpassive = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text + " / ";
            textBox1.Text = null;
        }
        //multiply button
        private void times_Click(object sender, EventArgs e)
        {
            indicate = "*";
            bufferpassive = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text + " * ";
            textBox1.Text = null;
        }
        //add button
        private void plus_Click(object sender, EventArgs e)
        {
            indicate = "+";
            bufferpassive = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text + " + ";
            textBox1.Text = null;
        }
//buttons that dont use the '=' button
        //a number to the power of another i.e. x^y 
        private void presentage_Click(object sender, EventArgs e)
        {
            indicate = "^";
            bufferpassive = Convert.ToDouble(textBox1.Text);
            textBox2.Text = textBox1.Text + " ^ ";
            textBox1.Text = null;
        }
        
        //square root button
        private void sqrt_Click(object sender, EventArgs e)
        {
            double textbox1Todouble = Convert.ToDouble(textBox1.Text);
            double c = Math.Pow(textbox1Todouble, 0.5);
            textBox1.Text = c.ToString();

        }
        //the one over button i.e 1/x
        private void oneoverx_Click(object sender, EventArgs e)
        {
            double textbox1Todouble = Convert.ToDouble(textBox1.Text);
            double c = 1/ textbox1Todouble;
            textBox1.Text = c.ToString();
        }
        
//the equals button
        private void equals_Click(object sender, EventArgs e)
        {
            if (indicate == null)
            {
                return;
            }
            if (textBox1.Text.Length == 0) { textBox1.Text = "0"; }            
            
                double textbox1Todouble = Convert.ToDouble(textBox1.Text);

            if (textBox2.Text.Length != 0)
            {
                bufferactive = textbox1Todouble;
            }
            if (textBox2.Text.Length == 0)
            {
                bufferpassive = textbox1Todouble;
            }
            result = operation (bufferpassive, bufferactive);

           

            textBox2.Text = null;
            textBox1.Text = result.ToString();
        }
 //memory buttons
        //memory store, stores the number that is on the text box in the memory
        private void memstore_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                
                    double textbox1Todouble = Convert.ToDouble(textBox1.Text);
                    memory = textbox1Todouble;
                
            }
        }
        //clears the value stored in the memory
        private void memclear_Click(object sender, EventArgs e)
        {
            memory = 0;
        }
        //puts the value that is in the memory on the textbox
        private void memrecal_Click(object sender, EventArgs e)
        {
           
                textBox1.Text = memory.ToString();
            
        }
        //adds the value that is on the screen to the memory value
        private void memplus_Click(object sender, EventArgs e)
        {
            
                double textbox1Todouble = Convert.ToDouble(textBox1.Text);
                memory = memory + textbox1Todouble;
            
        }
        //subtracts the value that is on the screen to the memory value
        private void memminus_Click(object sender, EventArgs e)
        {
            
                double textbox1Todouble = Convert.ToDouble(textBox1.Text);
                memory = memory - textbox1Todouble;
            
        }
// determines the operation we do i.e. divede, substract ,multiply e.t.c.
        public double operation (double a , double b)
        {
            if (indicate == "-")
            {
                double c = a - b;
                return c;
            }
            if (indicate == "+")
            {
                double c = a + b;
                return c;
            }
            if (indicate == "*")
            {
                double c = a * b;
                return c;
            }
            if (indicate == "/")
            {
                double c = a / b;
                return c;
            }

            if (indicate == "^")
            {
                double c = Math.Pow(a,b);
                return c;
            }
            return 0;

        }
//clear buttons
        // clear all , clears all memory and textboxs
        private void clearlall_Click(object sender, EventArgs e)
        {
            bufferactive = 0;
            bufferpassive = 0;
            memory = 0;
            result = 0;
            indicate = null;
            textBox1.Text = null;
            textBox2.Text = null;
        }
        // backspase just clears last digit from your textbox
        private void backspace_Click(object sender, EventArgs e)
        {
            int maxlength = textBox1.Text.Length;
            if (maxlength > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, maxlength - 1);
            }
        }

//sign , it changes the sign of ur displayed number
        private void sgn_Click(object sender, EventArgs e)
        {
            
                double textbox1Todouble = Convert.ToDouble(textBox1.Text);
                textBox1.Text = (-textbox1Todouble).ToString();

            
        }
//catches the problems with non convertable (to double) strings
        private void nullcase(object sender, EventArgs e)
        {
            double tirying;
            if (textBox1.Text.Length == 0) { textBox1.Text = "0"; }
            try
            {
                tirying = System.Convert.ToDouble(textBox1.Text);
                
            }
            catch (System.OverflowException)
            {
                MessageBox.Show(  "Conversion from string-to-double overflowed. You possibly used too many digits ");
                  textBox1.Text = "0";
            }
            catch (System.FormatException)
            {
                MessageBox.Show("you have not input a number. You possibly have characters that are not allowed and have used copy paste to insert them");
                textBox1.Text = "0";
            }
            // this should be irrelevant, it catches the null case but i dont allow it
            catch (System.ArgumentException)
            {
                System.Console.WriteLine(
                    "The string pointed to null.");
            }
        }
    }
}
