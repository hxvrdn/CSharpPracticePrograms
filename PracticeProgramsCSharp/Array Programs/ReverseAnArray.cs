using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Array_Programs
{
    internal class ReverseAnArray
    {

        public static void logic()
        {
        start:
            Console.Clear();
            int[] a = new int[10];

            Console.WriteLine("Array Initially");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i;
                Console.WriteLine(a[i]);
            }
 

            Console.WriteLine("After Reverse");
            for(int i = a.Length-1; i>=0; i--)
            {
                Console.WriteLine(a[i]);
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
