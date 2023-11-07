using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Matrix_Programs
{
    internal class LargestElementInAMatrix
    {
        public static void logic()
        {
        start:
            Console.Clear();
            int[,] x;
            x = new int[,] { { 12, 15, 16 }, { 19, 22, 25 } };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(x[i, j]);
                }
                Console.WriteLine();

            }

            int largest = x[0, 0];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (largest < x[i, j])
                    {
                        largest = x[i, j];
                    }
                }
            }

            Console.WriteLine("Largest Element: {0}", largest);

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
