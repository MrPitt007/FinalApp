using System;
using System.Collections.Generic;

class Question
{
    public string QuestionText { get; set; } = "";
    public string[] Options { get; set; } = new string[4];
    public int CorrectAnswer { get; set; }
}

class Program
{
    static List<Question> GetQuestions()
    {
        return new List<Question>
        {
            new Question
            {
                QuestionText = "What does C# stand for?",
                Options = new string[] { "A) C Sharp", "B) C Hash", "C) C Plus Plus Plus", "D) C Star" },
                CorrectAnswer = 1
            },
            new Question
            {
                QuestionText = "Which keyword is used to create a class in C#?",
                Options = new string[] { "A) object", "B) create", "C) class", "D) new" },
                CorrectAnswer = 3
            },
            new Question
            {
                QuestionText = "What is the correct way to print in C#?",
                Options = new string[] { "A) print()", "B) Console.WriteLine()", "C) echo()", "D) printf()" },
                CorrectAnswer = 2
            },
            new Question
            {
                QuestionText = "Which data type stores a whole number in C#?",
                Options = new string[] { "A) double", "B) float", "C) string", "D) int" },
                CorrectAnswer = 4
            },
            new Question
            {
                QuestionText = "What symbol is used for single line comments in C#?",
                Options = new string[] { "A) ##", "B) //", "C) **", "D) !!" },
                CorrectAnswer = 2
            },
            new Question
            {
                QuestionText = "What does OOP stand for?",
                Options = new string[] { "A) Object Oriented Programming", "B) Open Output Process", "C) Object Output Program", "D) Only One Process" },
                CorrectAnswer = 1
            },
            new Question
            {
                QuestionText = "Which loop always runs at least once?",
                Options = new string[] { "A) for", "B) while", "C) do-while", "D) foreach" },
                CorrectAnswer = 3
            },
            new Question
            {
                QuestionText = "What keyword is used to handle exceptions in C#?",
                Options = new string[] { "A) error", "B) handle", "C) try", "D) catch-all" },
                CorrectAnswer = 3
            },
            new Question
            {
                QuestionText = "Which of these is a correct boolean value in C#?",
                Options = new string[] { "A) yes", "B) true", "C) 1", "D) on" },
                CorrectAnswer = 2
            },
            new Question
            {
                QuestionText = "What is inheritance in C#?",
                Options = new string[] { "A) Copying a file", "B) Deleting a class", "C) A class inheriting from another class", "D) Creating a new variable" },
                CorrectAnswer = 3
            }
        };
    }

    static void Main(string[] args)
    {
        // ============================================
        // Final App - C# Quiz Game
        // ============================================

        Console.WriteLine("========================================");
        Console.WriteLine("         Welcome to the C# Quiz Game!");
        Console.WriteLine("========================================");
        Console.WriteLine("Test your C# knowledge with 10 questions!");
        Console.WriteLine("Type the number of your answer (1, 2, 3, or 4)");
        Console.WriteLine("========================================\n");

        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine() ?? "Player";

        List<Question> questions = GetQuestions();
        int score = 0;
        int questionNumber = 1;

        Console.WriteLine("\nGood luck, " + playerName + "! Let's start!\n");

        foreach (Question question in questions)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Question " + questionNumber + " of " + questions.Count);
            Console.WriteLine(question.QuestionText);
            Console.WriteLine();

            foreach (string option in question.Options)
            {
                Console.WriteLine("  " + option);
            }

            Console.Write("\nYour answer (1-4): ");
            string? input = Console.ReadLine();
            int answer;

            if (int.TryParse(input, out answer) && answer >= 1 && answer <= 4)
            {
                if (answer == question.CorrectAnswer)
                {
                    Console.WriteLine("✓ Correct! Well done!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("✗ Wrong! The correct answer was: " + question.CorrectAnswer + "\n");
                }
            }
            else
            {
                Console.WriteLine("✗ Invalid input! The correct answer was: " + question.CorrectAnswer + "\n");
            }

            questionNumber++;
        }

        // --- Final Score ---
        Console.WriteLine("========================================");
        Console.WriteLine("           QUIZ COMPLETE!");
        Console.WriteLine("========================================");
        Console.WriteLine("Player: " + playerName);
        Console.WriteLine("Score: " + score + " out of " + questions.Count);

        double percentage = (double)score / questions.Count * 100;
        Console.WriteLine("Percentage: " + percentage + "%");

        Console.WriteLine("\nGrade: ");
        if (percentage >= 90)
            Console.WriteLine("  A - Excellent! You're a C# master! 🏆");
        else if (percentage >= 80)
            Console.WriteLine("  B - Great job! Keep it up! 😊");
        else if (percentage >= 70)
            Console.WriteLine("  C - Good effort! Keep practicing! 👍");
        else if (percentage >= 60)
            Console.WriteLine("  D - Not bad! Review the topics and try again! 📚");
        else
            Console.WriteLine("  F - Keep studying! You'll get it! 💪");

        Console.WriteLine("\n========================================");
        Console.WriteLine("Thanks for playing, " + playerName + "!");
        Console.WriteLine("========================================");
        Console.ReadKey();
    }
}
