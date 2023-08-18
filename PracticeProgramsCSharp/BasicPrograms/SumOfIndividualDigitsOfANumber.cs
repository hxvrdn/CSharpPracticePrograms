using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class SumOfIndividualDigitsOfANumber
    {

        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string numString = Convert.ToString( num);
            int sum = 0;
            int r;
            while(num != 0)
            {
                r = num % 10;
                sum = sum + r;

                num = num / 10;
             }
            Console.WriteLine("Sum of Individual Digits of {0} is", sum);


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
