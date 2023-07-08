using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass1Assessment3
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int number1, number2;

            do
            {
                Console.WriteLine("Enter two positive non-equal integers between 2 and 1000:");
                Console.Write("First number: ");
                number1 = int.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                number2 = int.Parse(Console.ReadLine());

                if (number1 >= number2 || number1 < 2 || number2 < 2 || number1 > 1000 || number2 > 1000)
                {
                    Console.WriteLine("Invalid input. Please make sure the first number is smaller than the second number, and both numbers are between 2 and 1000.");
                    Console.WriteLine();
                }
            }
            while (number1 >= number2 || number1 < 2 || number2 < 2 || number1 > 1000 || number2 > 1000);

            Console.WriteLine("Prime numbers between {0} and {1}:", number1, number2);

            for (int i = number1; i <= number2; i++)
            {
                if (IsPrime(i))
                    Console.WriteLine(i);
            }
        }
    }
    
}
