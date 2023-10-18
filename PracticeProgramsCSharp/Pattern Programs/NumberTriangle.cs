using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.Pattern_Programs
{
    class NumberTriangle
    {public static void logic()

        {
        start:
            Console.Clear();
            int[,] arr = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int k = 7; k > i; k--)
                {   //For loop to print spaces
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    if (j == 0 || i == j)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];
                    }
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();



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
