# Trivia Quiz

[![N|Solid](https://cldup.com/dTxpPi9lDf.thumb.png)](https://nodesource.com/products/nsolid)

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)


Trivia Quiz is a quiz game in which the player will be challenged to test his knowledge and memory in a fun an inovative way from questions that consist of five diverse subjects. 


# Table of Contents  
- [General Information](#general-information)
- [Technologies](#technologies)
- [Object Classes](#object-classes)
- [Functionality](#functionality)
- [Instructions](#instructions)
- [Used Resources and Literature](#used-resources-and-literature)


# General Information
We made this game beacause we are fans of both fun and challenging Trivia Quizes. Our team chose five subjects from different spheres :
- Geography
- Computer Science
- Science
- Sports
- Pop Culture

to immerse and chalange the player at the same time. Because the oversaturation in this genre , we spent a lot of time planing and designing the game so it feels fresh and new , but as model we took [Trivia Crack](https://triviacrack.com/).

# Technologies
In order to make this game we taught the best platform was Microsoft's [Visual Studio 2019](https://visualstudio.microsoft.com/vs/), and as a programing language we chose [C#](https://en.wikipedia.org/wiki/C_Sharp_(programming_language)) because its the most supported and best optimized programing language for this platform. 
- Microsoft Visual Studio is an integrated development environment (IDE) from Microsoft. It is used to develop computer programs, as well as websites, web apps, web services and mobile apps. Visual Studio uses Microsoft software development platforms such as Windows API, Windows Forms, Windows Presentation Foundation, Windows Store and Microsoft Silverlight. It can produce both native code and managed code. 
- C# (pronounced C sharp) is a general-purpose, multi-paradigm programming language encompassing strong typing, lexically scoped, imperative, declarative, functional, generic, object-oriented (class-based), and component-oriented programming disciplines. It was developed around 2000 by Microsoft within its .NET initiative and later approved as a standard by Ecma (ECMA-334) and ISO (ISO/IEC 23270:2018). C# is one of the programming languages designed for the Common Language Infrastructure.

# Object Classes
Like every Trivia Quiz it consists of Questions and Answers. We designed our own classes so that the readbility and reusability of the code is at a high level.

First of all here is the Question class: 
```c#
public class Question
    {
        public string QuestionName { get; set; }
        public Answer Answers { get; set; }
    }
```
The first property 'QuestionName' is simply the Question and the second property 'Answers' is an Object from the follwoing Answer Class :
```c#
 public class Answer
    {
        public string CorrectAnswer { get; set; }
        public List<string> AllAnswers { get; set; }

        public Answer()
        {
            AllAnswers = new List<string>();
        }

        public void Correct()
        {
            for (int i = 0 ; i < AllAnswers.Count ; i++)
            {
                if (AllAnswers[i].Contains("(T)"))
                {
                    var tmp = AllAnswers[i].Substring(0, AllAnswers[i].Length - 4);
                    AllAnswers[i] = tmp;
                    CorrectAnswer = tmp;
                    return;
                }
            }
        }
    }
```
In this class we store the correct answer in the 'CorrectAnswer' property and all other Answers in the 'AllAnswers' property. We provide a constructor and a 'Correct()' method. Because the base of our questions and answers are Notepad files and the correct answers are all marked with "(T)" it helps us sort and differenciate the correct from the wrong answers for a given question.

# Functionality
Every resource the apllication needs is stored in the '/Resources' directory in the same project directory. Most of the resources are images that we use suchs as background images , the wheel of questuins and notpead files which serve as the base of our aplication. We use 6 Forms that are interconected in order to run this aplication. The starting form is 'TiviaHome.cs' which serves as a sort of home screen for the game. From there the user can access the 'Instrucionts.cs' form in which he can read all the necesary information about playing the game , or he can start a new game by accessing the 'TriviaNewGame.cs' form. This form is the 'brain' of the game because it is the form which contains all of the logic for this aplication.

First of all we have some global variables which need to be explained : 
```c#
        private List<Question> GeographyQuestions; //List of all posible geography questions
        private List<Question> SportQuestions; //List of all posible sport questions
        private List<Question> ScienceQuestions; //List of all posible science questions
        private List<Question> PopCultureQuestions; //List of all posible pop culture questions
        private List<Question> ComputerScienceQuestions; //List of all posible computer science questions
        private int GeograpyLeft; // Number of geography questions left
        private int SportsLeft; // Number of sport questions left
        private int ScienceLeft; // Number of science questions left
        private int PopcultureLeft; // Number of pop culture questions left
        private int computerscienceLeft; // Number of computer science questions left
        public static Question Current; // Global variable for accessing the chosen Question
        public static string CurrentCategory; //Category from which a question will be chosen
        private static Random random; // Random number generator
        public static int Points; // Number of points for corectly answered questions
        public static int Lives; // Number of lives left in the current game
        private int timerValue; // Time of wheel rotation
        private int timerSlow; // Time at which the rotationlal angle will reduce its size
        private float angle; // Angle of rotation 
        private int circlePosition; // Center postion of the wheel
```
Secondly we think we should explain the most complicated functions that are in this form which are :

#### Rotation
```c$
public Bitmap RotateImage(Bitmap b, float angle)
        {
            Bitmap rotatedImage = new Bitmap(b.Width, b.Height);
            Graphics g = Graphics.FromImage(rotatedImage);
            g.InterpolationMode = InterpolationMode.High;
            g.TranslateTransform((float)b.Width / 2, (float)b.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)b.Width / 2, -(float)b.Height / 2);
            g.DrawImage(b, 0, 0, b.Width, b.Height);
            return rotatedImage;

        }
```
We pass the wheel create a bitmap from it , rotate it by the angle value and then return it to be redrawn on every timer tick. As stated there are five categories where you can get a question from , but we have 6 areas on the wheel. The sixst one is a joker field which opens the 'Joker.cs' from where the user can select the category from which he wants to answer a question.

### Fetching a question 
```c#
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
                Current = ComputerScienceQuestions[random.Next(computerscienceLeft)];
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
        }
```
After the spinning animation of the wheel has ended and the 'CurrentCategory' property is set, we check it's value and depending on that we fetch a Question by random that the user needs to answer. This seleceted question is passed onto the 'TriviaAnswerQuestion.cs' from where the user answers it and gets points or loses a live depending on his choice. After the game is finished depending on the outcome , win or lose you the 'EndMessage.cs' from will open and print the correct outcome. After that you get redirected to the home section ('TriviaHome.cs') where the user can make his decision whether he chooses to play another round or quit the aplication.

# Instructions
First of all after the user starts the aplication he will be redirected to this screen.
[![N|Solid](https://i.imgur.com/Xy0dxQ2.png)]()

Here the user has 3 options. On cliking exit he will exit the apllication. The 'Instructions' button will redirect the user to the instructions window if he wishes to learn the rules of the game. The user can read all of the game rules and informations on this window.

 [![N|Solid](https://i.imgur.com/IRgxPL6.png)]()

 Or if the user chooses to start a new game he will be redirected to this window. In the center of the screen we have the wheel , on the far right corner the ammount of points and on the far left we have the number of remaining lives. After clicking on Rotate the wheel will spin and after the annimation stops you will be redirected to one of the 6 possible outcomes. 1 is a joker where you select your prefferd question category and the other one is a form where you will answer a question.
  
 [![N|Solid](https://i.imgur.com/ExUHQGj.jpg)]()
   
   This is the form where the user answers his questions. Every button represents one answer and by clicking on it you submit its value and get redirected back to the home page or to the end page deppeind on your situation.

 [![N|Solid](https://i.imgur.com/LL6Jt1C.png)]()

 This is the endpage. Here the message output will differ depending on the state of the users game wether he has won it or not.
 
 [![N|Solid](https://i.imgur.com/VSSiIDf.png)]()
 
 # Used Resources and Literature
 - https://ezyfundraising.com/wp-content/uploads/2016/10/Trivia-Quiz-1.jpg
- https://stackoverflow.com/questions/2163829/how-do-i-rotate-a-picture-in-winforms
- https://opentdb.com/api_config.php
- https://cmkt-image-prd.global.ssl.fastly.net/0.1.0/ps/1365190/910/607/m1/fpnw/wm1/education_bg_cm-.jpg?1465913766&s=73bded9357ae5fc7f039f7f190e1c049
- https://previews.123rf.com/images/tatishdesign/tatishdesign1506/tatishdesign150600061/41900220-hand-drawn-doodle-sport-background-vector-cartoon-pattern-with-sport-icons.jpg
- https://st2.depositphotos.com/3580719/9494/v/950/depositphotos_94948944-stock-illustration-seamless-pattern-with-hand-drawn.jpg
- http://chittagongit.com/icon/hearth-icon-25.html
- https://pixabay.com/vectors/house-svg-vector-2374925/
