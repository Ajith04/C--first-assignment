using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.printHello();

            //program.wish();
            //Console.WriteLine("Enter a number");
            //int no1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another number");
            //int no2 = Convert.ToInt32(Console.ReadLine());

            //program.add(no1, no2);
            //Console.WriteLine("Enter temperature in Celcius");
            //double celcius = Convert.ToDouble(Console.ReadLine());

            //program.convertT(celcius);
            //Console.WriteLine("Enter a number");
            //int no = Convert.ToInt32(Console.ReadLine());

            //program.oddOrEven(no);

            //Console.Write("Enter a Number : ");
            //int no1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter another Number : ");
            //int no2 = Convert.ToInt32(Console.ReadLine());
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.Write("Please enter which operation to be proceed (+, -, *, /) => ");
            //Console.ForegroundColor= ConsoleColor.White;
            //string operation = Console.ReadLine();
            //Calculator calc = new Calculator();

            //switch (operation)
            //{
            //    case "+": calc.add(no1, no2);
            //        break;
            //    case "-": calc.sub(no1, no2);
            //        break;
            //    case "*": calc.mul(no1, no2);
            //        break;
            //    case "/": calc.div(no1, no2);
            //        break;
            //    default: Console.ForegroundColor=ConsoleColor.Red;
            //        Console.WriteLine("Please Enter a valid operator");
            //        break;
            //}

            //Console.Write("Enter a Number : ");
            //int input = Convert.ToInt32(Console.ReadLine());
            //program.findPrime(input);

            //Console.WriteLine("Enter a Number : ");
            //int fnum = Convert.ToInt32(Console.ReadLine());
            //program.findfact(fnum);

            //Console.WriteLine("Enter any word : ");
            //string input = Console.ReadLine();
            //program.vowels(input);

            //Console.WriteLine("Enter a number to print multiplication table");
            //int input = Convert.ToInt32(Console.ReadLine());
            //program.printTable(input);

            //Console.Write("Enter a word : ");
            //string word = Console.ReadLine();
            //Console.Write("Which character you want to count? ");
            //char text = Convert.ToChar(Console.ReadLine());
            //program.count(word, text);

            //Console.Write("Enter a number : ");
            //int no1 = Convert.ToInt16(Console.ReadLine());
            //Console.Write("Enter another number : ");
            //int no2 = Convert.ToInt32(Console.ReadLine());
            //program.gcd(no1, no2);

            //Console.WriteLine("I have a random number between 1 and 100, please guess what");
            //bool repeat = true;
            //int random = 40;

            //while (repeat == true)
            //{
            //    int input = Convert.ToInt16(Console.ReadLine());
            //    if (input > random)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("This is high, try again");
            //    }
            //    else if (input < random)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine("This is low, try again");
            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("Your guessing is correct");
            //        repeat = false;
            //    }
            //}


            bool repeat = true;

            while (repeat == true)
            {
                menu();
                void menu()
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Available Methods");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1. Find the largest number among three numbers.");
                    Console.WriteLine("2. Calculate the sum of digits of a number.");
                    Console.WriteLine("3. Check if a string is a palindrome.");
                    Console.WriteLine("4. Print the first 10 numbers of the fibinocci sequence.");
                    Console.WriteLine("5. Check if a number is a prime number.");
                    Console.WriteLine("0. Exit");

                    int input = Convert.ToInt16(Console.ReadLine());


                    switch (input)
                    {
                        case 1:
                            program.findLarge();
                            break;
                        case 2:
                            program.sumOfDigits();
                            break;
                        case 3:
                            program.checkPalindrome();
                            break;
                        case 4:
                            program.fibinocci();
                            break;
                        case 5:
                            program.checkPrime();
                            break;
                        case 0:
                            repeat = false;
                            Environment.Exit(0);
                            break;
                        default:menu();

                            break;

                    }
                }

               

            }



            Console.ReadLine();
        }


        
        public void printHello()
        {
            Console.WriteLine("Hello World!");
        }

        public void wish()
        {
            Console.Write("Please enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}");
        }

        public void add(int a, int b)
        {
            Console.WriteLine($"The total is {a + b}");
        }

        public void convertT(double cel)
        {
            Console.WriteLine($"{(cel*9/5)+32} F");
        }

        public void oddOrEven(int input)
        {
            if (input % 2 == 0)
            {
                Console.WriteLine($"{input} is an even number");
            }
            else
            {
                Console.WriteLine($"{input} is an odd number");
            }
        }

        public void findPrime(int no)
        {
            string answer = "";

            if (no > 0)
            {
                for (int start = 2; start < no; start++)
                {

                    if (no % start == 0)
                    {
                        answer = ($"{no} is not a Prime Number");
                        break;
                    }
                    else
                    {
                        answer = ($"{no} is a Prime Number");
                    }


                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a positive number");
            }

            Console.WriteLine(answer);
        }

        public void findfact(int num)
        {
            int answer = num;
            
            for (int start=1; start < num; start++) {
                answer = answer * start;
                
            }
            Console.WriteLine($"The factorial of {num} is {answer}");
        }

        public void vowels(string input)
        {
            string word = input.ToLower();
            int count = 0;

            for (int start=0; start < word.Length; start++)
            {
                if (word[start] == 'a' || word[start] == 'e' || word[start] == 'i' || word[start] == 'o' || word[start] == 'u')
                {
                    count = count + 1;
                }
                 
            }
            Console.WriteLine($"{count} vowels are in this word");
                
        }

        
       public void printTable(int input)
        {
            Console.Clear();
            for (int start=1; start<=15; start++)
            {
                
                Console.WriteLine($"{input} * {start} = {input * start}");
            }
        }

        public void count(string word, char text)
        {
            int answer = 0;
            for (int start=0; start<word.Length; start++)
            {
                if (word[start] == text)
                {
                    answer = answer + 1;
                }
            }
            Console.WriteLine($"{answer} {text}(s) is/are in {word}");
        }

        public void gcd(int no1, int no2)
        {
            int answer = 0;
            if (no1 > no2)
            {
                for (int start = 1; start <= no2; start++)
                {
                    if (no1 % start == 0 && no2 % start == 0)
                    {
                        answer = start;
                    }
                }
            }
            else
            {
                for (int start = 1; start <= no1; start++)
                {
                    if (no1 % start == 0 && no2 % start == 0)
                    {
                        answer = start;
                    }
                }
            }
            Console.WriteLine($"The GCD of {no1} and {no2} is {answer}");
        }


        public void findLarge()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Find the largest number among three numbers");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter Number 1 : ");
            int no1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Number 2 : ");
            int no2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Number 3 : ");
            int no3 = Convert.ToInt16(Console.ReadLine());

            if (no1 > no2 && no1 > no3) {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine($"{no1} is largest number");
            }
            else if (no2 > no1 && no2 > no3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{no2} is largest number");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{no3} is largest number");
            }
            Program program = new Program();
            program.pressEnter();

        }

        public void sumOfDigits()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Calculate the sum of digits of a number");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter a number : ");
            int no = Convert.ToInt16(Console.ReadLine());

            int answer = 0;
            int count = 0;
            for (int i = no; i/10>0; i=i/10)
            {
                count = i/10;
                answer = answer + (i%10);
                
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"The sum of all digits in {no} is {answer + count}");
            Program program = new Program();
            program.pressEnter();
        }

        public void checkPalindrome()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Check if a string is a palindrome");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter a word : ");
            string input = Console.ReadLine();
            string word = input.ToLower();

            string answer = "";

            for (int start=0; start<=(word.Length/2); start++)
            {
                if (word[start] != word[(word.Length - 1) - start])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    answer = ($"{input} is not a palindrome word");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    answer = ($"{input} is a palindrome word");

                }
            }
            
            Console.WriteLine(answer);

            Program program = new Program();
            program.pressEnter();

        }

        public void pressEnter()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Press enter to go back");
            Console.ReadLine();
        }

        public void fibinocci()
        {
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Printing the first 10 numbers of the fibinocci sequence");

            int no1 = 0;
            int no2 = 1;
            int no3;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(no1);
            Console.WriteLine(no2);

            for (int i=2; i<10; i++)
            {
                no3 = no1 + no2;
                Console.WriteLine(no3);
                no1 = no2;
                no2= no3;
            }
          

            
            Program program = new Program();
            program.pressEnter();
        }


        public void checkPrime()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Check if a number is a prime number");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter a number : ");
            int input = Convert.ToInt32(Console.ReadLine());

            string answer = "";
            for (int start=2; start<input; start++)
            {
                if (input%start == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    answer = ($"{input} is not a prime number.");
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    answer = ($"{input} is a prime number");
                }
            }

            Console.WriteLine(answer);

            Program program = new Program();
            program.pressEnter();
        }

    }
}
