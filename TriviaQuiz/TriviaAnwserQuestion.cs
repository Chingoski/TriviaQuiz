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
            
        }

        private void TriviaAnwserQuestion_Load(object sender, EventArgs e)
        {
            SetBackgorundImage();
            Icon =Icon.FromHandle(Resources.trivia_quiz_logo.GetHicon());
            this.Current = TriviaNewGame.Current;
            tbQuestion.Text = Current.QuestionName;
            Answer1.Text = Current.Answers.AllAnswers[0];
            Answer2.Text = Current.Answers.AllAnswers[1];
            Answer3.Text = Current.Answers.AllAnswers[2];
            Answer4.Text = Current.Answers.AllAnswers[3];
        }

        public bool isCorrect(string answer)
        {
            return answer == Current.Answers.CorrectAnswer;
        }

        public void CalcualatePoints(string answer)
        {
            if (isCorrect(answer))
                TriviaNewGame.Points ++ ;
            else
                TriviaNewGame.Lives--;
            this.DialogResult = DialogResult.Cancel;



        }

        private void Answer1_Click(object sender, EventArgs e)
        {
            CalcualatePoints(Answer1.Text);
        }

        private void Answer2_Click(object sender, EventArgs e)
        {
            CalcualatePoints(Answer2.Text);
        }

        private void Answer3_Click(object sender, EventArgs e)
        {
            CalcualatePoints(Answer3.Text);
        }

        private void Answer4_Click(object sender, EventArgs e)
        {
            CalcualatePoints(Answer4.Text);
        }

        public void SetBackgorundImage()
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
                this.BackgroundImage = Resources.popculture;
                Text = TriviaNewGame.CurrentCategory;
            }
        }
    }
}
