using System;
using System.Collections.Generic;
namespace QuizGame
{
    [Serializable]
    public class Formular
    {
        public string question;
        public int answerIndex;
        public List<string> answers = new List<string>();

    }

}