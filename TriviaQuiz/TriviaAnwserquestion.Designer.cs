namespace TriviaQuiz
{
    partial class TriviaAnwserQuestion
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
            this.Answer1 = new System.Windows.Forms.Button();
            this.Answer2 = new System.Windows.Forms.Button();
            this.Answer3 = new System.Windows.Forms.Button();
            this.Answer4 = new System.Windows.Forms.Button();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Answer1
            // 
            this.Answer1.Location = new System.Drawing.Point(36, 294);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(141, 70);
            this.Answer1.TabIndex = 0;
            this.Answer1.Text = "button1";
            this.Answer1.UseVisualStyleBackColor = true;
            this.Answer1.Click += new System.EventHandler(this.Answer1_Click);
            // 
            // Answer2
            // 
            this.Answer2.Location = new System.Drawing.Point(275, 294);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(141, 70);
            this.Answer2.TabIndex = 1;
            this.Answer2.Text = "button2";
            this.Answer2.UseVisualStyleBackColor = true;
            this.Answer2.Click += new System.EventHandler(this.Answer2_Click);
            // 
            // Answer3
            // 
            this.Answer3.Location = new System.Drawing.Point(36, 423);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(141, 70);
            this.Answer3.TabIndex = 2;
            this.Answer3.Text = "button3";
            this.Answer3.UseVisualStyleBackColor = true;
            this.Answer3.Click += new System.EventHandler(this.Answer3_Click);
            // 
            // Answer4
            // 
            this.Answer4.Location = new System.Drawing.Point(275, 423);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(141, 70);
            this.Answer4.TabIndex = 3;
            this.Answer4.Text = "button4";
            this.Answer4.UseVisualStyleBackColor = true;
            this.Answer4.Click += new System.EventHandler(this.Answer4_Click);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(36, 96);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(380, 113);
            this.tbQuestion.TabIndex = 4;
            // 
            // TriviaAnwserQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 529);
            this.ControlBox = false;
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TriviaAnwserQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trivia Quiz";
            this.Load += new System.EventHandler(this.TriviaAnwserQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Answer1;
        private System.Windows.Forms.Button Answer2;
        private System.Windows.Forms.Button Answer3;
        private System.Windows.Forms.Button Answer4;
        private System.Windows.Forms.TextBox tbQuestion;
    }
}