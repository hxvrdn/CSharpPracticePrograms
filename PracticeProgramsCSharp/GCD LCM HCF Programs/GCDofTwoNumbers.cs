using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.GCD_LCM_HCF_Programs
{
    class GCDofTwoNumbers
    {
        public static int calcGCD(int n1, int n2)
        {
            int remainder = 0;
            while(n2 != 0)
            {
                remainder = n1 % n2;
                n1 = n2;
                n2 = remainder;
            }
            return n1;
        }


        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter num 1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("The GCD of {0} and {1} is {2}", num1, num2, calcGCD(num1, num2));

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
