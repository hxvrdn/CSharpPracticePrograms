using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class AbsoluteValueOfANumber
    {

        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;

            if (num <0)
            {
                num = num * -1;
            }

            Console.WriteLine("The absolute value of {0} is {1}", temp, num);

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
