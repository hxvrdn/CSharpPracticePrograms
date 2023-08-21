using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class ArmstrongNumber
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;
            int r;

            while (num != 0)
            {
                r = num % 10;
                sum = sum + (r * r * r);
                num = num / 10;

            }

            if (sum == temp)
            {
                Console.WriteLine("The Number {0} is an armstrong number", temp);
            }
            else
            {
                Console.WriteLine("The Number {0} is not an armstrong number", temp);
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
