namespace TriviaQuiz
{
    partial class Joker
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
            this.btnGeography = new System.Windows.Forms.Button();
            this.btnScience = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.btnPopCulture = new System.Windows.Forms.Button();
            this.btnSport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGeography
            // 
            this.btnGeography.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeography.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGeography.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnGeography.Location = new System.Drawing.Point(12, 31);
            this.btnGeography.Name = "btnGeography";
            this.btnGeography.Size = new System.Drawing.Size(233, 72);
            this.btnGeography.TabIndex = 0;
            this.btnGeography.Text = "Geography";
            this.btnGeography.UseVisualStyleBackColor = true;
            this.btnGeography.Click += new System.EventHandler(this.BtnGeography_Click);
            this.btnGeography.MouseEnter += new System.EventHandler(this.BtnGeography_MouseEnter);
            this.btnGeography.MouseLeave += new System.EventHandler(this.BtnGeography_MouseLeave);
            // 
            // btnScience
            // 
            this.btnScience.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScience.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnScience.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnScience.Location = new System.Drawing.Point(270, 31);
            this.btnScience.Name = "btnScience";
            this.btnScience.Size = new System.Drawing.Size(233, 72);
            this.btnScience.TabIndex = 1;
            this.btnScience.Text = "Science";
            this.btnScience.UseVisualStyleBackColor = true;
            this.btnScience.Click += new System.EventHandler(this.BtnScience_Click);
            this.btnScience.MouseEnter += new System.EventHandler(this.BtnGeography_MouseEnter);
            this.btnScience.MouseLeave += new System.EventHandler(this.BtnGeography_MouseLeave);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHistory.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnHistory.Location = new System.Drawing.Point(394, 152);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(233, 72);
            this.btnHistory.TabIndex = 2;
            this.btnHistory.Text = "Computer Science";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            this.btnHistory.MouseEnter += new System.EventHandler(this.BtnGeography_MouseEnter);
            this.btnHistory.MouseLeave += new System.EventHandler(this.BtnGeography_MouseLeave);
            // 
            // btnPopCulture
            // 
            this.btnPopCulture.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopCulture.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPopCulture.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnPopCulture.Location = new System.Drawing.Point(90, 152);
            this.btnPopCulture.Name = "btnPopCulture";
            this.btnPopCulture.Size = new System.Drawing.Size(233, 72);
            this.btnPopCulture.TabIndex = 3;
            this.btnPopCulture.Text = "Pop Culture";
            this.btnPopCulture.UseVisualStyleBackColor = true;
            this.btnPopCulture.Click += new System.EventHandler(this.BtnPopCulture_Click);
            this.btnPopCulture.MouseEnter += new System.EventHandler(this.BtnGeography_MouseEnter);
            this.btnPopCulture.MouseLeave += new System.EventHandler(this.BtnGeography_MouseLeave);
            // 
            // btnSport
            // 
            this.btnSport.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSport.Image = global::TriviaQuiz.Properties.Resources.board;
            this.btnSport.Location = new System.Drawing.Point(523, 31);
            this.btnSport.Name = "btnSport";
            this.btnSport.Size = new System.Drawing.Size(233, 72);
            this.btnSport.TabIndex = 4;
            this.btnSport.Text = "Sport";
            this.btnSport.UseVisualStyleBackColor = true;
            this.btnSport.Click += new System.EventHandler(this.BtnSport_Click);
            this.btnSport.MouseEnter += new System.EventHandler(this.BtnGeography_MouseEnter);
            this.btnSport.MouseLeave += new System.EventHandler(this.BtnGeography_MouseLeave);
            // 
            // Joker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TriviaQuiz.Properties.Resources.Site_Background;
            this.ClientSize = new System.Drawing.Size(763, 253);
            this.ControlBox = false;
            this.Controls.Add(this.btnSport);
            this.Controls.Add(this.btnPopCulture);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnScience);
            this.Controls.Add(this.btnGeography);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Joker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeography;
        private System.Windows.Forms.Button btnScience;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnPopCulture;
        private System.Windows.Forms.Button btnSport;
    }
}