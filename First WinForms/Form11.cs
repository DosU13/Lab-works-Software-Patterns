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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label5.Text = "current product " + safeToString(dataGridView1[0, dataGridView1.CurrentRow.Index].Value) +
                " at the price " + safeToString(dataGridView1[1, dataGridView1.CurrentRow.Index].Value) + " available " + safeToString(dataGridView1[2, dataGridView1.CurrentRow.Index].Value);
            
        }

        private string safeToString(object o)
        {
            if (o == null) return "null";
            else return o.ToString();
        }

    }
}
