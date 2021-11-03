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
                    case "Ex5a":
                        new Form5a().Show();
                        break;
                    case "Ex5b":
                        new Form5b().Show();
                        break;
                    case "Ex6":
                        new Form6().Show();
                        break;
                    case "Ex7":
                        new Form7().Show();
                        break;
                    case "Ex8a":
                        new Form8a().Show();
                        break;
                    case "Ex8b":
                        new Form8b().Show();
                        break;
                    case "Ex9":
                        new Form9().Show();
                        break;
                    case "Ex10":
                        new Form10().Show();
                        break;
                    case "Ex11":
                        new Form11().Show();
                        break;
                }
            }
            catch (Exception) { }
        }
    }
}
