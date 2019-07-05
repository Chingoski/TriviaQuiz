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
            this.btnNewGame.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNewGame.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnNewGame.Location = new System.Drawing.Point(441, 602);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(108, 40);
            this.btnNewGame.TabIndex = 5;
            this.btnNewGame.Text = "Restart";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            this.btnNewGame.MouseEnter += new System.EventHandler(this.BtnRotate_MouseEnter);
            this.btnNewGame.MouseLeave += new System.EventHandler(this.BtnRotate_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(466, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 30);
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
            this.pictureBox1.Image = global::TriviaQuiz.Properties.Resources.WheelFINAL;
            this.pictureBox1.Location = new System.Drawing.Point(65, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::TriviaQuiz.Properties.Resources.Arrow_right;
            this.pictureBox2.Location = new System.Drawing.Point(12, 321);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnRotate
            // 
            this.btnRotate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRotate.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnRotate.Location = new System.Drawing.Point(60, 602);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(108, 40);
            this.btnRotate.TabIndex = 10;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            this.btnRotate.MouseEnter += new System.EventHandler(this.BtnRotate_MouseEnter);
            this.btnRotate.MouseLeave += new System.EventHandler(this.BtnRotate_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Correct Answers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // lives1
            // 
            this.lives1.BackColor = System.Drawing.Color.Transparent;
            this.lives1.Image = global::TriviaQuiz.Properties.Resources.small_clipart_tiny_17;
            this.lives1.Location = new System.Drawing.Point(465, 39);
            this.lives1.Name = "lives1";
            this.lives1.Size = new System.Drawing.Size(39, 47);
            this.lives1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lives1.TabIndex = 13;
            this.lives1.TabStop = false;
            // 
            // lives3
            // 
            this.lives3.BackColor = System.Drawing.Color.Transparent;
            this.lives3.Image = global::TriviaQuiz.Properties.Resources.small_clipart_tiny_17;
            this.lives3.Location = new System.Drawing.Point(555, 39);
            this.lives3.Name = "lives3";
            this.lives3.Size = new System.Drawing.Size(39, 47);
            this.lives3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lives3.TabIndex = 14;
            this.lives3.TabStop = false;
            // 
            // lives2
            // 
            this.lives2.BackColor = System.Drawing.Color.Transparent;
            this.lives2.Image = global::TriviaQuiz.Properties.Resources.small_clipart_tiny_17;
            this.lives2.Location = new System.Drawing.Point(510, 39);
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
            this.BackgroundImage = global::TriviaQuiz.Properties.Resources.Site_Background;
            this.ClientSize = new System.Drawing.Size(606, 684);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TriviaNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

