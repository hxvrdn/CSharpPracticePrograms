using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class SumOfIndividualDigitsOfANumberUsingrecursion
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = sum(num);
            Console.WriteLine("The Sum Of Digits of Individual character of {0} is", result);


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

        public static int sum(int num)
        {
            if (num != 0)
            {
                return (num % 10 + sum(num / 10));
            }

            else
                return 0;
        }

    }
}
