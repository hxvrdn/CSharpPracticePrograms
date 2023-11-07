using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Array_Programs
{
    internal class JaggedArrays
    {
        public static void logic()
        {
            start:
            Console.Clear();
            int[][] jag = new int[3][];
            jag[0] = new int[2];
            jag[0][0] = 11;
            jag[0][1] = 12;
            jag[1] = new int[1] { 11 };
            jag[2] = new int[3] { 14, 15, 16 };
            for (int i = 0; i < jag.Length; i++)
            {
                int[] innerArray = jag[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.WriteLine(innerArray[a] + " ");
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
