using System;

namespace Inheritance
{
    class Person
    {
        public string Name { get; set; }
        public string Surname  { get; set; }
        public Person(string pName, string pSurname)
        {
            Console.WriteLine("Person Created!");
            this.Name = pName;
            this.Surname = pSurname;
        }

        public virtual void Intro()
        {
            Console.WriteLine($"NAME: {this.Name} SURNAME: {this.Surname}");
        }

    }

    

    class Student : Person
    {
        public string StudentNumber { get; set; }
        public Student(string pName, string pSurname, string StudentNumber) : base(pName,pSurname)
        {
            this.StudentNumber = StudentNumber;
            Console.WriteLine("Student created !");
            
        }

        public override void Intro()
        {
            Console.WriteLine($"NAME: {this.Name} SURNAME: {this.Surname}  NUMBER: {this.StudentNumber} ");
        }
    }

    class Teacher : Person
    {
        public string Branch { get; set; }

        public Teacher(string pName, string pSurname, string branch) : base(pName,pSurname)
        {
            Console.WriteLine("TEACHER created !");
            this.Branch = branch;
        }
        public override void Intro()
        {
            Console.WriteLine($"NAME: {this.Name} SURNAME: {this.Surname}  BRANCH: {this.Branch} ");
        }
        public void Teach()
        {
            Console.WriteLine("I am teaching...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("Almila", "EROL");
            var s1 = new Student("Yunus", "EROL","100");
            var t1 = new Teacher("Yasemin", "UZUN", "Math");

            p1.Intro();
            s1.Intro();
            t1.Intro();
            t1.Teach();

            
        }
    }
}
