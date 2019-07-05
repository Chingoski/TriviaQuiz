using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriviaQuiz.Properties;

namespace TriviaQuiz
{
    public partial class TriviaNewGame : Form
    {
        private List<Question> GeographyQuestions;
        private List<Question> SportQuestions;
        private List<Question> ScienceQuestions;
        private List<Question> PopCultureQuestions;
        private List<Question> ComputerScienceQuestions;
        private int GeograpyLeft;
        private int SportsLeft;
        private int ScienceLeft;
        private int PopcultureLeft;
        private int computerscienceLeft;
        public static Question Current;
        public static string CurrentCategory;
        private static Random random;
        public static int Points;
        public static int Lives;
        private int timerValue;
        private int timerSlow;
        private float angle;
        private int circlePosition;

        public TriviaNewGame()
        {
            Icon = Icon.FromHandle(Resources.trivia_quiz_logo.GetHicon());
            InitializeComponent();
            NewGame();
        }

        public void FillQuestions(string QuestionsLocation , string AnswerLocation, string tema)
        {
            int answerIndex = 0;
            string[] questions = QuestionsLocation.Split(new []{'\n'}, StringSplitOptions.RemoveEmptyEntries);
            string[] answers = AnswerLocation.Split(new []{'\n'}, StringSplitOptions.RemoveEmptyEntries);
            for (int x = 0; x < questions.Length; x++)
            {
                Question tmp = new Question
                {
                    QuestionName = questions[x]
                };
                Answer tmpa = new Answer();
                tmpa.AllAnswers.Add(answers[answerIndex]);
                tmpa.AllAnswers.Add(answers[answerIndex + 1]);
                tmpa.AllAnswers.Add(answers[answerIndex + 2]);
                tmpa.AllAnswers.Add(answers[answerIndex + 3]);
                tmpa.Correct();
                tmp.Answers = tmpa;
                if (tema.Equals("Geography"))
                {
                    GeographyQuestions.Add(tmp);
                }
                else if (tema.Equals("Sports"))
                {
                    SportQuestions.Add(tmp);
                }
                else if (tema.Equals("Science"))
                {
                    ScienceQuestions.Add(tmp);
                }
                else if (tema.Equals("PopCulture"))
                {
                    PopCultureQuestions.Add(tmp);
                }
                else if (tema.Equals("ComputerScience"))
                {
                    ComputerScienceQuestions.Add(tmp);
                }
                answerIndex += 4;
            }
        }

        public void NewGame()
        {
            angle = 24;
            GeographyQuestions = new List<Question>();
            ScienceQuestions = new List<Question>();
            SportQuestions = new List<Question>();
            PopCultureQuestions = new List<Question>();
            ComputerScienceQuestions = new List<Question>();
            Lives = 3;
            Points = 0;
            GeograpyLeft = 30;
            SportsLeft = 30;
            ScienceLeft = 30;
            PopcultureLeft = 30;
            computerscienceLeft= 30;
            random = new Random();
            FillQuestions(Resources.Geography_Questions , Resources.Geography_Anwsers, "Geography");
            FillQuestions(Resources.PopCultureQuestions, Resources.PopCultureAnswers, "PopCulture");
            FillQuestions(Resources.Science_Questions, Resources.Science_Anwsers, "Science");
            FillQuestions(Resources.SportsQuestions, Resources.SportsAnwsers, "Sports");
            FillQuestions(Resources.ComputerScienceQuestions, Resources.ComputerScienceAnswers, "ComputerScience");
            timerRotate.Enabled = false;
            label4.Text = Points.ToString();
        }

        public void GetQuestion()
        {
            if (CurrentCategory == "Geography")
            {
                Current = GeographyQuestions[random.Next(GeograpyLeft)];
                GeographyQuestions.Remove(Current);
                GeograpyLeft--;
            }

            else if (CurrentCategory == "Science")
            {
                Current = ScienceQuestions[random.Next(ScienceLeft)];
                ScienceQuestions.Remove(Current);
                ScienceLeft--;
            }

            else if (CurrentCategory == "Sports")
            {
                Current = SportQuestions[random.Next(SportsLeft)];
                SportQuestions.Remove(Current);
                SportsLeft--;
            }

            else if (CurrentCategory == "PopCulture")
            {
                Current = PopCultureQuestions[random.Next(PopcultureLeft)];
                PopCultureQuestions.Remove(Current);
                PopcultureLeft--;
            }
            else if (CurrentCategory == "ComputerScience")
            {
                Current = ComputerScienceQuestions[random.Next(PopcultureLeft)];
                ComputerScienceQuestions.Remove(Current);
                computerscienceLeft--;
            }
            this.Hide();
            TriviaAnwserQuestion form = new TriviaAnwserQuestion();
            while (form.ShowDialog() != DialogResult.Cancel)
            {

            }
            this.Show();
            Current = null;
            CurrentCategory = null;
            label4.Text = Points.ToString();
            CheckLives();
            GetStatusOfGame();
            btnNewGame.Enabled = true;
            btnRotate.Enabled = true;
        }

        public void CheckLives()
        {
            if (Lives == 2)
                lives3.Image = null;
            if (Lives == 1)
                lives2.Image = null;
            if (Lives == 0)
                lives1.Image = null;
        }
        public void GetStatusOfGame()
        {
            if (Points == 30)
            {
                Form form = new EndMessage();
                Hide();
                if (form.ShowDialog() == DialogResult.Cancel)
                    Close();
            }

            if (Lives == 0)
            {
                Form form = new EndMessage();
                Hide();
                if (form.ShowDialog() == DialogResult.Cancel)
                    Close();
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            timerValue = random.Next(10,80);
            timerSlow = (int)(timerValue / 1.3);
            timerRotate.Enabled = true;

        }

        public Bitmap RotateImage(Bitmap b, float angle)
        {
            MatrixOrder asd = new MatrixOrder();
            
            Bitmap rotatedImage = new Bitmap(b.Width, b.Height);
            Graphics g = Graphics.FromImage(rotatedImage);
            g.InterpolationMode = InterpolationMode.High;
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            g.DrawImage(b, 0, 0, b.Width, b.Height);
            return rotatedImage;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnNewGame.Enabled = false;
            btnRotate.Enabled = false;
            timerValue--;
            if (timerValue <= 0)
            {
                timerRotate.Enabled = false;
            }

            if (timerValue < timerSlow && angle>4)
            {
                angle /= (float)1.3;
            }
            circlePosition += (int)angle;
            using (Bitmap b = new Bitmap(pictureBox1.Image))
                {
                    Bitmap newBmp = RotateImage(b, angle);
                    pictureBox1.Image = newBmp;
                }

                if (!timerRotate.Enabled)
                {
                    circlePosition %= 360;
                    if (circlePosition >= 0 && circlePosition < 60)
                    {
                        CurrentCategory = "Geography";
                    GetQuestion();
                    resetWheel();
                 }
                   
                else if (circlePosition >= 60 && circlePosition < 120)
                {
                   
                    CurrentCategory = "Science";
                    GetQuestion();
                    resetWheel();
                }
                    
                else if (circlePosition >= 120 && circlePosition < 180)
                {
                  
                    CurrentCategory = "Sports";
                    GetQuestion();
                    resetWheel();
                }

                else if (circlePosition >= 180 && circlePosition < 240)
                {
                    
                    CurrentCategory = "PopCulture";
                    GetQuestion();
                    resetWheel();
                }
                    else if (circlePosition >= 240 && circlePosition < 300)
                    {

                        CurrentCategory = "ComputerScience";
                        GetQuestion();
                        resetWheel();
                    }
                    else if (circlePosition >= 300 && circlePosition < 360)
                    {
                        Form jokerForm = new Joker();
                        this.Hide();
                        while (jokerForm.ShowDialog() != DialogResult.Cancel)
                        {

                        }
                        GetQuestion();
                        resetWheel();
                    }

            }
        }

        public void resetWheel()
        {
            Bitmap rotatedImage = new Bitmap(Properties.Resources.Webp_net_resizeimage_FINAL);
            Graphics g = Graphics.FromImage(rotatedImage);
            pictureBox1.Image = rotatedImage;
            angle = 20;
            circlePosition = 0;
        }

        private void BtnRotate_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void BtnRotate_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
