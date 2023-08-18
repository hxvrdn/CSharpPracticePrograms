using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class BinaryEquivalentOfAInteger
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter  Decimal Number: ");
            int dnum = Convert.ToInt32(Console.ReadLine());
            conversionFunction.bfun(dnum);
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

    public class conversionFunction
   {
        public static int bfun(int num)
        {
            int bin;
            if(num !=0)
            {
                bin = (num % 2);
                bfun(num / 2);
                Console.Write(bin);
                return 0;

            }

            else
            {
                return 0;
            }
        }


    }

}