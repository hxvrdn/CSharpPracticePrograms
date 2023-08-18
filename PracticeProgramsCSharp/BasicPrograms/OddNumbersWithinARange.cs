using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class OddNumbersWithinARange
    {
        public 
            static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the Range Start:");
            int startrange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Range Size:");
            int endrange = Convert.ToInt32(Console.ReadLine());

            IEnumerable<int> OddNumbers = Enumerable.Range(startrange, endrange).Where(x => x % 2 != 0);
            
            Console.WriteLine("Odd Numbers in the given range are:");
            foreach(int n in OddNumbers)
            {
                Console.WriteLine(n);
            }


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
