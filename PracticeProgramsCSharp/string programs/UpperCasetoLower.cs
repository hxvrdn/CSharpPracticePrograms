using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace PracticeProgramsCSharp.String_Programs
{

    class UpperCaseToLower
    {
        public static void logic()
        {
        start:
            Console.Clear();

            string str;
            Console.WriteLine("Enter the String in Uppercase :");
            str = Console.ReadLine();
            Console.WriteLine("String in LowerCase : {0}", str.ToLower());
          


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