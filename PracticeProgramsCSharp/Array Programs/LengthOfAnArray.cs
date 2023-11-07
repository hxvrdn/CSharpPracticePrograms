using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Array_Programs
{
    internal class LengthOfAnArray
    {
        public static void logic()
        {
        start:
            Console.Clear();
            int[] a = new int[10];
            int len = a.Length;
            Console.WriteLine("Length of Arra A is {0}", len);

            int[] b = new int[5];
            double lenb = b.Length;
            Console.WriteLine("Length of Arra A is {0}", lenb);


            int[,] c = new int[10,5];
            int lenc = c.Length;
            Console.WriteLine("Length of Arra A is {0}", lenc);

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
