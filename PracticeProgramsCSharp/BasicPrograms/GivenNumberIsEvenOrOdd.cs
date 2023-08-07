using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeProgramsCSharp.BasicPrograms
{
    
    public class GivenNumberIsEvenOrOdd
    {
        static public void logic()
        {
        begin:
            Console.Clear();
            Console.WriteLine("Enter the Number");
            int checkNum = Convert.ToInt32(Console.ReadLine());
            int rerun = 0;
            if(checkNum%2 == 0 )
            {
                Console.WriteLine("Entered Number is EVEN Number");
                Console.WriteLine("To ReRun the program Enter 1");
                rerun = Convert.ToInt32(Console.ReadLine());
               
            }

            else {
                Console.WriteLine("The Number You Entered is ODD");
            Console.WriteLine("To ReRun the program Enter 1");
            rerun = Convert.ToInt32(Console.ReadLine());
            }


            if (rerun == 1)
                goto begin;
             
        }
    }
}
