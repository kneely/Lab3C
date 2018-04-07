using System;

namespace Lab3C
{
    class Program
    {
        private static decimal a, b, result;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the mathmatical operator for the function you would like to use.");
            Int16 input = Convert.ToInt16(Console.ReadLine());
            switch (input)
            {
                case 1:
                    {
                        Add();
                        break;
                    }
                case 2:
                    {
                        Subtract();
                        break;
                    }
                case 3:
                    {
                        Multiply();
                        break;
                    }
                case 4:
                    {
                        Divide();
                        break;
                    }
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

            result = (a / b);

            Console.WriteLine("{0} divided by {1} is {2}", a, b, result);
        }
    }
}
