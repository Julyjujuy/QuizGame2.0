using System;
using System.Collections.Generic;
using System.IO;



namespace QuizGame
{
    internal class Program
    {
        const int NR_ANSWERS = 3;
        const int NR_QUESTIONS = 3;
        static string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dataquiz.xml");

        public static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                List<Formular> qAndA = new List<Formular>();
                for (int i = 0; i < NR_QUESTIONS; i++)
                {
                    Formular form = new Formular();
                    form.question = UIMethods.AskQuestion();

                    for (int j = 0; j < NR_ANSWERS; j++)
                    {
                        form.answers.Add(UIMethods.AskAnswer());
                    }

                    form.answerIndex = UIMethods.AskAnswerHolder();
                    qAndA.Add(form);
                }
                LogicMethods.Serialize(qAndA, filePath);
                qAndA = LogicMethods.Deserialize(filePath);
                foreach (Formular formular in qAndA)
                {
                    string question = formular.question;
                    List<string> answers = formular.answers;

                    UIMethods.DisplayQuestion(question, answers);
                    LogicMethods.CheckAnswer(formular.answerIndex);
                }

                playAgain = UIMethods.AskToPlayAgain();
            }
            UIMethods.EndGame();
        }
    }
}