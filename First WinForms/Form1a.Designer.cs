
namespace First_WinForms
{
    partial class Form1a
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
            this.plus = new System.Windows.Forms.Button();
            this.FirstNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondNum = new System.Windows.Forms.TextBox();
            this.divide = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(50, 350);
            this.plus.Margin = new System.Windows.Forms.Padding(0);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(68, 68);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // FirstNum
            // 
            this.FirstNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNum.Location = new System.Drawing.Point(50, 100);
            this.FirstNum.Margin = new System.Windows.Forms.Padding(50);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(400, 50);
            this.FirstNum.TabIndex = 1;
            this.FirstNum.TextChanged += new System.EventHandler(this.first_TextChange);
            this.FirstNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Second Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SecondNum
            // 
            this.SecondNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNum.Location = new System.Drawing.Point(50, 250);
            this.SecondNum.Margin = new System.Windows.Forms.Padding(50);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(400, 50);
            this.SecondNum.TabIndex = 3;
            this.SecondNum.TextChanged += new System.EventHandler(this.second_TextChange);
            this.SecondNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.divide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(382, 350);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(68, 68);
            this.divide.TabIndex = 5;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(160, 350);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(68, 68);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(271, 350);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(68, 68);
            this.multiply.TabIndex = 7;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 50);
            this.label3.TabIndex = 9;
            this.label3.Text = "Answer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Answer
            // 
            this.Answer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.Location = new System.Drawing.Point(50, 518);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(400, 50);
            this.Answer.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(482, 621);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecondNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNum);
            this.Controls.Add(this.plus);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.TextBox FirstNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SecondNum;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Answer;
    }
}

