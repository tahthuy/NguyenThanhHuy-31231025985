using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace NguyenThanhHuy_31231025985
{
    internal class NguyenThanhHuy_31231025985
    {
        public static void Main()
        {
            Question_01();
            Question_02();
            Question_03();
            Question_04();
            Question_05();
            Question_06();
            Question_07();
            Question_08();
            Question_09();
            Question_10();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }

        /// <summary>
        /// . to Add / sum two numbers
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
        }
        public static void Question_02()
        {
            Console.Write("Enter the A number: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Enter the B number: ");
            int B = int.Parse(Console.ReadLine());
            int temp = A;
            A = B;
            B = temp;
            Console.WriteLine("Value of A after being swapped: " + A);
            Console.WriteLine("Value of B after being swapped: " + B);
        }
        public static void Question_03()
        {
            Console.Write("Enter the first float number: ");
            float float1 = float.Parse(Console.ReadLine());
            Console.Write("Enter the secomd float number: ");
            float float2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Multiply two floating numbers: {float1*float2}");
        }
        public static void Question_04()
        {
            Console.Write("Enter an amount of length in feet: ");
            int feet = int.Parse(Console.ReadLine());
            Console.WriteLine($"Length in metre: {feet * 0.3048}");
        }
        public static void Question_05()
        {
            Console.Write("Enter a temparature (e.g. 32): ");
            float temperature = float.Parse(Console.ReadLine());
            Console.Write("Enter scale used (C/F)");
            string scale = Console.ReadLine();
            if (scale == "C")
            {
                Console.WriteLine($"Temparature in Farenheit: {temperature * 9 / 5 + 32}");
            }
            else if (scale == "F")
            {
                Console.WriteLine($"Temparature in Celcius: {(temperature - 32) / 9 * 5}");
            }
        }
        public static void Question_06()
        {
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"Size of char: {sizeof(char)} bytes");
            Console.WriteLine($"Size of long: {sizeof(long)} bytes");
            Console.WriteLine($"Size of byte: {sizeof(byte)} bytes");
        }
        public static void Question_07()
        {
            Console.Write("Enter a character: ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine($"\nASCII value of '{character}': {(int)character}");
        }
        public static void Question_08()
        {
            Console.Write("Enter radius of the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area of the circle: {radius * radius * 3.14}");
        }
        public static void Question_09()
        {
            Console.Write("Enter side length of the square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Area of the square: {side * side}");
        }
        public static void Question_10()
        {
            Console.Write("Enter number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());
            int years = days / 365;
            days %= 365;
            int weeks = days / 7;
            days %= 7;
            Console.WriteLine($"{years} years, {weeks} weeks, {days} days");
        }
    }
}
