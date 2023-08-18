using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgramsCSharp.BasicPrograms
{
    class ArithmeticOperations
    {
        public static void logic()
        {
        start:
            Console.Clear();
            Console.WriteLine("Enter Your Choice?");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("0. For Main Menu");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int num, sum = 0;

                    Console.WriteLine("Press 0 To Exit");
                    Console.WriteLine("Enter a number to add ");
                    num = Convert.ToInt32(Console.ReadLine());

                    while (num != 0)    
                    {
                       
                        sum = sum + num;
                        Console.WriteLine("Total sum: {0}", sum);
                        Console.WriteLine("Enter Value to add");
                        num = Convert.ToInt32(Console.ReadLine());
                        if (num == 0)
                            goto start;
                    }
                    break;

                case 2:
                    
                    Console.WriteLine("Enter a number");
                    int number = Convert.ToInt32(Console.ReadLine());
                    int temp = number;
                    int newsub, total=0;
                    Console.WriteLine("To exit Press 0");
                    while (temp != 0)
                    {
                        Console.WriteLine("Enter an number to substract: ");
                        newsub = Convert.ToInt32(Console.ReadLine());
                        if (newsub == 0)
                        {
                            goto start;
                        }
                        number = number - newsub;
                        Console.WriteLine("Answer: {0} ", number);

                    }
                    break;

                case 3:
                    Console.WriteLine("Enter A Number: ");
                    int mnum = Convert.ToInt32(Console.ReadLine());
                    int mtemp = mnum;
                    Console.WriteLine("To exit Press 0");

                    while (mtemp != 0)
                    {
                        Console.WriteLine("Enter Number to multiply with");
                        int newmnum = Convert.ToInt32(Console.ReadLine());

                        if(newmnum == 0)
                        {
                            goto start;

                        }
                        mnum = mnum * newmnum;
                        Console.WriteLine("Answer: {0}", mnum);
                        

                    }
                    break;

                case 4:
                    Console.WriteLine("Enter A Number: ");
                    double dnum = Convert.ToDouble(Console.ReadLine());
                    double dtemp = dnum;
                    Console.WriteLine("To exit Press 0");
                    while (dtemp != 0)
                    {
                        Console.WriteLine("Enter Number to Divide by");
                        double newdnum = Convert.ToDouble(Console.ReadLine());

                        if (newdnum == 0)
                        {
                            goto start;

                        }

                        dnum = dnum / newdnum;
                        Console.WriteLine("Answer: {0}", dnum);
                    }
                    break;


                case 0:
                    Program.MainMenu();
                    break;


                        default:
                                break; 




            }
        }




    }
}
