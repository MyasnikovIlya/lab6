using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_TRPO
{
    public partial class Form1 : Form
    {
        public string operation;
        public string firstNumber;
        public bool secondNumber;
        public bool secondOperator = false ;
        public bool dotPressed;
        public double doubleN1, doubleN2, result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBoxFocused(object sender, EventArgs e)
        {
            resultButton.Focus();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            secondNumber = false;
            secondOperator = false;
            dotPressed = false;
        }

        private void opButton_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            if (secondOperator)
            {
                doubleN1 = Convert.ToDouble(firstNumber);
                doubleN2 = Convert.ToDouble(richTextBox1.Text);
                if (operation == "+")
                {
                    result = doubleN1 + doubleN2;
                }
                if (operation == "-")
                {
                    result = doubleN1 - doubleN2;
                }
                if (operation == "*")
                {
                    result = doubleN1 * doubleN2;
                }
                if (operation == "/")
                {
                    result = doubleN1 / doubleN2;
                }
                richTextBox1.Text = Convert.ToString(result); 
                firstNumber = Convert.ToString(result);
                Clipboard.SetText(firstNumber);
            }
            else
                firstNumber = richTextBox1.Text;
            secondNumber = true;
            if (!secondOperator)
                secondOperator = true;
            operation = B.Text;

        }

        private void resultButton_Click(object sender, EventArgs e)
        {

            doubleN1 = Convert.ToDouble(firstNumber);
            doubleN2 = Convert.ToDouble(richTextBox1.Text);
            if (operation == "+")
            {
                result = doubleN1 + doubleN2;
            }
            if (operation == "-")
            {
                result = doubleN1 - doubleN2;
            }
            if (operation == "*")
            {
                result = doubleN1 * doubleN2;
            }
            if (operation == "/")
            {
                result = doubleN1 / doubleN2;
            }
            //if (ifSecondNumber)
            operation = "=";
            secondNumber = true;
            richTextBox1.Text = Convert.ToString(result);
            Clipboard.SetText(Convert.ToString(result));
            secondOperator = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.KeyPreview = true;
        }
        private void b_Click(object sender, EventArgs e)
        {
            if (secondNumber)
            {
                secondNumber = false;
                if (dotPressed)
                {
                    richTextBox1.Text = "0,";
                }
                else
                    richTextBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = B.Text;
            }
            else
                richTextBox1.Text = richTextBox1.Text + B.Text;
            dotPressed = false;
        }

        private void dotButton_Click_1(object sender, EventArgs e)
        {
            dotPressed = true;
            if (secondNumber)
                richTextBox1.Text = "0,";
            else if (!richTextBox1.Text.Contains(",") && !secondNumber)
                richTextBox1.Text = richTextBox1.Text + ",";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Back)
                clearButton.PerformClick();
            if (e.KeyValue == (char)Keys.Enter)
                resultButton.PerformClick();
            if (e.KeyValue == (char)Keys.D1)
                b1.PerformClick();
            if (e.KeyValue == (char)Keys.D2)
                b2.PerformClick();
            if (e.KeyValue == (char)Keys.D3)
                b3.PerformClick();
            if (e.KeyValue == (char)Keys.D4)
                b4.PerformClick();
            if (e.KeyValue == (char)Keys.D5)
                b5.PerformClick();
            if (e.KeyValue == (char)Keys.D6)
                b6.PerformClick();
            if (e.KeyValue == (char)Keys.D7)
                b7.PerformClick();
            if (e.KeyValue == (char)Keys.D8)
                b8.PerformClick();
            if (e.KeyValue == (char)Keys.D9)
                b9.PerformClick();
            if (e.KeyValue == (char)Keys.D0)
                b0.PerformClick();
            if (e.KeyValue == (char)Keys.Oemplus)
                plusButton.PerformClick();
            if (e.KeyValue == (char)Keys.Divide)
                divButton.PerformClick();
            if (e.KeyValue == (char)Keys.Multiply)
                multiplyButton.PerformClick();
            if (e.KeyValue == (char)Keys.OemMinus)
                minusButton.PerformClick();
            if (e.KeyValue == (char)Keys.C)
                clearButton.PerformClick();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
