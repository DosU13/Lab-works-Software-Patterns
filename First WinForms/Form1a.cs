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
    public partial class Form1a : Form
    {
        public Form1a()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-')) {
                e.Handled = true;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            answer = first + second;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            answer = first - second;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            answer = first * second;
        }
        private void divide_Click(object sender, EventArgs e)
        {
            answer = first / second;
        }

        private double? first
        {
            get
            {
                try
                {
                    return Double.Parse(FirstNum.Text);
                } catch (FormatException)
                {
                    return null;
                }
            }
        }
        private double? second 
        {
            get {
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
            set {
                if (value != null) Answer.Text = value.ToString();
                else Answer.Text = "Invalid Input";
            }
        }

        private void first_TextChange(object sender, EventArgs e)
        {

        }

        private void second_TextChange(object sender, EventArgs e)
        {

        }
    }

}
