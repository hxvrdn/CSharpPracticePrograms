using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Special_CSharp_Programs
{
    class UserAuthenticationexample
    {
        public static void logic()
        {
        start:
            
            char[] username = new char[3] { 'x', 'x', 'x' };
            char[] pass = new char[8] { 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x' };

            char[] authuser = new char[3];
            char[] authpass = new char[8];

            login_signup:
            Console.Clear();
            Console.WriteLine("Press 1 For login \nPress 2 For Signup \nPress 0 To Exit");
            int logsign = Convert.ToInt32(Console.ReadLine());

            if (logsign == 1)
            {

           
                Console.WriteLine("---------------------------------- LOGIN ------------------------------------");
          
                Console.WriteLine("Enter Username: ");
                for (int i = 0; i < 3; i++)
                {
                    authuser[i] = Convert.ToChar(Console.ReadLine());

                }

                Console.WriteLine("Enter Password: ");
                
                for (int i = 0; i < 8; i++)
                {
                    authpass[i] = Convert.ToChar(Console.ReadLine());


                }
                for (int i = 0; i < 3; i++)
                {
                    if (authuser[i] != username[i])
                    {
                        Console.WriteLine("User Name Didn't match any record.");
                        break;
                    }
                }

                Console.WriteLine("Enter Password");
                for (int i = 0; i < 8; i++)
                {
                    if (authpass[i] != pass[i])
                    {
                        Console.WriteLine("Password Didn't match the Username.");
                        break;
                    }
                }
                Console.WriteLine("Login successful!");
                Console.ReadLine();
                goto start;

            }

            if( logsign == 2)
            {
                Console.WriteLine("Enter Username: ");
                for (int i = 0; i < 3; i++)
                {
                    username[i] = Convert.ToChar(Console.ReadLine());

                }

                Console.WriteLine("Enter Password: ");
                char temp = '*';
                for (int i = 0; i < 8; i++)
                {
                    pass[i] = Convert.ToChar(Console.ReadLine());


                }
                goto login_signup;
               
            }
                   


            }
          
        }


 
}
