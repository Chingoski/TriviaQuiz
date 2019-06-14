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
    public partial class TriviaHome : Form
    {
        public TriviaHome()
        {
            InitializeComponent();
            Icon = Icon.FromHandle(Resources.trivia_quiz_logo.GetHicon());
        }

        private void TriviaHome_Load(object sender, EventArgs e)
        {

        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            Form form = new TriviaNewGame();
            Hide();
            if(form.ShowDialog() == DialogResult.Cancel)
                Show();
        }

        private void BtnInstructions_Click(object sender, EventArgs e)
        {
            Form form = new Instructions();
            Hide();
            if (form.ShowDialog() == DialogResult.Cancel)
                Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void BtnInstructions_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnInstructions_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
