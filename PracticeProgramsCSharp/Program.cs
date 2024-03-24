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
            Console.WriteLine("4. Date Time And Year Programs");
            Console.WriteLine("5. Special Programs");
            Console.WriteLine("6. Conversion Programs");
            Console.WriteLine("7. Pattern Programs");
            Console.WriteLine("8. GCD LCH HCF Programs");
            Console.WriteLine("9. Array Programs" );
            Console.WriteLine("10. Matrix Programs");
            Console.WriteLine("11. String Manipulation Programs");
            Console.WriteLine("12. Sorting Programs");







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

                    switch (datatypeChoice)
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
                    Console.WriteLine("10. Factors of a given number");
                    Console.WriteLine("11. Absolute of a given number");
                    Console.WriteLine("12. Check if The numbers are amicable");
                    Console.WriteLine("13. Square Root of A number");
                    Console.WriteLine("14. Cube root of A number");
                    Console.WriteLine("15. Reverse A number");

                    int numprogChoice = Convert.ToInt32(Console.ReadLine());
                    switch (numprogChoice)
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

                        case 10:
                            Program_On_Numbers.FactorsOfAGivenNumber.logic();
                            break;

                        case 11:
                            Program_On_Numbers.AbsoluteValueOfANumber.logic();
                            break;

                        case 12:
                            Program_On_Numbers.AmicableNumbers.logic();
                            break;

                        case 13:
                            Program_On_Numbers.SquareRootOfANumber.logic();
                            break;

                        case 14:
                            Program_On_Numbers.CubeRootOfANumber.logic();
                            break;

                        case 15:
                            Program_On_Numbers.TakeANumberAndReverseIt.logic();
                            break;

                    }
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("1. Get local Time");
                    Console.WriteLine("2. Get Universal Time");
                    Console.WriteLine("3. Date In Various Formats");
                    Console.WriteLine("4. Add Two dates");
                    Console.WriteLine("5. Compare two Dates");
                    Console.WriteLine("6. Check For Leap Year");
                    Console.WriteLine("7. Convert Days To years and Weeks");
                    Console.WriteLine("8. Get The Daylight Saving Information");


                    int DateTimeYearChoice = Convert.ToInt32(Console.ReadLine());

                    switch (DateTimeYearChoice)
                    {
                        case 1:
                            Date_Time_and_Year_Programs.GetTheLocalTime.logic();
                            break;

                        case 2:
                            Date_Time_and_Year_Programs.GettheUniversalTime.logic();
                            break;

                        case 3:
                            Date_Time_and_Year_Programs.DatesInVariousFormats.logic();
                            break;

                        case 4:
                            Date_Time_and_Year_Programs.AddTwoDates.logic();
                            break;

                        case 5:
                            Date_Time_and_Year_Programs.CompareTwodates.logic();
                            break;

                        case 6:
                            Date_Time_and_Year_Programs.LeapYearProgram.logic();
                            break;

                        case 7:
                            Date_Time_and_Year_Programs.ConvertDaysToYearsMonthsWeek.logic();
                            break;

                        case 8:
                            Date_Time_and_Year_Programs.GetTheDaylightSavingInformation.logic();
                            break;

                    }

                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("1. Print without Print Function");
                    Console.WriteLine("2. ATM Prompt");
                    Console.WriteLine("3. My IP Address.");
                    Console.WriteLine("4. User Authentication Example.");
                    Console.WriteLine("5. Stopwatch");




                    int SpecChoice = Convert.ToInt32(Console.ReadLine());

                    switch (SpecChoice)
                    {
                        case 1:
                            Special_CSharp_Programs.PrintWithoutPrintfunction.logic();
                            break;

                        case 2:
                            Special_CSharp_Programs.ATMProgram.logic();
                            break;


                        case 3:
                            Special_CSharp_Programs.GetMyIPAddress.logic();
                            break;

                        case 4:
                            Special_CSharp_Programs.UserAuthenticationexample.logic();
                            break;

                        case 5:
                            Special_CSharp_Programs.StopwatchProgram.logic();
                            break;

                    }
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("1. Convert Binary to Decimal");
                    Console.WriteLine("2. Convert Decimal to Binary");
                    Console.WriteLine("3. Convert Decimal to HexaDecimal");
                    Console.WriteLine("4. Convert HexaDecimal to Decimal");
                    Console.WriteLine("5. Convert Celsius to Fahrenheit");
                    Console.WriteLine("6. Convert Fahrenheit to Celsius");



                    int convChoice = Convert.ToInt32(Console.ReadLine());

                    switch (convChoice)
                    {
                        case 1:
                            ConversionPrograms.BinaryToDecimal.logic();
                            break;

                        case 2:
                            ConversionPrograms.DecimalToBinary.logic();
                            break;

                        case 3:
                            ConversionPrograms.DecimalToHexaDecimal.logic();
                            break;

                        case 4:
                            ConversionPrograms.HexaDecuimalToDecimal.logic();
                            break;

                        case 5:
                            ConversionPrograms.CelsiusToFahreneit.logic();
                            break;

                        case 6:
                            ConversionPrograms.FahrenheitToCelsius.logic();
                            break;

                    }

                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("1. Pascal Triangle");
                    Console.WriteLine("2. Binary Tree");
                    Console.WriteLine("3. Diamond Pattern");
                    Console.WriteLine("4. Floyd's Triangle");
                    Console.WriteLine("5. Number Triangle");





                    int pattChoice = Convert.ToInt32(Console.ReadLine());

                    switch (pattChoice)
                    {
                        case 1:
                            Pattern_Programs.PascalTriangle.logic();
                            break;

                        case 2:
                            Pattern_Programs.BinaryTree.logic();
                            break;

                        case 3:
                            Pattern_Programs.Diamond.logic();
                            break;

                        case 4:
                            Pattern_Programs.FloydTriangle.logic();
                            break;

                        case 5:
                            Pattern_Programs.NumberTriangle.logic();
                            break;

                    }
                    break;


                case 8:
                    Console.Clear();
                    Console.WriteLine("1. GCD of two numbers.");

                    int gcdlcm_choice = Convert.ToInt32(Console.ReadLine());

                    switch (gcdlcm_choice)
                    {
                        case 1:
                            GCD_LCM_HCF_Programs.GCDofTwoNumbers.logic();
                            break;
                    }
                    break;


                case 9:
                    Console.Clear();
                    Console.WriteLine("1. Length Of an Array");
                    Console.WriteLine("2. Reverse an Array");
                    Console.WriteLine("3. Lower and upper bounds an Array");
                    Console.WriteLine("4. Jagged Array");





                    int arr_prgm = Convert.ToInt32(Console.ReadLine());

                    switch (arr_prgm)
                    {
                        case 1:
                            Array_Programs.LengthOfAnArray.logic();
                            break;

                        case 2:
                            Array_Programs.ReverseAnArray.logic();
                            break;

                        case 3:
                            Array_Programs.LowerBoundAndUpperBound.logic();
                            break;

                        case 4:
                            Array_Programs.JaggedArrays.logic();
                            break;
                    }
                    break;

                case 10:
                    Console.Clear();
                    Console.WriteLine("1. Smallest Element in a Matrix");
                    Console.WriteLine("2. Largest Element in a Matrix");
                    Console.WriteLine("3. Addition Of Two Matrices");




                    int mtxr_choice = Convert.ToInt32(Console.ReadLine());

                    switch (mtxr_choice)
                    {

                        case 1:

                            Matrix_Programs.SmallestElementInMatrix.logic();
                            break;

                        case 2:

                            Matrix_Programs.LargestElementInAMatrix.logic();
                            break;

                        case 3:

                            Matrix_Programs.AdditionOfTwoMatrices.logic();
                            break;


                        default:
                            break;
                    }

                    break;

                    ;
                case 11:
                    Console.Clear();
                    Console.WriteLine("1. Concatinate two strings");
                    Console.WriteLine("2. UpperCase To lower case");
                    Console.WriteLine("3. Trim String");
                    Console.WriteLine("4. Length of the String");
                    Console.WriteLine("5. All substrings of the String");


                    int str_choice = Convert.ToInt32(Console.ReadLine());
                    switch (str_choice)
                    {
                        case 1:
                            String_Programs.Concatinate2Strings.logic(); break;

                        case 2:
                            String_Programs.UpperCaseToLower.logic(); break;

                        case 3:
                            String_Programs.TrimString.logic(); break;

                        case 4:
                            String_Programs.LengthOfTheString.logic(); break;

                        case 5:
                            String_Programs.AllSubStringsOfthestring.logic(); break;


                    }
                    break;

                case 12:
                    Console.Clear();
                    Console.WriteLine("1. Insertion Sort");
                    Console.WriteLine("2. Selection Sort");

                    int Sort_choice = Convert.ToInt32(Console.ReadLine());
                    switch (Sort_choice)
                    {
                        case 1:
                            Sorting_Programs.InsertionSort.logic(); break;

                        case 2:
                            Sorting_Programs.SelectionSort.logic(); break;

                        default: break;
                    }

                    break;
            }
        }
    }
}
