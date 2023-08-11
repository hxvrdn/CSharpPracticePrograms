using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class DivisibleBy2OrNot
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the Number");
            int checkNum = Convert.ToInt32(Console.ReadLine());

            if (checkNum % 2 == 0)
            {
                Console.WriteLine("Entered Number is divisible by 2 ");
                ;

            }

            else
            {
                Console.WriteLine("Not Divisible by 2");

            }

            Console.WriteLine("To rerun the program enter 1");
            int rerun = 0;
            rerun = Convert.ToInt32(Console.ReadLine());

            if (rerun == 1)
            {
                goto start;
            }
        }
    }
}
