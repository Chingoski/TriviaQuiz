namespace TriviaQuiz
{
    partial class TriviaHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriviaHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = global::TriviaQuiz.Properties.Resources.trivia_quiz_logo;
            this.pictureBox1.Location = new System.Drawing.Point(115, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewGame.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnNewGame.Location = new System.Drawing.Point(235, 284);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(169, 41);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            this.btnNewGame.MouseEnter += new System.EventHandler(this.BtnInstructions_MouseEnter);
            this.btnNewGame.MouseLeave += new System.EventHandler(this.BtnInstructions_MouseLeave);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInstructions.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnInstructions.Location = new System.Drawing.Point(21, 284);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(169, 41);
            this.btnInstructions.TabIndex = 2;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.BtnInstructions_Click);
            this.btnInstructions.MouseEnter += new System.EventHandler(this.BtnInstructions_MouseEnter);
            this.btnInstructions.MouseLeave += new System.EventHandler(this.BtnInstructions_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnExit.Location = new System.Drawing.Point(152, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 52);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.BtnInstructions_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.BtnInstructions_MouseLeave);
            // 
            // TriviaHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(429, 441);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TriviaHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trivia Quiz";
            this.Load += new System.EventHandler(this.TriviaHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnExit;
    }
}