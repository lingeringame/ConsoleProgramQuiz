using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Studio_Ch7
{
    public class ShortAnswer : Question
    {
        public string UserResponse { get; set; }
        public override double Points { get; set; }
        public ShortAnswer(string question, double points) : base(question)
        {
            Points = points;
        }
        public override void PromptUser()
        {
                Console.WriteLine(Prompt);
            do
            {
                Console.WriteLine("Your response: ");
                UserResponse = Console.ReadLine().Trim();
                if(UserResponse.Length > 80)
                {
                    Console.WriteLine("Prompt cannot exceed 80 characters");
                }
            }
            while (UserResponse.Length > 80);

            PointsEarned = Points;
            Console.WriteLine($"Your response will be graded by your tutor shortly.");

        }
    }
}
