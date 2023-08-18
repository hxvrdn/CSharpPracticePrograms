using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class MultiplicationOfExponentsOfSameBase
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter The Base: ");
            int Base = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Exponent 1 : ");
            int exp1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Exponent 2 : ");
            int exp2 = Convert.ToInt32(Console.ReadLine());

            int exp = exp1 + exp2;

            Console.WriteLine("Result: ({0} ^ {1}) * ({2} ^ {3}) : {4}^{5} = {6}", Base, exp1, Base, exp2, Base,exp, Math.Pow(Base,exp));
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
