using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Programs_on_Data_type_and_operators
{
    class ConditionalLogicOperator
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter Your Age");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age>= 18 && age<120)
            {
                Console.WriteLine("You Can Vote!");
            }
            else if( age >= 120)
            {
                Console.WriteLine("Pretty Sure You Might be a ghost.");
            }

            else
                Console.WriteLine("You are not yet eligible to vote");

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
