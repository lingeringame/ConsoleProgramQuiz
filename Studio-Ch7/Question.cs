using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_Ch7
{
    public abstract class Question
    {
        public string Prompt { get; set; }
        public double PointsEarned { get; set; } = 0;
        public abstract double Points { get; set; }
        public Question(string prompt)
        {
            Prompt = prompt;
        }
        public abstract void PromptUser();

    }
}
