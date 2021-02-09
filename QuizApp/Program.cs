using System;

namespace QuizApp
{
    class Program
    {
        class Question
        {
            public Question(string QText,string[] QChoices,string QAnswer) // Constructor
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
        static void Main(string[] args)
        {

            Question q1 = new Question("What is best programming language?",new string[] {"C#","Python","Java","C++" },"C#" );
            Question q2 = new Question("What is the most popular language?", new string[] { "C#", "Python", "Java", "C++" }, "C#" );
            Question q3 = new Question("Which of these makes you different than other programmers?", new string[] { "C#", "Python", "Java", "C++" }, "C#" );

            Question[] ArrayOfQ = new Question[] { q1, q2, q3 };
            int index = 1;
            foreach (var item in ArrayOfQ)
            {
                Console.WriteLine($"Question{index} : {item.Text} ");
                index++;

                foreach (var ans in item.Choices)
                {
                    Console.WriteLine($"{ans}");
                }
                Console.WriteLine("Your Answer : ");
                var UserAnswer = Console.ReadLine();
                Console.WriteLine(item.CheckAnswer(UserAnswer));
            }
        }
    }
}
