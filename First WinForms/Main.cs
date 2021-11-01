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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tree_AfterSelect(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                switch (e.Node.Name)
                {
                    case "Ex1a": 
                        new Form1a().Show();
                        break;
                    case "Ex1b":
                        new Form1b().Show();
                        break;
                    case "Ex2":
                        new Form2().Show();
                        break;
                    case "Ex3":
                        new Form3().Show();
                        break;
                    case "Ex4":
                        new Form4().Show();
                        break;
                }
            }
            catch (Exception) { }
        }
    }
}
