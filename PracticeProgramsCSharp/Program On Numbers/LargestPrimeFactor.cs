using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class LargestPrimeFactor
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());

            int k = 0;

            for (int i = 1; i <= num; i++)
            {
                if(num%i == 0)
                {
                    k++;
                }
            }

            if(k == 2)
            {
                Console.WriteLine("The Entered Number Is Prime And it's Largest factor is {0}", num);
            }
            else
            {
                Console.WriteLine("It is Not A prime Number");
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