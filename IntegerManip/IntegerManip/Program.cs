using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerManip
{
    class Program
    {
        //As a team, write a project to prompt the user for up to 20 integers.  
        //The user will be allowed to choose from the following menu options until they decide to quit:
        //• Display the whole list of input
        //• Display every even number
        //• Display every odd number
        //• Display every 5th number
        //• Display the sum of the integers
        //• Display every number divisible by 3
        //• Quit
        static void Main(string[] args)
        {
            ArrayList numbers = new ArrayList();
            int ignore;
            bool valid;
            String input;
            int integer;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Input a number or use Q to quit");
                input = Console.ReadLine();
                valid = Int32.TryParse(input, out ignore);
                if (input.Equals("Q"))
                {
                    i = 20;
                }
                else if (valid)
                {
                    integer = Convert.ToInt32(input);
                    numbers.Add(integer);
                }
                else
                {
                    i--;
                    Console.WriteLine("Invalid Input");
                }
            }
            integer = 0;
            do
            {
                Console.WriteLine("\n1: Whole List");
                Console.WriteLine("2: Evens");
                Console.WriteLine("3: Odds");
                Console.WriteLine("4: 5th Number");
                Console.WriteLine("5: Sum of Integers");
                Console.WriteLine("6: All Numbers Divisible by 3");
                Console.WriteLine("7: Quit");
                input = Console.ReadLine();
                if (Int32.TryParse(input, out ignore) == false)
                {
                    Console.WriteLine("Invalid Input");
                }
                else
                {
                    integer = Convert.ToInt32(input);
                    switch (integer)
                    {
                        case 1:
                            Output(numbers);
                            break;
                        case 2:
                            Evens(numbers);
                            break;
                        case 3:
                            Odds(numbers);
                            break;
                        case 4:
                            //5th Number
                            break;
                        case 5:
                            Console.WriteLine(SumOfAll(numbers));
                            break;
                        case 6:
                            OutputDivisibleByThree(numbers);
                            break;
                        case 7:
                            //quit
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;

                    }
                }

            } while (integer != 7);
            Console.WriteLine("Program Complete. Please Press Enter to Exit.");
            Console.ReadLine();
        }
        static void Output(ArrayList numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        static void Odds(ArrayList numbers)
        {
            foreach(int temp in numbers)
            {
                if(temp % 2 != 0)
                {
                    Console.WriteLine(temp);
                }
            }
        }
        static void Evens(ArrayList numbers)
        {
            foreach (int temp in numbers)
            {
                if (temp % 2 == 0)
                {
                    Console.WriteLine(temp);
                }
            }
        }
        static void OutputDivisibleByThree(ArrayList numbers)
        {
            foreach (int i in numbers)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int SumOfAll(ArrayList numbers)
        {
            int sum = 0;
            foreach(int i in numbers)
            {
                sum += ((int)numbers[i]);
            }
            return sum;
        }
    }
}
