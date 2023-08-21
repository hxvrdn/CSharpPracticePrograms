using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class PerfecctNumber
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }

            }
            if (sum == num)
            {
                Console.WriteLine("{0} is a perfect number", num);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number", num);
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
