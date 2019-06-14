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
            this.Answer3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Answer2 = new System.Windows.Forms.Button();
            this.Answer4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Answer1
            // 
            this.Answer1.BackColor = System.Drawing.Color.Transparent;
            this.Answer1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Answer1.Image = global::TriviaQuiz.Properties.Resources.board;
            this.Answer1.Location = new System.Drawing.Point(36, 292);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(141, 70);
            this.Answer1.TabIndex = 0;
            this.Answer1.Text = "button1";
            this.Answer1.UseVisualStyleBackColor = false;
            this.Answer1.Click += new System.EventHandler(this.Answer1_Click);
            this.Answer1.MouseEnter += new System.EventHandler(this.Answer4_MouseEnter);
            this.Answer1.MouseLeave += new System.EventHandler(this.Answer4_MouseLeave);
            // 
            // Answer3
            // 
            this.Answer3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Answer3.Image = global::TriviaQuiz.Properties.Resources.board;
            this.Answer3.Location = new System.Drawing.Point(36, 406);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(141, 70);
            this.Answer3.TabIndex = 2;
            this.Answer3.Text = "button3";
            this.Answer3.UseVisualStyleBackColor = true;
            this.Answer3.Click += new System.EventHandler(this.Answer3_Click);
            this.Answer3.MouseEnter += new System.EventHandler(this.Answer4_MouseEnter);
            this.Answer3.MouseLeave += new System.EventHandler(this.Answer4_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::TriviaQuiz.Properties.Resources.board;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 260);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Answer2
            // 
            this.Answer2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Answer2.Image = global::TriviaQuiz.Properties.Resources.board;
            this.Answer2.Location = new System.Drawing.Point(298, 292);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(141, 70);
            this.Answer2.TabIndex = 1;
            this.Answer2.Text = "button2";
            this.Answer2.UseVisualStyleBackColor = true;
            this.Answer2.Click += new System.EventHandler(this.Answer2_Click);
            this.Answer2.MouseEnter += new System.EventHandler(this.Answer4_MouseEnter);
            this.Answer2.MouseLeave += new System.EventHandler(this.Answer4_MouseLeave);
            // 
            // Answer4
            // 
            this.Answer4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Answer4.Image = global::TriviaQuiz.Properties.Resources.board;
            this.Answer4.Location = new System.Drawing.Point(298, 406);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(141, 70);
            this.Answer4.TabIndex = 3;
            this.Answer4.Text = "button4";
            this.Answer4.UseVisualStyleBackColor = true;
            this.Answer4.Click += new System.EventHandler(this.Answer4_Click);
            this.Answer4.MouseEnter += new System.EventHandler(this.Answer4_MouseEnter);
            this.Answer4.MouseLeave += new System.EventHandler(this.Answer4_MouseLeave);
            // 
            // TriviaAnwserQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 529);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
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

        }

        #endregion

        private System.Windows.Forms.Button Answer1;
        private System.Windows.Forms.Button Answer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Answer2;
        private System.Windows.Forms.Button Answer4;
    }
}