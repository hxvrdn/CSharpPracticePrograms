using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class PrintMultiplesOfXwithinrange
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter The Number");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Upper Bound");
            int uBound = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<= uBound; i++)
            {
                if(i%num == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.WriteLine("Press 1 To rerun the program");
            int rerun = 0;
            rerun = Convert.ToInt32(Console.ReadLine());

            if (rerun == 1)
                goto start;

        }
    }
}
