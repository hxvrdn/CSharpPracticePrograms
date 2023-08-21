using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class PrintArmstrongNumbersInARange
    {
        public static void logic()
        {
        start:
            Console.Clear();
           
            int sum = 0;
            int r;
            Console.WriteLine("Enter the Upper Bound");
            int ubound = Convert.ToInt32(Console.ReadLine());

            for (int j = 1; j < ubound; j++)
            {
                int i = j;
                int temp = i;
                sum = 0;
                while (i != 0)
                {
                    r = i % 10;
                    sum = sum + (r * r * r);
                    i = i / 10;

                }

                if (sum == temp)
                {
                    Console.WriteLine(" {0} ", temp);
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
