using System;

namespace PracticeProgramsCSharp.String_Programs { 

class Concatinate2Strings
{
    public static void logic()
    {
    start:
        Console.Clear();

        string s1 = "Good";
        string s2 = "Morning";
        string s3 = string.Concat(s1, s2);
        Console.WriteLine(s3);
        Console.ReadLine();


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