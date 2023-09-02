using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.ConversionPrograms
{
    class HexaDecuimalToDecimal
    {
        public static void logic()
        {
        start:
            Console.Clear();
            string Input;
            Console.WriteLine("Enter a Hexadecimal Number :");
            Input = Console.ReadLine();
            int Output = int.Parse(Input, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine("The Decimal value is " + Output);
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
