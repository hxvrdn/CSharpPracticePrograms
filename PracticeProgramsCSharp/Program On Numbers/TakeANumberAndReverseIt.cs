using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class TakeANumberAndReverseIt
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter A Number");
            int num = Convert.ToInt32(Console.ReadLine());

            while(num != 0)
            {
                Console.Write(num%10);
                num = num / 10;
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
