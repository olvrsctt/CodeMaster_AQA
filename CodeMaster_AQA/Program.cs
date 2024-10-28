using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeMaster_AQA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intro();
            DataTypes();
            ProgrammingConcepts();
            ArithmeticOperationsInAProgrammingLanguage();
            Console.ReadLine();
        }
        public static void Intro()
        {
            // This will be my program to record my journey of learning C# via the AQA syllabus.
            // I will be using the help of ChatGPT and codeium to understand new concepts.

            // 4.1 - Fundamentals of programming
            Console.WriteLine("4.1 - Fundamentals of programming\n");
            // 4.1.1 - Programming
            Console.WriteLine("4.1.1 - Programming\n");
        }
        public static void DataTypes()
        {
            // 4.1.1.1 - Data types
            Console.WriteLine("4.1.1.1 - Data types\n");
            // Data types represent the kind of data a variable can store and the operations that can be performed on that data.
            // Integer - Whole numbers, 4 bytes (32 bits), Used for counters, indexing, etc.
            int age = 21;
            Console.WriteLine("Age: " + age + " (Int)");
            // Real/Float - Decimal numbers, 8 bytes (64 bits), Used for money, temperature, etc.
            // Float - less precise than double, but more efficient, 4 bytes (32 bits)
            // Double - more precise than float, but slower, 8 bytes (64 bits)
            float height = 1.8f;
            double money = 100.00;
            Console.WriteLine("Height: " + height + " (Float)");
            Console.WriteLine("Money: " + money + " (Double)");
            // Boolean - True or False, 1 byte (8 bits), Used for conditions, control flow, etc.
            bool isAlive = true;
            Console.WriteLine("Is alive: " + isAlive + " (Boolean)");
            // Character - Single character, 2 bytes (16 bits), Used for characters, strings, etc.
            char letter = 'A';
            Console.WriteLine("Letter: " + letter + " (Char)");
            // String - Group of characters, 2 or more bytes (16 or 32 bits), Used for text, data, etc.
            string name = "Hunter";
            Console.WriteLine("Name: " + name + " (String)");
            // Date/Time - Date and time, typically 8 bytes (64 bits), Used for dates, times, etc.
            DateTime date = DateTime.Now;
            Console.WriteLine("Date: " + date + " (DateTime)");
            // Pointer - A variable that stores the memory address of another variable. 
            // Used for direct memory manipulation, stored in 4 bytes (32 bits) on 32-bit systems and 8 bytes (64 bits) on 64-bit systems.
            // Requires explicit management and can lead to unsafe operations if not handled carefully.

            // Reference - A variable that refers to an object in memory. 
            // Stored as a memory address, it allows multiple variables to refer to the same object.
            // Offers a safer way to manage memory and is commonly used in C# to handle object-oriented programming.

            // Arrays - Collection of data (of the same type), Used for lists, sets, etc.
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Numbers: " + string.Join(", ", numbers) + " (Array)");
            // Lists - Collection of data (of the same type), Used for lists, sets, etc.
            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Numbers: " + string.Join(", ", numbers2) + " (List)");
            // Records - Collection of data (of the same type), Used for lists, sets, etc.
        }
        public static void ProgrammingConcepts()
        {
            // 4.1.1.2 - Programming concepts
            Console.WriteLine("\n4.1.1.2 - Programming concepts\n");
            // Variable declaration - Creating a variable with a specific type and value.
            int age; // Declares a variable named "age" of type "int" with no value.
            Console.WriteLine("Age: ??? (Declared variable but no value yet)");
            // Constant declaration - Declaring a constant with a specific value.
            const double PI = 3.14; // Declares a constant named "PI" of type "double" with a value of 3.14.
            Console.WriteLine("PI: " + PI + " (Constant dobule)");
            age = 21; // Assigns the value 21 to the variable named "age".
            Console.WriteLine("Age: " + age);
            // Iteration - Repeating a block of code.
            // Definite Iteration - Repeating with a known number of iterations.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }
            // Indefinite Iteration - Repeating with an unknown number of iterations (conditional).
            //while (true)
            //{
            //    Console.WriteLine("Indefinite iteration");
            //}
            // Selection - Making a decision based on a condition.
            if (age > 18)
            {
                Console.WriteLine("You are an adult (Selection if)");
            }
            else
            {
                Console.WriteLine("You are a child (Selection else)");
            }
            // Subroutine - A function that performs a specific task.
            // Nested structures - Structures within structures.
            bool isAlive = true;
            if (age >= 18)
            {
                if (isAlive)
                {
                    Console.WriteLine("Adult and alive. (Nested if)");
                }
                else
                {
                    Console.WriteLine("Adult but not alive. (Nested else)");
                }
            }
        }
        public static void ArithmeticOperationsInAProgrammingLanguage()
        {
            // 4.1.1.3 - Arithmetic operations in a programming language
            Console.WriteLine("\n4.1.1.3 - Arithmetic operations in a programming language\n");
            // Arithmetic operations - Adding, subtracting, multiplying, and dividing.
            int a = 10;
            int b = 5;
            // Addition
            int sum = a + b;
            Console.WriteLine("Adding: " + sum);
            // Subtraction
            int difference = a - b;
            Console.WriteLine("Subtracting: " + difference);
            int product = a * b;
            // Multiplication
            Console.WriteLine("Multiplying: " + product);
            // Real division, also known as floating point division
            double realDivision = 10.0 / 5.0;
            Console.WriteLine("Real dividing: " + realDivision); 
            // Integer division
            int integerDivision = a / b;
            Console.WriteLine("Integer dividing: " + integerDivision);
            // Remainders, also known as the modulo operator
            int remainder = 10 % 4;
            Console.WriteLine("Remaindering (Modding): " + remainder);
            // Exponentiation, also known as the power operator
            double power = Math.Pow(2, 3); // 8.0 (2 raised to the power of 3)
            Console.WriteLine("Exponentiating (Powering): " + power);
            // Rounding
            double rounded = Math.Round(2.5); // 2 
            Console.WriteLine("Rounding: " + rounded);
            // Truncation - Removing the decimal part of a number resulting in an integer
            double value = 2.9;
            int truncated = (int)value; // 2
            Console.WriteLine("Truncating: " + truncated);
        }
    }
}
