using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.String_Programs
{

    class TrimString
    {
        public static void logic()
        {
        start:
            Console.Clear();
            string myString = "    CSHARP      ";
            System.Console.WriteLine("The String Before Trimming :" +
                                     "(" + myString + ")");
            System.Console.WriteLine("The String After Trimming :" +
                                     "(" + myString.Trim() + ")");



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
