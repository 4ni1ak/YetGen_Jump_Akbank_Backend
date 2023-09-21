using System;
using System.Collections.Generic;
using _002._01_OOP.Entities;
using _002._01_OOP.Enums;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student()
            {
                FirstName = "Alper",
                LastName = "Tunga",
                Gender = Gender.Male,
                No = 1,
                CreatedOn = DateTime.Now,
                RegistrationDate = DateTimeOffset.Now.AddHours(-1)
            };

            List<Student> students = new List<Student>();
            students.Add(student);

            Console.WriteLine($"Student information: No - {student.No} Student First Name: {student.FirstName} Student Last Name: {student.LastName} Student Gender: {student.Gender}");
            students.ForEach(x => Console.WriteLine($"Student information: No - {x.No} Student First Name: {x.FirstName} Student Last Name: {x.LastName} Student Gender: {x.Gender}"));

            Guid studentId = Guid.NewGuid();
            string studentName = "Yakup Can";
            string studentSurname = "Sıtacı";
            Gender studentGender = Gender.Male;

            Console.ReadLine();
        }
    }
}
