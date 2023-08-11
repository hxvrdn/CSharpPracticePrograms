using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class SumOfMultiplesOfXAndY
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter Value of X");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of Y");
            int y = Convert.ToInt32(Console.ReadLine());

            int a, b;
            int sum = 0;
            for(int i =1; i<=100; i++)
            {
                a = i % x;
                b = i % y;

                if (a == 0 || b == 0)
                {
                    Console.WriteLine("{0}\t", i);
                    sum = sum + i;

                }

            }
            Console.WriteLine("The Sum of all the Multiples of {0} and {1} are {2}", x, y, sum);

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
