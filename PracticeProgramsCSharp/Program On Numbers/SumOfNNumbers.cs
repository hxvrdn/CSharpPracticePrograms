using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class SumOfNNumbers
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the Nth Number");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine("The Sum Of N Numbers is {0}", sum);


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
