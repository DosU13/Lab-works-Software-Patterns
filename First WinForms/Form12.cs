﻿using System;
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
    public partial class Form12 : Form
    {
        DataTable table;
        private BindingSource bindingSource = new BindingSource();

        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Ivanov", "Peter", 12);
            dataGridView1.Rows.Add("Abdylbaev", "Ruslan", 12);
            dataGridView1.Rows.Add("Ruslanova", "Zarina", 12);
            dataGridView1.Rows.Add("Igorov", "Peter", 12);
            dataGridView1.Rows.Add("Ivanov", "Sergey", 12);
        }
    }
}
