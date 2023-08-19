using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Programs_on_Data_type_and_operators
{
    class MinimumRangeOfValuesOfDataTypes
    {
        public static void logic()
        {
        start:
            Console.Clear();

            Console.WriteLine("The Minimum Range of the Decimal Data " +
                                          "Type is : {0} ", Decimal.MinValue);
            Console.WriteLine("The Minimum Range of the Float Data " +
                              "Type is : {0} ", Single.MinValue);
            Console.WriteLine("The Minimum Range of the Decimal Data " +
                              "Type is : {0} ", Double.MinValue);
            Console.WriteLine("Exponent Form : The Minimum Range of Decimal " +
                              "Data Type  is : {0:E}", Decimal.MinValue);
            Console.WriteLine("Exponent Form : The Minimum Range of Float " +
                              "Data Type  is : {0:E}", Single.MinValue);
            Console.WriteLine("Exponent Form : The Minimum Range of Double " +
                              "Data Type  is : {0:E}", Double.MinValue);

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
