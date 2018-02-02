namespace EggsInteractiveGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.c1Answer = new System.Windows.Forms.TextBox();
            this.c2Answer = new System.Windows.Forms.TextBox();
            this.c4Answer = new System.Windows.Forms.TextBox();
            this.c5Answer = new System.Windows.Forms.TextBox();
            this.c3Answer = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Eggs produced by each \r\nof 5 chickens";
            // 
            // c1Answer
            // 
            this.c1Answer.Location = new System.Drawing.Point(31, 53);
            this.c1Answer.Name = "c1Answer";
            this.c1Answer.Size = new System.Drawing.Size(60, 26);
            this.c1Answer.TabIndex = 1;
            this.c1Answer.TextChanged += new System.EventHandler(this.c1Answer_TextChanged);
            // 
            // c2Answer
            // 
            this.c2Answer.Location = new System.Drawing.Point(111, 52);
            this.c2Answer.Name = "c2Answer";
            this.c2Answer.Size = new System.Drawing.Size(60, 26);
            this.c2Answer.TabIndex = 2;
            // 
            // c4Answer
            // 
            this.c4Answer.Location = new System.Drawing.Point(31, 97);
            this.c4Answer.Name = "c4Answer";
            this.c4Answer.Size = new System.Drawing.Size(60, 26);
            this.c4Answer.TabIndex = 3;
            // 
            // c5Answer
            // 
            this.c5Answer.Location = new System.Drawing.Point(111, 96);
            this.c5Answer.Name = "c5Answer";
            this.c5Answer.Size = new System.Drawing.Size(60, 26);
            this.c5Answer.TabIndex = 4;
            // 
            // c3Answer
            // 
            this.c3Answer.Location = new System.Drawing.Point(190, 53);
            this.c3Answer.Name = "c3Answer";
            this.c3Answer.Size = new System.Drawing.Size(60, 26);
            this.c3Answer.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(96, 142);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 30);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Click to Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 60);
            this.label2.TabIndex = 7;
            this.label2.Text = "You would have an answer here\r\n if you had entered your values, \r\nbut you haven\'t" +
    " so... yeah";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.c3Answer);
            this.Controls.Add(this.c5Answer);
            this.Controls.Add(this.c4Answer);
            this.Controls.Add(this.c2Answer);
            this.Controls.Add(this.c1Answer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox c1Answer;
        private System.Windows.Forms.TextBox c2Answer;
        private System.Windows.Forms.TextBox c4Answer;
        private System.Windows.Forms.TextBox c5Answer;
        private System.Windows.Forms.TextBox c3Answer;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label2;
    }
}

