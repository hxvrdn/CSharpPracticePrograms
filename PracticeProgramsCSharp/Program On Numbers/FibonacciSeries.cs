using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class FibonacciSeries
    {
        public static void logic()
        {
        start:
            Console.Clear();
            int i, f1 = 0, f2 = 1, f3 = 0;
            Console.WriteLine("Enter the limit");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <= limit; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
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
