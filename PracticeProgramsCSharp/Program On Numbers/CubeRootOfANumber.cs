using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class CubeRootOfANumber
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter A Number");
            double num = Convert.ToDouble(Console.ReadLine());

           double res = Math.Ceiling(Math.Pow(num, (double)1 / 3));
            Console.Write("Cube Root : " + res);

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
