using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Special_CSharp_Programs
{
    class PrintWithoutPrintfunction
    {
        public static void logic()
        {
        start:
            Console.Clear();
            if(System.Console.OpenStandardOutput().BeginWrite(new byte[] { 104, 32, 120, 32, 118, 32, 114, 32, 100, 32, 110, 33 , 0 }, 0,
            12, null, null).AsyncWaitHandle.WaitOne())

            {
            }
            if (System.Console.ReadKey().Modifiers == 0)
            {

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
