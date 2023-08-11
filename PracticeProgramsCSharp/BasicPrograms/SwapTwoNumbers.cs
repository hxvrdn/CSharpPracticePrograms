using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class SwapTwoNumbers
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the first Number!");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number!");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping \n Num1 = {0} and Num2 = {1}", num1, num2);

            int temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine();
            Console.WriteLine("After Swapping \n Num1 = {0} and Num2 = {1}", num1, num2);
            Console.WriteLine("To rerun the program enter 1");
            int rerun = 0;
            rerun = Convert.ToInt32(Console.ReadLine());

            if(rerun==1)
            {
                goto start;
            }

        }

    }
}
