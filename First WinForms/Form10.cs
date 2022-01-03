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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form10a child = new Form10a();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10a child = new Form10a();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;

            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10a child = new Form10a();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;

            LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10a child = new Form10a();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;

            LayoutMdi(MdiLayout.TileVertical);
        }

        private void calculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CloseChild (); // call to close the previously created windows
            Form10b child = new Form10b();
            child.MdiParent = this;
            child.Icon = this.Icon;
            child.Show();
            child = null;
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseChild()
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}
