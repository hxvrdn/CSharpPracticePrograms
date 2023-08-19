using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Programs_on_Data_type_and_operators
{
    class MaximumRangeOfDataTypes
    {
        public static void logic()
        {
        start:
            Console.Clear();

            Console.WriteLine("The maximum Range of the Decimal Data " +
                                          "Type is : {0} ", Decimal.MaxValue);
            Console.WriteLine("The maximum Range of the Float Data " +
                              "Type is : {0} ", Single.MaxValue);
            Console.WriteLine("The maximum Range of the Decimal Data " +
                              "Type is : {0} ", Double.MaxValue);
            Console.WriteLine("Exponent Form : The maximum Range of Decimal " +
                              "Data Type  is : {0:E}", Decimal.MaxValue);
            Console.WriteLine("Exponent Form : The maximum Range of Float " +
                              "Data Type  is : {0:E}", Single.MaxValue);
            Console.WriteLine("Exponent Form : The maximum Range of Double " +
                              "Data Type  is : {0:E}", Double.MaxValue);

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
