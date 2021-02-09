using System;

namespace Method
{
    class People
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }

        public string Intro()
        {
            return $"NAME: {this.Name}   AGE:{2020-this.YearOfBirth}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            People P1 = new People { Name = "Yunus Talip EROL", YearOfBirth = 1989 };
            People P2 = new People { Name = "Almila EROL", YearOfBirth = 2016 };

            Console.WriteLine(P1.Intro());
            Console.WriteLine(P2.Intro());
        }
    }
}
