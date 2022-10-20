using System;
using System.Collections.Generic;

namespace Studio_Ch7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultipleChoice q1 = new MultipleChoice("What is my name? \na. Sergio\nb. Sergius\nc. Serge\nd. Sergei\nEnter letter or text only.", new string[] { "sergio", "a", "a.sergio" }, 2);
            MultipleChoice q2 = new MultipleChoice("What's my age? \na. 18\nb. 19\nc. 20\nd. 21", new string[] { "19", "b", "b.19" }, 2);
            TrueOrFalse q3 = new TrueOrFalse("True or False: I am hispanic", new string[] {"true", "t"}, 1);
            CheckBox q4 = new CheckBox("What are my two favorite drinks?\nWater\nCoke\nMilk\nIced Tea\nCoffee", new string[] { "water iced tea", "iced tea water" }, 1);
            ShortAnswer q5 = new ShortAnswer("Briefly explain why you like programming.", 3);
            Quiz myQuiz = new Quiz(new List<Question> { q1, q2, q3, q4, q5 });
            myQuiz.Run();
        }
    }
}
