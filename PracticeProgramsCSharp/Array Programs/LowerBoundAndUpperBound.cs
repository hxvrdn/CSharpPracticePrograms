using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Array_Programs
{
    internal class LowerBoundAndUpperBound
    {
        public static void logic()
        {
        start:
            Console.Clear();

            Array stringArray = Array.CreateInstance(typeof(String), 6);
            stringArray.SetValue("Mango", 0);
            stringArray.SetValue("Orange", 1);
            stringArray.SetValue("Apple", 2);
            stringArray.SetValue("Grape", 3);
            stringArray.SetValue("Cherry", 4);
            stringArray.SetValue("WaterMelon", 4);
            Console.WriteLine("The Lower Bound of the Array : {0}",
                              stringArray.GetLowerBound(0).ToString());
            Console.WriteLine("The Upper Bound of the Array : {0}",
                              stringArray.GetUpperBound(0).ToString());
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
