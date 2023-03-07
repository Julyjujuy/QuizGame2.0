using System;
using System.Collections.Generic;

namespace QuizGame
{
    internal class UIMethods
    {
        public static void StartSession()
        {
            Console.WriteLine("Welcome to this console Quiz game. You will be asked to imput some questions and their answerws. Thanks for partecipate!");
        }
        public static string AskQuestion()
        {
            Console.WriteLine("Please imput a question for this game. Information will be stored only during this session.");
            return Console.ReadLine();
        }
        public static string AskAnswer()
        {
            Console.WriteLine("Please imput an answer to this question.");
            return Console.ReadLine();
        }
        public static int AskAnswerHolder()
        {
            int rightAnIndex;
            while (true)
            {
                Console.WriteLine("Tell me which question is the correct one: 1, 2, or 3?");
                string rightAn = Console.ReadLine();
                if (!int.TryParse(rightAn, out rightAnIndex) || rightAnIndex < 1 || rightAnIndex > 3)
                {
                    Console.WriteLine("Invalid input, please enter a value between 1 and 3");
                }
                else
                {
                    break;
                }
            }
            return rightAnIndex;
        }

        public static void DisplayQuestion(string question, List<string> answers)
        {
            Console.WriteLine($"Question: {question}");
            for (int i = 0; i < answers.Count; i++)
            {
                Console.WriteLine($"Answer {i + 1}: {answers[i]}");
            }
            Console.WriteLine($"Please input your answer (1 - {answers.Count})");
        }

        public static void LetsTakeAPause()
        {
            Console.ReadLine();
        }
        public static bool AskToPlayAgain()
        {
            Console.WriteLine("Do you want to play again? (Y/N)");
            string input = Console.ReadLine().ToLower();
            while (input != "y" && input != "n")
            {
                Console.WriteLine("Invalid input. Please enter Y or N.");
                input = Console.ReadLine().ToLower();
            }
            return input == "y";
        }

        public static void EndGame()
        {
            Console.WriteLine("Thanks for playing the quiz game!");
            Console.ReadLine();
        }


    }
}