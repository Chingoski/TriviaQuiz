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
        private int GeograpyLeft;
        private int SportsLeft;
        private int ScienceLeft;
        private int PopcultureLeft;
        public static Question Current;
        public static string CurrentCategory;
        private static Random random;
        public static int Points;
        public static int Lives;
        private int timerValue;

        public TriviaNewGame()
        {
            Icon = Icon.FromHandle(Resources.trivia_quiz_logo.GetHicon());
            InitializeComponent();
            NewGame();

        }
        public void FillQuestions(string QuestionsLocation , string AnswerLocation)
        {


            int answerIndex = 0;
            string[] questions =
                File.ReadAllLines(QuestionsLocation);
            string[] anwsers =
                File.ReadAllLines(AnswerLocation);
            for (int x = 0; x < questions.Length; x++)
            {
                Question tmp = new Question
                {
                    QuestionName = questions[x]
                };
                Answer tmpa = new Answer();
                tmpa.AllAnswers.Add(anwsers[answerIndex]);
                tmpa.AllAnswers.Add(anwsers[answerIndex + 1]);
                tmpa.AllAnswers.Add(anwsers[answerIndex + 2]);
                tmpa.AllAnswers.Add(anwsers[answerIndex + 3]);
                tmpa.Correct();
                tmp.Answers = tmpa;
                if (QuestionsLocation.Contains("Geography"))
                {
                    GeographyQuestions.Add(tmp);
                }
                else if (QuestionsLocation.Contains("Sports"))
                {
                    SportQuestions.Add(tmp);
                }
                else if (QuestionsLocation.Contains("Science"))
                {
                    ScienceQuestions.Add(tmp);
                }
                else if (QuestionsLocation.Contains("PopCulture"))
                {
                    PopCultureQuestions.Add(tmp);
                }

                answerIndex += 4;
            }

           


        }
        public void NewGame()
        {
            GeographyQuestions = new List<Question>();
            ScienceQuestions = new List<Question>();
            SportQuestions = new List<Question>();
            PopCultureQuestions = new List<Question>();
            Lives = 3;
            Points = 0;
            GeograpyLeft = 30;
            SportsLeft = 30;
            ScienceLeft = 30;
            PopcultureLeft = 30;
            random = new Random();
            FillQuestions(@"C:\Users\Nikola\Downloads\repos-2\repos\TriviaQuiz\Resources\PopCultureQuestions.txt", @"C:\Users\Nikola\Downloads\repos-2\repos\TriviaQuiz\Resources\PopCultureAnswers.txt");
            FillQuestions(@"C:\Users\Nikola\Downloads\repos-2\repos\TriviaQuiz\Resources\Geography-Questions.txt", @"C:\Users\Nikola\Downloads\repos-2\repos\TriviaQuiz\Resources\Geography-Anwsers.txt");
            FillQuestions(@"C:\Users\Nikola\Downloads\repos-2\repos\TriviaQuiz\Resources\Science-Questions.txt", @"C:\Users\Nikola\Downloads\repos-2\repos\TriviaQuiz\Resources\Science-Anwsers.txt");
            FillQuestions(@"C:\Users\Nikola\Downloads\repos-2\repos\TriviaQuiz\Resources\SportsQuestions.txt", @"C:\Users\Nikola\Downloads\repos-2\repos\TriviaQuiz\Resources\SportsAnwsers.txt");
            timerRotate.Enabled = false;
            label4.Text = Points.ToString();
            
        }
        public void GetQuestion()
        {
            if (CurrentCategory=="Geography")
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
                Current = SportQuestions[random.Next(SportsLeft)];
                PopCultureQuestions.Remove(Current);
                PopcultureLeft--;
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
           
            
        }

        public void CheckLives()
        {
            if (Lives == 2)
            {
                lives3.Image = null;
            }
            if (Lives == 1)
            {
                lives2.Image = null;
            }
            if (Lives == 0)
            {
                lives1.Image = null;
            }
        }
        public void GetStatusOfGame()
        {
            if (Points == 30)
            {
                MessageBox.Show("You have won the game");
                this.Close();
                new TriviaHome().ShowDialog();
            }

            if (Lives == 0)
            {
                MessageBox.Show("You have lost the game. You have recieved "+Points.ToString()+" Points.");
                this.Close();
                new TriviaHome().ShowDialog();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            NewGame();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            timerValue = random.Next(75);
            timerRotate.Enabled = true;
        }
        public Bitmap RotateImage(Bitmap b, float angle)
        {
            Bitmap rotatedImage = new Bitmap(b.Width, b.Height);
            Graphics g = Graphics.FromImage(rotatedImage);
            g.InterpolationMode = InterpolationMode.High;
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            //            g.DrawImage(b, new Point(0, 0));

            g.DrawImage(b, 0, 0, b.Width, b.Height);
            return rotatedImage;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerValue--;
            if (timerValue <= 0)
            {
                timerRotate.Enabled = false;
            }

            using (Bitmap b = new Bitmap(pictureBox1.Image))
            {
                Bitmap newBmp = RotateImage(b, 17);
                pictureBox1.Image = newBmp;
            }

            if (!timerRotate.Enabled)
            {

                Bitmap b = new Bitmap(pictureBox1.Image);
                Point location = new Point((b.Width) / 2 - 112, (b.Height) / 2 - 20);
                Color c = b.GetPixel(location.X, location.Y);
                if (c == Color.FromArgb(255, 0, 255, 0))
                {
                    CurrentCategory = "Sports";
                    GetQuestion();
                    resetWheel();
                }
                   
                else if (c == Color.FromArgb(255, 0, 51, 255))
                {
                    CurrentCategory = "Geography";
                    GetQuestion();
                    resetWheel();
                }
                    
                else if (c == Color.FromArgb(255, 203, 0, 255))
                {
                    CurrentCategory = "PopCulture";
                    GetQuestion();
                    resetWheel();

                }

                else if (c == Color.FromArgb(255, 255, 4, 0))
                {
                    CurrentCategory = "Science";
                    GetQuestion();
                    resetWheel();

                }
                
                else
                {
                    resetWheel();
                    button1_Click_1(null,null);
                }
                


            }
        }
        public void resetWheel()
        {
            Bitmap rotatedImage = new Bitmap(Properties.Resources.Webp_net_resizeimage);
            Graphics g = Graphics.FromImage(rotatedImage);
            pictureBox1.Image = rotatedImage;
        }

     
    }
}
