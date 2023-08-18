using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class SumOfTwoBinarNumbers
    {
        public static void logic()
        {
        start:
            Console.Clear();
            int i = 0, rem = 0;
            int[] sum = new int[20];
            Console.WriteLine("Enter the First Binary Number");
            int b1 = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Enter the Second Binary Number");
            int b2 = Convert.ToInt32(Console.ReadLine());

            while (b1 != 0 || b2 != 0)
            {
                sum[i++] = (b1 % 10 + b2 % 10 + rem) % 2;
                rem = (b1 % 10 + b2 % 10 + rem) / 2;
                b1 = b1 / 10;
                b2 = b2 / 10;
            }
            if (rem != 0)
                sum[i++] = rem;
            --i;
            Console.WriteLine("Sum of two binary numbers: ");
            while (i >= 0)
                Console.Write("{0}", sum[i--]);
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
