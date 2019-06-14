using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaQuiz
{
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
           for(int i = 0 ; i < AllAnswers.Count ; i++)
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
}
