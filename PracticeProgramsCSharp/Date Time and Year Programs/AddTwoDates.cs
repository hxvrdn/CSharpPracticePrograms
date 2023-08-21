using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Date_Time_and_Year_Programs
{
    class AddTwoDates
    {
        public static void logic()
        {
        start:
            Console.Clear();
            DateTime sdate = new DateTime(2023, 8, 15);
            Console.WriteLine("Initial Date {0}", sdate);
            Console.WriteLine("Add 10 Days");
            DateTime edate = sdate.AddDays(10);
            Console.WriteLine("Findal Date: {0}", edate);


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

