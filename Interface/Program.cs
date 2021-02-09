using System;

namespace Interface
{
    interface IPerson
    {
        string NameSurname { get; set; }
        string Address { get; set; }
        double Salary { get; set; }

    }

    interface IPersonnel
    {
        string Department { get; set; }

        void Information();
    }

    class Manager : IPerson, IPersonnel
    {
        public string NameSurname { get ; set ; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Manager(string _namesurname, string _address, double _salary, string _department)
        {
            this.NameSurname = _namesurname;
            this.Address = _address;
            this.Salary = _salary;
            this.Department = _department;
        }
        public void Information()
        {
            Console.WriteLine($"{this.NameSurname} is a manager at {this.Department} department");
        }
    }

    class Worker : IPerson, IPersonnel
    {
        public string NameSurname { get ; set ; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public Worker(string _namesurname, string _address, double _salary, string _department)
        {
            this.NameSurname = _namesurname;
            this.Address = _address;
            this.Salary = _salary;
            this.Department = _department;
        }

        public void Information()
        {
            Console.WriteLine($"{this.NameSurname} is a worker at {this.Department} department");
        }
    }

    class Robot : IPersonnel
    {
        public string Department { get; set; }

        public Robot(string Rdepartment)
        {
            this.Department = Rdepartment;
        }
        public void Information()
        {
            Console.WriteLine($"I am a ROBOT  at {this.Department} department");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Manager m1 = new Manager("Yunus Talip EROL","KOCAELI",5000,"SOFTWARE");
            Worker w1 = new Worker("Ali VELI","ISTANBUL",3000,"PRODUCTION");
            Robot r1 = new Robot("Production");

            m1.Information();
            w1.Information();
            r1.Information();
        }
    }
}
