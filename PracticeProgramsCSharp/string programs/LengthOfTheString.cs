using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.String_Programs
{
    class LengthOfTheString { 
    public static void logic()
    {
    start:
        Console.Clear();
        string s1 = "Computer";
        Console.WriteLine("The Length of the First String is : " + s1.Length);
        string s2 = "";
        Console.WriteLine("The Length of the Second String is : " + s2.Length);

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
