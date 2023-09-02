using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.ConversionPrograms
{
    class DecimalToBinary
    {
        public static void logic()
        {
        start:
            Console.Clear();
            int num;
            Console.Write("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            int quot;
            string rem = "";
            while (num >= 1)
            {
                quot = num / 2;
                rem += (num % 2).ToString();
                num = quot;
            }
            string bin = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }
            Console.WriteLine("The Binary format for given number is {0}", bin);
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