using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace practice7_calculator
{
    internal class Program
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition of Result is : {0}", result);   //here in curly brasis result value will placed.
        }
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction of Result is : {0}", result);   
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication of Result is : {0}", result);   
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division of Result is : {0}", result);   
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int first_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int second_number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter operator");
            string op = Console.ReadLine();

           if(op == ("+"))
            {
                Program.Addition(first_number, second_number);
            }
           else if(op == ("-"))
            {
                Program.Subtraction(first_number, second_number);
            }
           else if (op == ("*"))
            {
                Program.Multiplication(first_number, second_number);
            }
           else if(op == ("/"))
            {
                Program.Division(first_number, second_number);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();

        }
    }
}
