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
    public partial class TriviaAnwserQuestion : Form
    {
        private Question Current;
        public TriviaAnwserQuestion()
        {
            InitializeComponent();
            Current = new Question();
            Icon = Icon.FromHandle(Resources.trivia_quiz_logo.GetHicon());
        }

        private void TriviaAnwserQuestion_Load(object sender, EventArgs e)
        {
            SetBackgroundImage();
            Icon = Icon.FromHandle(Resources.trivia_quiz_logo.GetHicon());
            Current = TriviaNewGame.Current;
            label1.Text = Current.QuestionName;
            Answer1.Text = Current.Answers.AllAnswers[0];
            Answer2.Text = Current.Answers.AllAnswers[1];
            Answer3.Text = Current.Answers.AllAnswers[2];
            Answer4.Text = Current.Answers.AllAnswers[3];
        }

        public bool isCorrect(string answer)
        {
            return answer == Current.Answers.CorrectAnswer;
        }

        public void CalculatePoints(string answer)
        {
            if (isCorrect(answer))
                TriviaNewGame.Points++;
            else
                TriviaNewGame.Lives--;
            DialogResult = DialogResult.Cancel;
        }

        private void Answer1_Click(object sender, EventArgs e)
        {
            CalculatePoints(Answer1.Text);
        }

        private void Answer2_Click(object sender, EventArgs e)
        {
            CalculatePoints(Answer2.Text);
        }

        private void Answer3_Click(object sender, EventArgs e)
        {
            CalculatePoints(Answer3.Text);
        }

        private void Answer4_Click(object sender, EventArgs e)
        {
            CalculatePoints(Answer4.Text);
        }

        public void SetBackgroundImage()
        {
            if (TriviaNewGame.CurrentCategory == "Geography")
            {
                this.BackgroundImage = Resources.geography;
                Text = TriviaNewGame.CurrentCategory;
            }
            else if (TriviaNewGame.CurrentCategory == "Sports")
            {
                this.BackgroundImage = Resources.sport;
                Text = TriviaNewGame.CurrentCategory;
            }
            else if (TriviaNewGame.CurrentCategory == "Science")
            {
                this.BackgroundImage = Resources.science;
                Text = TriviaNewGame.CurrentCategory;
            }
            else if (TriviaNewGame.CurrentCategory == "PopCulture")
            {
                this.BackgroundImage = Resources.cultr;
                Text = TriviaNewGame.CurrentCategory;
            }
            else if (TriviaNewGame.CurrentCategory == "ComputerScience")
            {
                this.BackgroundImage = Resources.iStock_636447976;
                Text = TriviaNewGame.CurrentCategory;
            }
        }

        private void Answer4_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Answer4_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
