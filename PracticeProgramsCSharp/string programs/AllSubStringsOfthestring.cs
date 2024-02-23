using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.String_Programs
{
    // To be debugged!
    internal class AllSubStringsOfthestring
    {

        public static void logic()
        {
        start:
            Console.Clear();
            string value, substring;
            int j, i;
            string[] a = new string[5];
            void input()
            {
                SubString pg = new SubString();
                pg.input();

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
        public class SubString
        {
            string value, substring;
            int j, i;
            string[] a = new string[5];
            public void input()
            {
                Console.WriteLine("Enter the String : ");
                value = Console.ReadLine();
                Console.WriteLine("All Possible Substrings of the Given String are :");
                for (i = 1; i <= value.Length; i++)
                {
                    for (j = 0; j <= value.Length - i; j++)
                    {
                        substring = value.Substring(j, i);
                        a[j] = substring;
                        Console.WriteLine(a[j]);
                    }
                }
            }
        }
    }
}