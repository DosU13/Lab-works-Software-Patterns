using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_WinForms
{
    public partial class Form1b : Form
    {
        public Form1b()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Sign.Text)
            {
                case "+":
                    answer = first + second;
                    break;
                case "-":
                    answer = first - second;
                    break;
                case "*":
                    answer = first * second;
                    break;
                case "/":
                    answer = first / second;
                    break;
                default:
                    Answer.Text = "Invalid Input";
                    break;
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private double? first
        {
            get
            {
                try
                {
                    return Double.Parse(FirstNum.Text);
                }
                catch (FormatException)
                {
                    return null;
                }
            }
        }
        private double? second
        {
            get
            {
                try
                {
                    return Double.Parse(SecondNum.Text);
                }
                catch (FormatException)
                {
                    return null;
                }
            }
        }
        private double? answer
        {
            set
            {
                if (value != null) Answer.Text = value.ToString();
                else Answer.Text = "Invalid Input";
            }
        }
    }
}
