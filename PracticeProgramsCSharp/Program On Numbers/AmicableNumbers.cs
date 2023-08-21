using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class AmicableNumbers
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter First Number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int s1 =0;
            Console.WriteLine("Enter second Number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int s2 =0;
            for (int i = 1; i < n1; i++)
            {
                if(n1%i == 0)
                {
                    s1 = s1 + i;
                }

            }
            for (int i = 1; i < n2; i++)
            {
                if (n2 % i == 0)
                {
                    s2 = s2 + i;
                }

            }

            if (n1 == s2 && n2 == s1)
            {
                Console.WriteLine("{0} and {1} are amicable numbers",n1, n2 );
            }
            else
            {
                Console.WriteLine("{0} and {1} are NOT amicable numbers", n1, n2);
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
