using System;
using System.Collections.Generic;
using System.Text;

namespace Studio_Ch7
{
    public class Quiz
    {
        private List<Question> questions;
        private double score = 0;
        private double maxScore;
        private double questionsCorrect = 0;
        public Quiz(List<Question> questions)
        {
            this.questions = questions;
        }
        public void Run()
        {
            foreach (Question q in questions)
            {
                q.PromptUser();
            }
            GradeQuiz();
        }
        private void GradeQuiz()
        {
            foreach(Question q in questions)
            {
                score += q.PointsEarned;
                maxScore += q.Points;
                if(q.PointsEarned == q.Points)
                {
                    questionsCorrect++;
                }
                }
            
            Console.WriteLine($"Your total grade for the quiz was {Math.Round(questionsCorrect / questions.Count * 100)}% " +
                $"({questionsCorrect}/{questions.Count}). +{score}/{maxScore}pts");
        }
    }
}
