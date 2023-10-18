using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Pattern_Programs
{
    class FloydTriangle
    {
        public static void logic()
        {
        start:
            Console.Clear();

            int i, j, k = 1;
            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j < i + 1; j++)
                {
                    Console.Write(k++ + " ");
                }

                Console.Write("\n");
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
