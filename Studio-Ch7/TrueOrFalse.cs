using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_Ch7
{
    public class TrueOrFalse : Question
    {
        public readonly string[] correctAnswer;
        public string UserResponse { get; set; }
        public override double Points { get; set; }
        public TrueOrFalse(string question, string[] correctAnswer, double points) : base(question)
        {
            this.correctAnswer = correctAnswer;
            Points = points;
        }
        public override void PromptUser()
        {
            Console.WriteLine(Prompt);
            UserResponse = Console.ReadLine().ToLower().Trim();
            if (UserResponse == correctAnswer[0] || UserResponse == correctAnswer[1])
            {
                PointsEarned = Points;
                Console.WriteLine($"Correct! You earned {PointsEarned} points!");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
