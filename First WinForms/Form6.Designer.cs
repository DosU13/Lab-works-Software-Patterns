
namespace First_WinForms
{
    partial class Form6
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(403, 404);
            this.listBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(435, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "value";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // valueBox
            // 
            this.valueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.valueBox.Location = new System.Drawing.Point(443, 72);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(345, 41);
            this.valueBox.TabIndex = 2;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.add.Location = new System.Drawing.Point(443, 151);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(345, 70);
            this.add.TabIndex = 3;
            this.add.Text = "add value";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.remove.Location = new System.Drawing.Point(443, 240);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(345, 70);
            this.remove.TabIndex = 4;
            this.remove.Text = "remove value";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.clear.Location = new System.Drawing.Point(443, 331);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(345, 70);
            this.clear.TabIndex = 5;
            this.clear.Text = "clear list";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button clear;
    }
}