using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Date_Time_and_Year_Programs
{
    class ConvertDaysToYearsMonthsWeek
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the Days");
            int days = Convert.ToInt32(Console.ReadLine());

            int years = days / 365;
            int weeks = (days % 365) / 7;
            int day = (days % 365) % 7;
            Console.WriteLine("{0} is equivalent to {1}years, {2}weeks and {3}days.",
                           days, years, weeks, day);

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
