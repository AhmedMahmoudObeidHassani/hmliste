using System;
using System.Collections.Generic;

class Program
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Mark { get; set; }
        public Student(string id, string name, double mark)
        {
            Id = id;
            Name = name;
            Mark = mark;
        }
    }

    static void Main()
    {
        List<Student> students = new List<Student>();
        int numberOfStudents;
        Console.WriteLine("Enter the number of students (5-10): ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out numberOfStudents) && numberOfStudents >= 5 && numberOfStudents <= 10)
                break;
            else
                Console.WriteLine("Please enter a valid number between 5 and 10.");
        }
        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"Enter ID for student {i + 1}:");
            string id = Console.ReadLine();

            Console.WriteLine($"Enter name for student {i + 1}:");
            string name = Console.ReadLine();

            double mark;
            while (true)
            {
                Console.WriteLine($"Enter mark for {name}:");
                if (double.TryParse(Console.ReadLine(), out mark) && mark >= 0 && mark <= 100)
                    break;
                else
                    Console.WriteLine("Please enter a valid mark between 0 and 100.");
            }
            students.Add(new Student(id, name, mark));
        }
        Console.WriteLine("\nStudents who passed (mark >= 50):");
        foreach (var student in students)
        {
            if (student.Mark >= 50)
            {
                Console.WriteLine($"{student.Name} (ID: {student.Id}) - Mark: {student.Mark:F2}");
            }
        }
    }
}