using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class FactorsOfAGivenNumber
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factors are:");
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

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