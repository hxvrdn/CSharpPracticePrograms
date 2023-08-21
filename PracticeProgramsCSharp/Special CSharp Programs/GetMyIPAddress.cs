using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace PracticeProgramsCSharp.Special_CSharp_Programs
{
    class GetMyIPAddress
    {
        public static void logic()
        {
        start:
            Console.Clear();
            String strHostname = String.Empty;
            strHostname = Dns.GetHostName();
            Console.WriteLine("Local machine Host name {0}", strHostname);

            IPHostEntry ipEntry = Dns.GetHostEntry(strHostname);

            IPAddress[] addr = ipEntry.AddressList;
            for (int i = 0; i < addr.Length; i++)
            {
                Console.WriteLine("IP Address {0} : ", addr[i].ToString());
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