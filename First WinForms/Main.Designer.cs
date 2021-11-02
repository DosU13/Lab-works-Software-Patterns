
namespace First_WinForms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Exercise 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Exercise 2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Lab 1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Lab 2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Lab 3");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Lab 4");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("TextBox");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("RichTextBox");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Lab 5", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Lab 6");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Lab 7");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("RadioButton CheckBox ChecklistBox");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("ChecklistBox");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Lab 8", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Ex1a";
            treeNode1.Text = "Exercise 1";
            treeNode2.Name = "Ex1b";
            treeNode2.Text = "Exercise 2";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Lab 1";
            treeNode4.Name = "Ex2";
            treeNode4.Text = "Lab 2";
            treeNode5.Name = "Ex3";
            treeNode5.Text = "Lab 3";
            treeNode6.Name = "Ex4";
            treeNode6.Text = "Lab 4";
            treeNode7.Name = "Ex5a";
            treeNode7.Text = "TextBox";
            treeNode8.Name = "Ex5b";
            treeNode8.Text = "RichTextBox";
            treeNode9.Name = "Ex5";
            treeNode9.Text = "Lab 5";
            treeNode10.Name = "Ex6";
            treeNode10.Text = "Lab 6";
            treeNode11.Name = "Ex7";
            treeNode11.Text = "Lab 7";
            treeNode12.Name = "Ex8a";
            treeNode12.Text = "RadioButton CheckBox ChecklistBox";
            treeNode13.Name = "Ex8b";
            treeNode13.Text = "ChecklistBox";
            treeNode14.Name = "Node0";
            treeNode14.Text = "Lab 8";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode14});
            this.treeView1.Size = new System.Drawing.Size(776, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_AfterSelect);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Main";
            this.Text = "Doslan\'s Labs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}