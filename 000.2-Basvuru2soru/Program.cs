using System;
using System.Collections.Generic;

// Define an interface named ISchoolMember that enforces the DisplayInfo method.
public interface ISchoolMember
{
    void DisplayInfo();
}

// Create an abstract class named SchoolMember that implements ISchoolMember.
// This class will be the base for both Teacher and Student classes.
public abstract class SchoolMember : ISchoolMember
{
    // Properties to store common attributes of school members.
    public int ID { get; protected set; }
    public string Name { get; protected set; }
    public int Age { get; protected set; }
    public decimal Balance { get; protected set; }

    // Abstract method that must be implemented by derived classes.
    public abstract void DisplayInfo();
}

// Create a class named Teacher that inherits from SchoolMember.
public class Teacher : SchoolMember
{
    // Constructor to initialize teacher's properties.
    public Teacher(int id, string name, int age)
    {
        ID = id;
        Name = name;
        Age = age;
    }

    // Implementation of DisplayInfo method for teachers.
    public override void DisplayInfo()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Teacher's Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}

// Create a class named Student that inherits from SchoolMember.
public class Student : SchoolMember
{
    // Constructor to initialize student's properties including balance.
    public Student(int id, string name, int age, decimal initialBalance)
    {
        ID = id;
        Name = name;
        Age = age;
        Balance = initialBalance;
    }

    // Method to add money to a student's balance.
    public void AddBalance(decimal amount)
    {
        Balance += amount;
    }

    // Method to reduce money from a student's balance.
    public void ReduceBalance(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient balance!");
        }
    }

    // Method to update a student's age.
    public void UpdateAge(int newAge)
    {
        Age = newAge;
    }

    // Implementation of DisplayInfo method for students.
    public override void DisplayInfo()
    {
        Console.WriteLine($"ID: {ID}");
        Console.WriteLine($"Student's Name: {Name}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}

// Create a class named School to manage school members.
public class School
{
    private List<ISchoolMember> members = new List<ISchoolMember>();
    private int nextID = 1;

    // Method to get the next available ID for a new member.
    public int GetNextID()
    {
        return nextID;
    }

    // Method to add a new member to the school.
    public void AddMember(ISchoolMember member)
    {
        members.Add(member);
        nextID++;
    }

    // Method to find a member by ID.
    public ISchoolMember FindMember(int id)
    {
        return members.Find(member => (member as SchoolMember).ID == id);
    }

    // Method to display information about all members.
    public void DisplayAllMembers()
    {
        foreach (var member in members)
        {
            member.DisplayInfo();
            Console.WriteLine("-------------");
        }
    }
}

// Main program starts here.
class Program
{
    static void Main(string[] args)
    {
        // Create a School object to manage members.
        School school = new School();

        // Main loop for user interactions.
        while (true)
        {
            // Display available actions to the user.
            Console.WriteLine("Please select an action:");
            Console.WriteLine("1. Add a New Teacher");
            Console.WriteLine("2. List Teachers");
            Console.WriteLine("3. Add a New Student");
            Console.WriteLine("4. List Students");
            Console.WriteLine("5. Add Money to a Student");
            Console.WriteLine("6. Withdraw Money from a Student");
            Console.WriteLine("7. Update Student's Age");
            Console.WriteLine("8. Exit");

            // Read the user's choice.
            int choice = int.Parse(Console.ReadLine());

            // Process the user's choice using a switch statement.
            switch (choice)
            {
                case 1:
                    // Adding a new teacher.
                    Console.WriteLine("Enter Teacher's Name:");
                    string teacherName = Console.ReadLine();

                    Console.WriteLine("Enter Teacher's Age:");
                    int teacherAge = int.Parse(Console.ReadLine());

                    ISchoolMember newTeacher = new Teacher(school.GetNextID(), teacherName, teacherAge);
                    school.AddMember(newTeacher);
                    break;

                case 2:
                    // Displaying all teachers.
                    Console.WriteLine("All Teachers:");
                    school.DisplayAllMembers();
                    break;

                case 3:
                    // Adding a new student.
                    Console.WriteLine("Enter Student's Name:");
                    string studentName = Console.ReadLine();

                    Console.WriteLine("Enter Student's Age:");
                    int studentAge = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Initial Balance:");
                    decimal initialBalance = decimal.Parse(Console.ReadLine());

                    ISchoolMember newStudent = new Student(school.GetNextID(), studentName, studentAge, initialBalance);
                    school.AddMember(newStudent);
                    break;

                case 4:
                    // Displaying all students.
                    Console.WriteLine("All Students:");
                    school.DisplayAllMembers();
                    break;

                case 5:
                    // Adding money to a student's balance.
                    Console.WriteLine("Enter Student's ID:");
                    int addBalanceID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Amount to Add:");
                    decimal addAmount = decimal.Parse(Console.ReadLine());

                    Student studentToAddBalance = school.FindMember(addBalanceID) as Student;
                    if (studentToAddBalance != null)
                    {
                        studentToAddBalance.AddBalance(addAmount);
                        Console.WriteLine($"{studentToAddBalance.Name}'s account has been credited with {addAmount:C}.");
                    }
                    else
                    {
                        Console.WriteLine("Student not found!");
                    }
                    break;

                case 6:
                    // Withdrawing money from a student's balance.
                    Console.WriteLine("Enter Student's ID:");
                    int reduceBalanceID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Amount to Reduce:");
                    decimal reduceAmount = decimal.Parse(Console.ReadLine());

                    Student studentToReduce = school.FindMember(reduceBalanceID) as Student;
                    if (studentToReduce != null)
                    {
                        studentToReduce.ReduceBalance(reduceAmount);
                        Console.WriteLine($"{studentToReduce.Name}'s account has been debited with {reduceAmount:C}.");
                    }
                    else
                    {
                        Console.WriteLine("Student not found!");
                    }
                    break;

                case 7:
                    // Updating a student's age.
                    Console.WriteLine("Enter Student's ID:");
                    int updateAgeID = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter New Age:");
                    int newAge = int.Parse(Console.ReadLine());

                    Student studentToUpdateAge = school.FindMember(updateAgeID) as Student;
                    if (studentToUpdateAge != null)
                    {
                        studentToUpdateAge.UpdateAge(newAge);
                        Console.WriteLine("Age updated.");
                    }
                    else
                    {
                        Console.WriteLine("Student not found!");
                    }
                    break;

                case 8:
                    // Exiting the program.
                    Console.WriteLine("Exiting the program...");
                    return;

                default:
                    // Handling invalid choices.
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }
}