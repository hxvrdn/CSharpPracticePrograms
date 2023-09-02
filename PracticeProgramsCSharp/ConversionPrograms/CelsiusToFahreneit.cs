using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.ConversionPrograms
{
    class CelsiusToFahreneit
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter Temperature in Celsius.");
            int cel = Convert.ToInt32(Console.ReadLine());
            int feh;

            feh = (cel * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is(°F) : " + feh);

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
