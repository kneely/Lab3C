using System;

namespace Lab3C
{
    class Program
    {
        private static decimal a, b, result;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the mathmatical operator for the function you would like to use.");
            string input = Convert.ToString(Console.ReadLine());
            if ("+" == input)
            {
                Add();
            }
            else if ("-" == input)
            {
                Subtract();
            }
            else if ("*" == input)
            {
                Multiply();
            }
            else if ("/" == input)
            {
                Divide();
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }

        static void Add()
        {
            Console.WriteLine("Please enter the first number.");
            a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the second number.");
            b = Convert.ToDecimal(Console.ReadLine());

            result = (a + b);

            Console.WriteLine("The sum of {0} and {1} is {2}.", a, b, result);
        }

        static void Subtract()
        {
            Console.WriteLine("Please enter the first number.");
            a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the second number.");
            b = Convert.ToDecimal(Console.ReadLine());

            result = (a - b);

            Console.WriteLine("{0} subtracted by {1} is {2}.", a, b, result);
        }

        static void Multiply()
        {
            Console.WriteLine("Please enter the first number.");
            a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the second number.");
            b = Convert.ToDecimal(Console.ReadLine());

            result = (a * b);

            Console.WriteLine("{0} multiplied by {1} is {2}", a, b, result);
        }

        static void Divide()
        {
            Console.WriteLine("Please enter the first number.");
            a = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the second number.");
            b = Convert.ToDecimal(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("You cannot divide by zero. Please enter another number.");
                Console.WriteLine("Please enter a new number to divide by.");
                b = Convert.ToDecimal(Console.ReadLine());
            }
          
                result = (a / b);

                Console.WriteLine("{0} divided by {1} is {2}", a, b, result);
        }
    }
}
