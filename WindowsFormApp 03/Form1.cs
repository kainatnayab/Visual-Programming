using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1tg5r
{
    public partial class Form1 : Form
    {

        decimal num1 ;
        decimal num2 ;
        string operators = "";
        bool finish = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void All_button_Click(object sender, EventArgs e)
        {
            if (finish == true)
            {
                button21.Text = "";
                finish = false;
            }
            string a = ((Button)sender).Text;
            if (button21.Text.Length <= 10)
            {
                if (!(button21.Text == "0" && a == "0"))
                {
                    button21.Text += ((Button)sender).Text;
                }
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            if(!button21.Text.Contains("0")) 
            button21.Text = ".";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(button21.Text);
            operators = ((Button)sender).Text;
            finish = true;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDecimal(button21.Text);
            decimal r = 0;
            switch (operators)
            {
                case "+":
                r = num1 + num2;
                break;
                case "-":
                r = num1 - num2;
                break;
                case "*": 
                r = num1 * num2;
                break;
                case "/": 
                r = num1 / num2; 
                break;
            }
            button21.Text = r.ToString();

        }

        private void btndelt_Click(object sender, EventArgs e)
        {
            button21.Text = "";
        }

        private void btnrightbracket_Click(object sender, EventArgs e)
        {
            button21.Text = "(";
        }

        private void btnleftbracket_Click(object sender, EventArgs e)
        {
            button21.Text = ")";
        }
    }
  
}