using System;

namespace QuizApp2
{
    class Program
    {
        class Question
        {
            public Question(string QText, string[] QChoices, string QAnswer) // Constructor
            {
                this.Text = QText;
                this.Choices = QChoices;
                this.Answer = QAnswer;
            }
            public string Text { get; set; }
            public string[] Choices { get; set; }
            public string Answer { get; set; }

            public bool CheckAnswer(string answer) // Method
            {
                return this.Answer.ToLower() == answer.ToLower();
            }
        }
        class Quiz
        {
            public Quiz(Question[] QuestionsArray)
            {
                this.Questions = QuestionsArray;
                this.QuestionIndex = 0;
                this.Score = 0;
            }
            public Question[] Questions { get; set; }
            public  int QuestionIndex { get; set; }
            public int Score { get; set; }
            public Question GetQuestion()
            {
                return this.Questions[this.QuestionIndex];
            }

            public void DisplayQuestion()
            {
                Question Q = this.GetQuestion();
                this.Progress();
              
                Console.WriteLine($"Question {this.QuestionIndex+1} : {Q.Text}");
                foreach (var item in Q.Choices)
                {
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine("ANSWER : ");
                string ANS = Console.ReadLine();
                this.TrueOrFalse(ANS);
            }

            public void TrueOrFalse(string answer)
            {
                var Q = this.GetQuestion();
                if (Q.CheckAnswer(answer))
                {
                    this.Score++;
                }
                
                this.QuestionIndex++;
                if (this.Questions.Length == this.QuestionIndex)
                {
                    this.DisplayScore();
                }
                else
                {
                    this.DisplayQuestion();
                }
            }

            public void DisplayScore()
            {
                Console.WriteLine($"Score: {this.Score}");
            }
            private void Progress()
            {
                int currentquestion = 0;
                if (currentquestion <= this.Questions.Length)
                {
                    Console.WriteLine($"Question    {this.QuestionIndex + 1} of {this.Questions.Length}");
                }
                currentquestion++;
            }
        }
        static void Main(string[] args)
        {
            Question q1 = new Question("What is best programming language?", new string[] { "C#", "Python", "Java", "C++" }, "C#");
            Question q2 = new Question("What is the most popular language?", new string[] { "C#", "Python", "Java", "C++" }, "C#");
            Question q3 = new Question("Which of these makes you different than other programmers?", new string[] { "C#", "Python", "Java", "C++" }, "C#");

            Question[] ArrayOfQ = new Question[] { q1, q2, q3 };
            Quiz quiz = new Quiz(ArrayOfQ);

            quiz.DisplayQuestion();


        }
    }
}
