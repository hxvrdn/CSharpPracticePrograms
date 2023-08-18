using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class GivenNumberIsPositiveOrNot
    {

    public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num ==0)
            {
                Console.WriteLine("Number is 0");
                 

            }
            else if( num < 0)
            {
                Console.WriteLine("Number Is NEGATIVE");
                

            }

            else
            {
                Console.WriteLine("Number Is POSITIVE");
                 
                 
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
