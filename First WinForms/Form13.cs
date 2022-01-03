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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            LoadData(index);
        }

        int[] correct = { 2, 1, 1, 1, 2 }; // array with correct answers
        string[] s = {" C # this? ", // an array with the questions
            " What is an int? ",
            " What is the foreach operator responsible for? ",
            " How does the conditional if statement work? ",
            " How does an int differ from a short data type? "};
        string[,] value = {// array with answers to the question
            {"Program for editing text", "Programming language", "DBMS", "This is the name of the processor"},
            {"Data type", "Programming language", " loop operator "," condition operator "},
            {" This operator is a loop that is specially created for a collection "," Programming language "," Data type responsible for integers "," This operator is erroneous "},
            {" one of branches "," is executed in a loop "," cc "," cc "},
            {" Program4 "," By the size of allocated memory "," cc "," cc "}
        };
        int index = 1;
        int result = 0;

        void LoadData(int index) // the function loads data from arrays by index
        {
            if (index >= s.Length) return; // check for going beyond the index
            else
            {
                groupBox1.Text = s[index];
                radioButton1.Text = value[index, 0];
                radioButton2.Text = value[index, 1];
                radioButton3.Text = value[index, 2];
                radioButton4.Text = value[index, 3];
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
            }
        }

        private void UpdateControls()
        {
            if (!radioButton1.Checked && !radioButton2.Checked &&
                !radioButton3.Checked && !radioButton4.Checked)
            {
                button2.Enabled = false;
            }
            else button2.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            LoadData(index);
        }
    }
}
