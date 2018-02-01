namespace TestsInteractiveGUI
{
    partial class Form1
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
            this.enterEggs = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterEggs
            // 
            this.enterEggs.AutoSize = true;
            this.enterEggs.Location = new System.Drawing.Point(13, 13);
            this.enterEggs.Name = "enterEggs";
            this.enterEggs.Size = new System.Drawing.Size(189, 40);
            this.enterEggs.TabIndex = 0;
            this.enterEggs.Text = "Enter scores for five tests\r\n you\'ve taken";
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(17, 53);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 26);
            this.t1.TabIndex = 1;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(123, 53);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 26);
            this.t2.TabIndex = 2;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(17, 86);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(100, 26);
            this.t3.TabIndex = 3;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(123, 86);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(100, 26);
            this.t4.TabIndex = 4;
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(17, 119);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(100, 26);
            this.t5.TabIndex = 5;
            this.t5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Click to Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(13, 197);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 20);
            this.answer.TabIndex = 7;
            this.answer.Visible = false;
            this.answer.Click += new System.EventHandler(this.answer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.enterEggs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterEggs;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label answer;
    }
}

