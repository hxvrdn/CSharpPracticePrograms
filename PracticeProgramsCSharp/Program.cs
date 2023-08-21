using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticeProgramsCSharp
 
{
   public  class Program
    {
        static void Main(string[] args)

        {
            MainMenu();
        }
        public static void MainMenu()
        {
        mainMenu:
            Console.Clear();
            Console.WriteLine(" W E L C O M E !");
            Console.WriteLine("Program Scope? : ");
            Console.WriteLine("1. Basic Programs ");
            Console.WriteLine("2. Data Type & Operation Programs");
            Console.WriteLine("3. Programs On Numbers");

            int choice = Convert.ToInt32(Console.ReadLine());



            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Choose a program! \n -------------------------------------------------- ");
                    Console.WriteLine("1. Check Wether Number entered is even or odd?");
                    Console.WriteLine("2. Print Odd Numbers within the given Range");
                    Console.WriteLine("3. Check wether the number is positive?");
                    Console.WriteLine("4. Greatest among 2 Numbers?");
                    Console.WriteLine("5. Swap 2 Numbers?");
                    Console.WriteLine("6. Check weather Number is Divisible by 2 Or Not");
                    Console.WriteLine("7. Sum Of Multiples of X and Y");
                    Console.WriteLine("8. Multiples of X Within the Range");
                    Console.WriteLine("9. Sum of individual digits in a number");
                    Console.WriteLine("10. Sum of individual digits in a number using Recursion");
                    Console.WriteLine("11. Get a Number and Reverse it?");
                    Console.WriteLine("12. Reverse a number and check if it is pallindrome");
                    Console.WriteLine("13. Find The Sum of 2 Bindary Numbers?");
                    Console.WriteLine("14. Find The Multiplication of 2 Binary Numbers");
                    Console.WriteLine("15. Basic Arithematic Operations (CALCULATOR)");
                    Console.WriteLine("16. Multiplication of exponents of same base?");
                    Console.WriteLine("17. Division of Exponents of same Base?");
                    Console.WriteLine("18. Binary Equivalent of Integers Using Recursion");
                    Console.WriteLine("19. Multiplication Table");
                    Console.WriteLine("20. Convert Character Casing to current opposite");
                    Console.WriteLine("0 for Main Menu");



                    int basisChoice = Convert.ToInt32(Console.ReadLine());
                    switch (basisChoice)
                    {

                        case 0:
                            goto mainMenu;
                            break;

                        case 1:
                            BasicPrograms.GivenNumberIsEvenOrOdd.logic();
                            break;

                        case 2:
                            BasicPrograms.OddNumbersWithinARange.logic();
                            break;

                        case 3:
                            BasicPrograms.GivenNumberIsPositiveOrNot.logic();
                            break;

                        case 4:
                            BasicPrograms.GreatestAmong2Numbers.logic();
                            break;

                        case 5:
                            BasicPrograms.SwapTwoNumbers.logic();
                            break;

                        case 6:
                            BasicPrograms.DivisibleBy2OrNot.logic();
                            break;

                        case 7:
                            BasicPrograms.SumOfMultiplesOfXAndY.logic();
                            break;

                        case 8:
                            BasicPrograms.PrintMultiplesOfXwithinrange.logic();
                            break;

                        case 9:
                            BasicPrograms.SumOfIndividualDigitsOfANumber.logic();
                            break;

                        case 10:
                            BasicPrograms.SumOfIndividualDigitsOfANumberUsingrecursion.logic();
                            break;

                        case 11:
                            BasicPrograms.TakeANumberAndReverseIt.logic();
                            break;

                        case 12:
                            BasicPrograms.ReverseAnumberAndCheckIfItIsPallindrome.logic();
                            break;

                        case 13:
                            BasicPrograms.SumOfTwoBinarNumbers.logic();
                            break;

                        case 14:
                            BasicPrograms.MultiplicationOfTwoBinaryNumbers.logic();
                            break;


                        case 15:
                            BasicPrograms.ArithmeticOperations.logic();
                            break;

                        case 16:
                            BasicPrograms.MultiplicationOfExponentsOfSameBase.logic();
                            break;

                        case 17:
                            BasicPrograms.DivisionOfExponentsOfSameBase.logic();
                            break;

                        case 18:
                            BasicPrograms.BinaryEquivalentOfAInteger.logic();
                            break;

                        case 19:
                            BasicPrograms.MultiplicationTable.logic();
                            break;

                        case 20:
                            BasicPrograms.ConverCharacterCasingToOpposite.logic();
                            break;




                    }
                    break;


                case 2:
                    Console.Clear();
                    Console.WriteLine("Choose a program! \n -------------------------------------------------- ");
                    Console.WriteLine("1.Minimum Values Of DataTypes.");
                    Console.WriteLine("2.Maximum Values Of DataTypes.");
                    Console.WriteLine("3.Arithmetic Operations.  ");
                    Console.WriteLine("4.Conditional Logical Operator ");
                    Console.WriteLine("5.Boxing Operation ");
                    Console.WriteLine("6.Unboxing Operation");

                    int datatypeChoice = Convert.ToInt32(Console.ReadLine());

                    switch(datatypeChoice)
                    {
                        case 1:
                            Programs_on_Data_type_and_operators.MinimumRangeOfValuesOfDataTypes.logic();
                            break;

                        case 2:
                            Programs_on_Data_type_and_operators.MaximumRangeOfDataTypes.logic();
                            break;

                        case 3:
                            Programs_on_Data_type_and_operators.ArithmeticOperations.logic();
                            break;

                        case 4:
                            Programs_on_Data_type_and_operators.ConditionalLogicOperator.logic();
                            break;

                        case 5:
                            Programs_on_Data_type_and_operators.BoxingOperations.logic();
                            break;

                        case 6:
                            Programs_on_Data_type_and_operators.UnboxingOperations.logic();
                            break;


                    }

                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("1. Fibonacci Series");
                    Console.WriteLine("2. Factorial of A number");
                    Console.WriteLine("3. Prime Numbers in a range");
                    Console.WriteLine("4. Largest Prime Factor");
                    Console.WriteLine("5. Check for Perfect Number");
                    Console.WriteLine("6. Check for Armstrong Number");
                    Console.WriteLine("7. Print Armstrong Numbers");
                    Console.WriteLine("8. Sum of N Numbers");
                    Console.WriteLine("9. Print Natural Numbers in a Range");







                    int numprogChoice = Convert.ToInt32(Console.ReadLine());
                    switch(numprogChoice)
                    {
                        case 1:
                            Program_On_Numbers.FibonacciSeries.logic();
                            break;

                        case 2:
                            Program_On_Numbers.FactorialOfAGivenNumber.logic();
                            break;

                        case 3:
                            Program_On_Numbers.PrimeNumber.logic();
                            break;

                        case 4:
                            Program_On_Numbers.LargestPrimeFactor.logic();
                            break;

                        case 5:
                            Program_On_Numbers.PerfecctNumber.logic();
                            break;

                        case 6:
                            Program_On_Numbers.ArmstrongNumber.logic();
                            break;

                        case 7:
                            Program_On_Numbers.PrintArmstrongNumbersInARange.logic();
                            break;

                        case 8:
                            Program_On_Numbers.SumOfNNumbers.logic();
                            break;

                        case 9:
                            Program_On_Numbers.PrintNaturalNumbersInRange.logic();
                            break;
                    }
                    break;
            }
        }
    }
}
