using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaQuiz.Properties;

namespace TriviaQuiz
{
    public partial class EndMessage : Form
    {
        public int Points { get; set; }
        public EndMessage()
        {
            InitializeComponent();
            Icon = Icon.FromHandle(Resources.trivia_quiz_logo.GetHicon());
            Points = TriviaNewGame.Points;
            lblPoints.Text = Points.ToString();
            if (Points < 30)
                lblMessage.Text = "So close! You have almost received the status of Albert Einstein. Test your wisdom again.";
            else
                lblMessage.Text = "Congratulations! You have received the status of Albert Einstein. If you want test your wisdom again.";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
