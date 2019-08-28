using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    class ShoppingMenu
    {
        string initialUserInput = "";
        bool isValid, isNotMenuChoice;
        int startMenuChoice;
        


        public void Run()
        {
            char loopBreaker;
            do
            {
                menuOptions();


                initialUserInput = Console.ReadLine();

                do
                {
                    do
                    {
                        if (IntegerValidator.Validate(initialUserInput))
                        {
                            startMenuChoice = int.Parse(initialUserInput);
                            isValid = true;
                        }
                        else
                        {
                            Console.Clear();
                            menuOptions();
                            initialUserInput = Console.ReadLine();

                            isValid = false;
                        }


                    } while (!isValid);


                    if (startMenuChoice > 0 && startMenuChoice < 5)
                    {
                        


                        //CategorySelectionApp selections = new CategorySelectionApp(startMenuChoice);
                        //selections.categorySelector();
                        isNotMenuChoice = false;


                    }
                    else
                    {

                        Console.Clear();
                        Console.Write("Not a valid option. ");
                        menuOptions();
                        initialUserInput = Console.ReadLine();
                        isNotMenuChoice = true;

                    }

                } while (isNotMenuChoice);



                Console.WriteLine("Do you wish to continue adding items to your cart (enter y/n): "); //ask user to if they want to continue
                loopBreaker = IsValidLoopBreaker(Console.ReadLine()); //storing answer and if it's valid input 

                Console.Read();

            } while (loopBreaker == 'y');




        }


        public void menuOptions()
        {
            Console.WriteLine("Please selecet for the following categories:\n");
            Console.WriteLine("[1] Clothiging\n[2] Accessories\n[3] Shoes\n[4] Outerwear\n");

        }
        public static char IsValidLoopBreaker(string testChar)
        {
            bool isInvalidChar = true;

            Regex pattern = new Regex(@"^[y|n]$");

            char validChar = ' ';

            while (isInvalidChar)
            {
                if (pattern.IsMatch(testChar))
                {
                    isInvalidChar = false;
                    validChar = char.Parse(testChar);
                }
                else
                {
                    Console.WriteLine($"ERROR invalid input of {testChar}  entered please try again");
                    Console.WriteLine("Do you wish to continue(enter y/n): ");
                    testChar = Console.ReadLine();
                }
            }
            return validChar;
        }

    }
}
