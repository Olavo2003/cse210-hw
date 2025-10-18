using System;
using System.Collections.Generic;

namespace MindfulnessProgram
{
    class ReflectingActivity : Activity
    {
        private List<string> _prompts = new()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you acted selflessly."
        };

        private List<string> _questions = new()
        {
            "Why was this experience meaningful to you?",
            "Have you done anything similar before?",
            "How did you feel when it was complete?",
            "What did you learn from this experience?",
            "How can you apply what you learned in the future?"
        };

        private Random _rng = new();

        public ReflectingActivity()
            : base("Reflecting Activity",
                   "This activity helps you think about times when you’ve shown strength and resilience.")
        {
        }

        private string GetRandomPrompt()
        {
            return _prompts[_rng.Next(_prompts.Count)];
        }

        private string GetRandomQuestion()
        {
            return _questions[_rng.Next(_questions.Count)];
        }

        private void DisplayPrompt()
        {
            Console.WriteLine($"\n{GetRandomPrompt()}");
            Console.WriteLine("Press Enter when you’re ready...");
            Console.ReadLine();
        }

        private void DisplayQuestions()
        {
            DateTime end = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < end)
            {
                Console.WriteLine($"\n{GetRandomQuestion()}");
                ShowSpinner(5);
            }
        }

        public override void Run()
        {
            DisplayStartingMessage();
            DisplayPrompt();
            DisplayQuestions();
            DisplayEndingMessage();
        }
    }
}
