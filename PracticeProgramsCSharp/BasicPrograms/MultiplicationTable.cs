using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class MultiplicationTable
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter The Number you wish the table for: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Table Upto How Many Multiples? ");
            int upto = Convert.ToInt32(Console.ReadLine());
            
            for(int i=1; i<= upto;i++)
            {
                Console.WriteLine("{0} * {1} : {2}", num, i, num * i);
                 if(i % 10 ==0)
                {
                    Console.WriteLine();
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
