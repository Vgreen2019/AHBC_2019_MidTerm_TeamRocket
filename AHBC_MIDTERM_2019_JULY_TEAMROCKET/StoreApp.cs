using System;
using System.Collections.Generic;
using System.IO;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    public class StoreApp
    {
        //var menu = new Menu() { };
        bool isNotMenuChoice;
        IntegerValidator intergerValidator = new IntegerValidator { };
        bool isValid;
        int startMenuChoice = 0;
        string initalUserInput = "";

        CategorySelectionApp selectCategory = new CategorySelectionApp();



        public void Run()
        {

            Console.WriteLine("Welcome to '@void', your number one stop for the latest in digital fashion!");
            bool ignoreCase2 = true;

            while (true)
            {
                do
                {
                    Console.WriteLine("\nSelect below from the following options:");
                    Console.WriteLine("1. Shop \n2. About \n3. Exit\n");
                    initalUserInput = Console.ReadLine();

                    bool ignoreCase = true;

                    if (Enum.TryParse<InitialUserInput>(initalUserInput, ignoreCase, out InitialUserInput inputResult))
                    {
                        switch (inputResult)
                        {
                            case InitialUserInput.SHOP:
                                Console.Clear();

                                selectCategory.CategorySelector();

                                break;

                            case InitialUserInput.ABOUT:

                                Console.Clear();
                                Console.WriteLine("BIO BIO BIO \nBIO BIO \nBIO!!!");
                                Console.WriteLine("\n(Press ENTER to return to the main menu.)");
                                Console.ReadLine();
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine("It was nice shopping with you! Come again!");
                                break;
                        }
                        Console.Clear();
                        break;


                    }


                    //do
                    //{
                    //    do
                    //    {
                    //        if (IntegerValidator.Validate(initalUserInput))
                    //        {
                    //            startMenuChoice = int.Parse(initalUserInput);
                    //            isValid = true;
                    //        }
                    //        else
                    //        {
                    //            Console.Clear();
                    //            menuOptions();
                    //            initalUserInput = Console.ReadLine();

                    //            isValid = false;
                    //        }


                    //    } while (!isValid);


                    //    switch (startMenuChoice)
                    //    {
                    //        case 1:
                    //            categorySelection.CategorySelector();

                    //            break;

                    //        case 2:
                    //            /// WRITE OUR STORE BIO!!!!
                    //            Console.Clear();
                    //            Console.WriteLine("\n");

                    //            menuOptions();
                    //            initalUserInput = Console.ReadLine();
                    //            isNotMenuChoice = true;
                    //            break;
                    //        case 3:
                    //            Console.Clear();
                    //            Console.WriteLine("Thank you and B#!");
                    //            isNotMenuChoice = false;
                    //            break;

                    //        default:
                    //            Console.Clear();
                    //            Console.Write("Not a valid option. ");
                    //            menuOptions();
                    //            initalUserInput = Console.ReadLine();
                    //            isNotMenuChoice = true;
                    //            break;
                    //    }

                    //} while (isNotMenuChoice);


                    //Console.Read();



                }
                while (!Enum.TryParse<InitialUserInput>(initalUserInput, ignoreCase2, out InitialUserInput inValidInput));


            }
            
        }

        internal void menuOptions()
        {

            Console.WriteLine("Please, selecet below from the following options:\n");
            Console.WriteLine("[1] Shop \n[2] About \n[3] Exit");

        }
        }

        public enum InitialUserInput
        {
            SHOP = 1,
            ABOUT = 2, 
            EXIT = 3
        };



    }
