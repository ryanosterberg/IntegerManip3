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
            for (int i=0; i < 20; i++)
            {
                Console.WriteLine("Input a number or use Q to quit");
                String input = Console.ReadLine();
                if(input.Equals("Q"))
                {
                    i = 20;
                }
                else
                {
                    int integer = Convert.ToInt32(input);
                    numbers.Add(integer);
                }
            }
            Output(numbers);
        }
        static void Output(ArrayList numbers)
        {
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
