
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class FactorialOfAGivenNumber
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            int i;
            int fact = 1;

            for(i=1; i <= num ; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The Factorial of {0} is {1}", num,fact );

            Console.WriteLine("\n Press 1 To rerun the program \n Press 0 to Main Menu");
            int rerun = 0;
            rerun = Convert.ToInt32(Console.ReadLine());

            if (rerun == 1)
                goto start;
            else
            {
                Program.MainMenu();
            }

        }

    }
}
