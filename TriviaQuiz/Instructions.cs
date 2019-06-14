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
    public partial class Instructions : Form
    {
        public Instructions()
        {
            InitializeComponent();
            Icon = Icon.FromHandle(Resources.trivia_quiz_logo.GetHicon());
        }

        private void Label1_Click(object sender, EventArgs e)
        {

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
