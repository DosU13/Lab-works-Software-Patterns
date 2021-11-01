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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click (object sender, EventArgs e)
        {
            MessageBox.Show ("Dialog box with a line");
        }

         private void button2_Click (object sender, EventArgs e)
        {
            MessageBox.Show ("Dialog box with line", "Line Title");
            // the first parameter specifies the dialog box text, the second parameter specifies the title text
        }

        private void button3_Click (object sender, EventArgs e)
        {
            MessageBox.Show ("Dialog box with a string and different buttons", "Title string", MessageBoxButtons.OKCancel);
            MessageBox.Show ("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.AbortRetryIgnore);
            MessageBox.Show ("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.OK);
            // MessageBoxButtons determines which buttons will be located on the dialog box
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dialog box with a line and different buttons", "Title bar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MessageBox.Show("Dialog box with a line and different buttons", "Title line", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save data", "Attention!", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
                MessageBox.Show("Data saved");
            if (result == DialogResult.No)
                MessageBox.Show("Data not saved");
            if (result == DialogResult.Cancel)
                MessageBox.Show("Saving data canceled by the user");
        }

    }
}
