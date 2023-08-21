using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Date_Time_and_Year_Programs
{
    class GettheUniversalTime
    {

        public static void logic()
        {
        start:
            Console.Clear();
            TimeZone zone = TimeZone.CurrentTimeZone;
            DateTime univ = zone.ToUniversalTime(DateTime.Now);
            Console.WriteLine("The Universal Time Is: {0}", univ);

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
