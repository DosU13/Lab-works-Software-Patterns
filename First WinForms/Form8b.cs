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
    public partial class Form8b : Form
    {
        public Form8b()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            string[] sArayItems = {"Excellent", "Good", "Satisfactory", "Unsatisfactory"};
            checkedListBox1.Items.Clear();
            for (int i = 0; i < sArayItems.GetLength(0); i++)
            {
                checkedListBox1.Items.Add(sArayItems[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(int index in checkedListBox1.CheckedIndices)
            {
                MessageBox.Show(index.ToString() + "Value" + checkedListBox1.Items[index].ToString());
            }
        }

            private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                MessageBox.Show("Value" + checkedListBox1.Items[i].ToString() + "State is" + checkedListBox1.GetItemCheckState(i).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int index = checkedListBox1.CheckedIndices.Count-1; index >=0; index--)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.CheckedIndices[index]);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = checkedListBox1.Items.IndexOf("Good");
            if (index == -1)
            {
                MessageBox.Show("There is no checkBox woth name \"Good\" ");
                return;
            }
            if (checkedListBox1.GetItemCheckState(index) == CheckState.Checked)
                MessageBox.Show("Value Selection \"Good\" Selected");
            else
                MessageBox.Show("Value Selection \"Good\" Not Selected");
        }
    }
}
