namespace MilesToKilometersGUI
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
            this.topText = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // topText
            // 
            this.topText.AutoSize = true;
            this.topText.Location = new System.Drawing.Point(29, 20);
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(209, 40);
            this.topText.TabIndex = 0;
            this.topText.Text = "How many miles would you\r\nlike to convert to kilometers?";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(33, 102);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(100, 26);
            this.answer.TabIndex = 1;
            this.answer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.topText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topText;
        private System.Windows.Forms.TextBox answer;
    }
}

