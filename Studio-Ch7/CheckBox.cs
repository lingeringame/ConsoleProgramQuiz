using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_Ch7
{
    public class CheckBox : Question
    {
        public readonly string[] correctAnswer;
        public string UserResponse { get; set; }
        public override double Points { get; set; }
        public CheckBox(string question, string[] correctAnswer, double points) : base(question)
        {
            this.correctAnswer = correctAnswer;
            Points = points;
        }
        public override void PromptUser()
        {
            Console.WriteLine(Prompt);
            Console.WriteLine("Enter your two answers separated by a space: ");
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
