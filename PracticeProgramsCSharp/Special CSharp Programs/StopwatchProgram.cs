using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Special_CSharp_Programs
{
    class StopwatchProgram
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Press X to start");
            char con = Convert.ToChar(Console.ReadLine());
            Stopwatch s = new Stopwatch();
            if (con == 'x' || con == 'X')
            {
                s.Start();
                Console.WriteLine("Press X to Stop");
               
                con = 'z';
              
                while(con != 'x' || con != 'X')
                {

                    Console.WriteLine("Time Elapsed : {0}", s.Elapsed);
                    con = Convert.ToChar(Console.ReadLine());
                    if (con == 'x' || con == 'X')
                    {
                        break;
                    }
                }
                s.Stop();
                Console.WriteLine("TIME ELAPSED : {0}", s.Elapsed);
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
}
