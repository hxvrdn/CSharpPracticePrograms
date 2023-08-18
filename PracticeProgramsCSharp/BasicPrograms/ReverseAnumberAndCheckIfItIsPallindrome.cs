using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class ReverseAnumberAndCheckIfItIsPallindrome
    {
        public static void logic()
        {
            start:
            Console.Clear();
            Console.WriteLine("Enter A Number");
            int num = Convert.ToInt32(Console.ReadLine());

            int reverse = 0; int  rem; int temp = num;
            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num = num / 10;

            }
            Console.WriteLine("Reversed Number : {0}", reverse);
            if(reverse == temp)
            {
                Console.WriteLine("Given Number {0} Is a Pallindrome", temp);
            }
            else
            {
                Console.WriteLine("Not A Pallindrome");
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
