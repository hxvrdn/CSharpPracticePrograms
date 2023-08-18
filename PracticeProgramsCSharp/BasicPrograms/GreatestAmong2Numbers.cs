using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class GreatestAmong2Numbers
    {

    public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter the first Number!");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Number!");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2)
            {
                Console.WriteLine("The First Number You entered is Greater : {0}", num1);
            }
            else if(num1 == num2)
            {
                Console.WriteLine("Both the numbers entered are same.");
            }

            else
            {
                Console.WriteLine("The Second Number You entered is Greater : {0}", num2);

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
