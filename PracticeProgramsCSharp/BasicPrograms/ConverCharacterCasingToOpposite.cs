using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class ConverCharacterCasingToOpposite
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter Any Character");
            char c = Convert.ToChar(Console.ReadLine());

            if(c >=65 && c <=90)
            {
                Console.WriteLine(" The Character : {0}" , char.ToLower(c));
            }

            else if(c>= 97 && c<= 122)
            {
                Console.WriteLine(" The Character : {0}", char.ToUpper(c));
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
