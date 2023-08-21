using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Date_Time_and_Year_Programs
{
    class GetTheDaylightSavingInformation
    {
        public static void logic()
        {
        start:
            Console.Clear();
            TimeZone z = TimeZone.CurrentTimeZone;
            DaylightTime t = z.GetDaylightChanges(DateTime.Today.Year);
            Console.WriteLine("Start Time: {0}", t.Start);
            Console.WriteLine("Delta Time: {0}", t.Delta);
            Console.WriteLine("End Time: {0}", t.End);
            

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