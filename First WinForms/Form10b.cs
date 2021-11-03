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
    public partial class Form10b : Form
    {
        public int[] mas = new int[4] { 30, 34, 195, 200 }; // add this line
        public Form10b()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = mas[comboBox1.SelectedIndex].ToString();
            // define the index of the selected value in the drop-down list and display it in the text field
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text.Replace(".", ",")));
            // in this line we calculate the price for the quantity, first replace the input error in the quantity input field (i.e. if the user enters a period instead of a comma, change the period to a comma)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem newItem = listView1.Items.Add(comboBox1.SelectedItem.ToString());
            newItem.SubItems.Add(textBox1.Text);
            newItem.SubItems.Add(textBox2.Text);
            newItem.SubItems.Add(textBox3.Text);
            double r = 0;
            // loop through the entire list and summarize the 4th column
            for (int i = 0; i < listView1.Items.Count; i++){
                ListViewItem lvi = listView1.Items[i];
                r = Convert.ToDouble(lvi.SubItems[3].Text) + r;
            }
            textBox4.Text = r.ToString();

            Clear();
        }

        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
