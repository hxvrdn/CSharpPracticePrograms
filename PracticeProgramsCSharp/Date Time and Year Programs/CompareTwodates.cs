using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Date_Time_and_Year_Programs
{
    class CompareTwodates
    {
        public static void logic()
        {
        start:
            Console.Clear();
            DateTime sdate = new DateTime(2023, 8, 15);
            Console.WriteLine("First Date {0}", sdate);

            DateTime fdate = new DateTime(2023, 8, 21);
            Console.WriteLine("Second Date {0}", fdate);

            if (sdate < fdate)
            {
                Console.Write("{0} occurs before {1} ", sdate, fdate);
            }

            else if (sdate > fdate)
            {
                Console.Write("{0} occurs before {1} ", fdate, sdate);
            }

            else
            {
                Console.WriteLine("Both Occurs on the Same Date");
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
