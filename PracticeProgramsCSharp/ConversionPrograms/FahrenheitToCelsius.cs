using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.ConversionPrograms
{
    class FahrenheitToCelsius
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter Temperature in Fahrenheit.");
            double feh = Convert.ToDouble(Console.ReadLine());
            double cel;
            cel = (feh - 32) * 5 / 9;  
            Console.WriteLine("Temperature in Celsius is  : " + cel);

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
