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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(value);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(value);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private string value
        {
            get
            {
                return valueBox.Text;
            }
        }
    }
}
