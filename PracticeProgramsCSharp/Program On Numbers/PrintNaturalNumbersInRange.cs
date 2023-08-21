using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class PrintNaturalNumbersInRange
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the Lower Limit");
            int llimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Lower Limit");
            int ulimit = Convert.ToInt32(Console.ReadLine());

            for (int i = llimit; i < ulimit; i++)
            {
                Console.WriteLine("{0}", i);

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
