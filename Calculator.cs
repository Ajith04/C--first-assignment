using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_001
{
    internal class Calculator
    {
        public void add(int no1, int no2)
        {
            Console.WriteLine($"The answer is {no1 + no2}");

        }

        public void sub(int no1, int no2)
        {
            if (no1 > no2)
            {
                Console.WriteLine($"The answer is {no1 - no2}");
            }
            else
            {
                Console.WriteLine("Check your numbers");
            }
        }

        public void mul(int no1, int no2)
        {
            Console.WriteLine($"The answer is {no1 * no2}");
        }

        public void div(int no1, int no2)
        {
            if (no2 != 0)
            {
                double answer = no1 / no2;
                Console.WriteLine($"The answer is {answer}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Can't divide by 0");
            }
        }
    }
}
