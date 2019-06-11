namespace TriviaQuiz
{
    partial class TriviaNewGame
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
            this.components = new System.ComponentModel.Container();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timerRotate = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRotate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lives1 = new System.Windows.Forms.PictureBox();
            this.lives3 = new System.Windows.Forms.PictureBox();
            this.lives2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lives1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lives3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lives2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(443, 537);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(102, 40);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lives:";
            // 
            // timerRotate
            // 
            this.timerRotate.Interval = 50;
            this.timerRotate.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TriviaQuiz.Properties.Resources.Webp_net_resizeimage;
            this.pictureBox1.Location = new System.Drawing.Point(143, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TriviaQuiz.Properties.Resources.Arrow_right;
            this.pictureBox2.Location = new System.Drawing.Point(70, 248);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(205, 537);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(108, 40);
            this.btnRotate.TabIndex = 10;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Points:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // lives1
            // 
            this.lives1.Image = global::TriviaQuiz.Properties.Resources.small_clipart_tiny_17;
            this.lives1.Location = new System.Drawing.Point(8, 31);
            this.lives1.Name = "lives1";
            this.lives1.Size = new System.Drawing.Size(39, 47);
            this.lives1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lives1.TabIndex = 13;
            this.lives1.TabStop = false;
            // 
            // lives3
            // 
            this.lives3.Image = global::TriviaQuiz.Properties.Resources.small_clipart_tiny_17;
            this.lives3.Location = new System.Drawing.Point(98, 31);
            this.lives3.Name = "lives3";
            this.lives3.Size = new System.Drawing.Size(39, 47);
            this.lives3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lives3.TabIndex = 14;
            this.lives3.TabStop = false;
            // 
            // lives2
            // 
            this.lives2.Image = global::TriviaQuiz.Properties.Resources.small_clipart_tiny_17;
            this.lives2.Location = new System.Drawing.Point(53, 31);
            this.lives2.Name = "lives2";
            this.lives2.Size = new System.Drawing.Size(39, 47);
            this.lives2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lives2.TabIndex = 15;
            this.lives2.TabStop = false;
            // 
            // TriviaNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 594);
            this.Controls.Add(this.lives2);
            this.Controls.Add(this.lives3);
            this.Controls.Add(this.lives1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNewGame);
            this.Name = "TriviaNewGame";
            this.Text = "Trivia Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lives1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lives3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lives2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerRotate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox lives1;
        private System.Windows.Forms.PictureBox lives3;
        private System.Windows.Forms.PictureBox lives2;
    }
}

