using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.ConversionPrograms
{
    class BinaryToDecimal
    {
        public static void logic()
        {
        start:
            Console.Clear();
            int num, binnum , decval = 0, baseval = 1, rem;
            Console.WriteLine("Enter A Binary Number(1's and 0's)");
            num = Convert.ToInt32(Console.ReadLine());
            binnum = num;
            while(num >0)
            {
                rem = num % 10;
                decval = decval + rem * baseval;
                num = num / 10;
                baseval = baseval * 2;

            }

            Console.WriteLine("Binary Number : {0}", binnum);
            Console.WriteLine("Decimal Equivalent Number : {0}", decval);

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
