using System;
using System.Linq;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number to find it's factorial: ");
            var input = Convert.ToInt32(Console.ReadLine());
            
            while (input > 0)
            {
                var factorial = input;
                for (int i = factorial - 1; i > 0; i--)
                {
                    factorial *= i;
                }
                Console.WriteLine(input + "! is " + factorial);
                break;
            }
        }
    }
}
