using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Program_On_Numbers
{
    class PrimeNumber
    {

        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the upper bound");
            int ubound = Convert.ToInt32(Console.ReadLine());
           
            for(int  i =2; i<= ubound; i++)
            {
                bool isprime = true;
                
                for(int j =2; j<i; j++)
                {
                    if (i % j == 0)
                    {
                        
                        isprime = false;
                        break;
                    }
 
                    
                }
                if (isprime)
                {
                    Console.WriteLine(i);
                }


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
