using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, factorial = 1;

            Console.WriteLine("To calculate the factorial of a number. \r\n");

            Console.Write("Enter any Number: ");
            int number = int.Parse(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.Write("Factorial of " + number + " is: " + factorial);

            Console.ReadKey();  
        }
    }
}
