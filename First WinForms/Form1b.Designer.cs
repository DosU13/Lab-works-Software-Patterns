
namespace First_WinForms
{
    partial class Form1b
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
            this.Answer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sign = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Answer
            // 
            this.Answer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer.Location = new System.Drawing.Point(50, 651);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(400, 50);
            this.Answer.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 601);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 50);
            this.label3.TabIndex = 19;
            this.label3.Text = "Answer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 50);
            this.label2.TabIndex = 15;
            this.label2.Text = "Second Number";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // SecondNum
            // 
            this.SecondNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondNum.Location = new System.Drawing.Point(41, 251);
            this.SecondNum.Margin = new System.Windows.Forms.Padding(50);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(400, 50);
            this.SecondNum.TabIndex = 14;
            this.SecondNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 50);
            this.label1.TabIndex = 13;
            this.label1.Text = "First Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FirstNum
            // 
            this.FirstNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNum.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNum.Location = new System.Drawing.Point(41, 101);
            this.FirstNum.Margin = new System.Windows.Forms.Padding(50);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(400, 50);
            this.FirstNum.TabIndex = 12;
            this.FirstNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(400, 50);
            this.label4.TabIndex = 22;
            this.label4.Text = "OperationSign";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Sign
            // 
            this.Sign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sign.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sign.Location = new System.Drawing.Point(41, 401);
            this.Sign.Margin = new System.Windows.Forms.Padding(50);
            this.Sign.Name = "Sign";
            this.Sign.Size = new System.Drawing.Size(400, 50);
            this.Sign.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(50, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 50);
            this.button1.TabIndex = 23;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(482, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sign);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecondNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstNum);
            this.Name = "Form1b";
            this.Text = "Form1b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SecondNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Sign;
        private System.Windows.Forms.Button button1;

 
    }
}