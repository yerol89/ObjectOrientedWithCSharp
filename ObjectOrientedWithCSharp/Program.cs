using System;

namespace ObjectOrientedWithCSharp
{

    class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.StudentID = 100;
            std1.Name = "Yunus";
            std1.Department = "Software";

            Student std2 = new Student()
            {
                StudentID = 150,
                Name = "Almila",
                Department="Computer"
            };

            Student std3 = new Student()
            {
                StudentID = 200,
                Name = "Emre",
                Department = "Economy"
            };

            Student[] Students = new Student[3];
            Students[0] = std1;
            Students[1] = std2;
            Students[2] = std3;

            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine($"ID: {Students[i].StudentID}  Name: {Students[i].Name}   Department: {Students[i].Department}");
            }
        }
    }
}
