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
                Console.WriteLine("Press 1 to ReRun");

            }
            else if( num < 0)
            {
                Console.WriteLine("Number Is NEGATIVE");
                Console.WriteLine("Press 1 to ReRun");

            }

            else
            {
                Console.WriteLine("Number Is POSITIVE");
                Console.WriteLine("Press 1 to ReRun");
                 
            }
            int rerun = Convert.ToInt32(Console.ReadLine());
            if (rerun == 1)
                goto start;
        }
    }
}
