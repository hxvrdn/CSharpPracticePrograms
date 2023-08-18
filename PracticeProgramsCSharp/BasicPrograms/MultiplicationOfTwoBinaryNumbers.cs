using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class MultiplicationOfTwoBinaryNumbers
    {
        public static void logic()
        {
        start:
            Console.Clear();
            string binary1, binary2;

            int product = 0;

            Console.Write("Enter first binary number: ");
            binary1 = Console.ReadLine();

            Console.Write("Enter second binary number: ");
            binary2 = Console.ReadLine();

            int a = Convert.ToInt32(binary1, 2);
            int b = Convert.ToInt32(binary2, 2);

            product = a * b;

            Console.WriteLine("\nDecimal: {0} ", product + " \nBinary: " + Convert.ToString(product, 2).PadLeft(8, '0'));

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
