using System;

namespace HelloStudentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                name = "World";
            }

            // Read the raw string to preserve leading zeros
            string studentNumberRaw = ReadStudentNumberRaw();

            // Parse to int for the Student object (leading zeros will be dropped in the int)
            int studentNumber = int.Parse(studentNumberRaw);

            Console.WriteLine($"Hello, {name}!");

            var student = new Student
            {
                Name = name,
                StudentNumber = studentNumber
            };

            Console.WriteLine($"Welcome to the matrix, {student.Name} with the student number of {studentNumberRaw}!");
            // Print the raw value so leading zeros are shown
           
        }

        private static string ReadStudentNumberRaw()
        {
            while (true)
            {
                Console.Write("Enter your student number (numbers only, e.g., 012345): ");
                string? input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) && IsAllDigits(input))
                {
                    return input;
                }

                Console.WriteLine("Invalid student number. Please enter digits only.");
            }
        }

        private static bool IsAllDigits(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return value.Length > 0;
        }
    }
}