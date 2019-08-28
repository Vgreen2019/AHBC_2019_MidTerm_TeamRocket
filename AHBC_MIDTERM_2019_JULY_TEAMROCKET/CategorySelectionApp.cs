using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    public class CategorySelectionApp
    {

        StoreInventory loaclInventory = new StoreInventory();
        private int userMenuSelection { get; set; }
        public int itemSelection { get; set; }
        public int qtySelection { get; set; }


        string testSelection;
        string testQTY;

        bool isValid;

        List<StoreItem> currentInventory = new List<StoreItem>();
        List<StoreItem> tempList = new List<StoreItem>();


        public enum localCategory
        {
            Clothes = 1,
            Acccessories = 2,
            Shoes = 3,
            Outerwaer = 4
        }



        //public CategorySelectionApp(int userSelection)
        //{
        //    userMenuSelection = userSelection;
        //}

        public void CategorySelector()
        {
            //localCategory localCategory;

            //currentInventory = loaclInventory.GenerateStoreInventory();

            Console.WriteLine("Which item would you like to purchase? (Select from the folowing numbers)");

            if (userMenuSelection == 1)
            {
                int i = 0;
                foreach (var Categorey in currentInventory)
                {

                    if (Categorey.ItemCategory == "Clothes")
                    {

                        Console.WriteLine($"{i} {Categorey.NameOfItem}\tQTY: {Categorey.ItemQuantity}\tPrice: ${Categorey.ItemPrice}");
                        tempList.Add(Categorey);

                        i++;

                    }
                }
                DislayListOfItems();
            }
            else if (userMenuSelection == 2)
            {
                int i = 0;
                foreach (var Categorey in currentInventory)
                {

                    if (Categorey.ItemCategory == "Accessories")
                    {

                        Console.WriteLine($"{i} {Categorey.NameOfItem}\tQTY: {Categorey.ItemQuantity}\tPrice: ${Categorey.ItemPrice}");
                        tempList.Add(Categorey);

                        i++;

                    }
                }
                DislayListOfItems();
            }
            else if (userMenuSelection == 3)
            {
                int i = 0;
                foreach (var Categorey in currentInventory)
                {

                    if (Categorey.ItemCategory == "Shoes")
                    {

                        Console.WriteLine($"{i} {Categorey.NameOfItem}\tQTY: {Categorey.ItemQuantity}\tPrice: ${Categorey.ItemPrice}");
                        tempList.Add(Categorey);

                        i++;

                    }
                }

                DislayListOfItems();
            }
            else if (userMenuSelection == 4)
            {
                int i = 0;
                foreach (var Categorey in currentInventory)
                {

                    if (Categorey.ItemCategory == "Outerwear")
                    {

                        Console.WriteLine($"{i} {Categorey.NameOfItem}\tQTY: {Categorey.ItemQuantity}\tPrice: ${Categorey.ItemPrice}");
                        tempList.Add(Categorey);

                        i++;

                    }
                }

                DislayListOfItems();
            }
        }

        public void DislayListOfItems()
        {
            testSelection = Console.ReadLine();

            ValidItemChoice();

            Console.Write($"How many {tempList[itemSelection].NameOfItem} would you like to purchase (QTY: {tempList[itemSelection].ItemQuantity}):");

            testQTY = Console.ReadLine();

            ValidQuantityEntered();

            Console.WriteLine($"Great! {qtySelection} {tempList[itemSelection].NameOfItem}s have been added to you shopping cart!");
        }

        public void ValidQuantityEntered()
        {
            do
            {
                if (IntegerValidator.Validate(testQTY))
                {

                    if (int.Parse(testQTY) > 0 && int.Parse(testQTY) < 26)
                    {
                        qtySelection = int.Parse(testQTY);
                        isValid = true;

                    }
                    else
                    {
                        Console.WriteLine("That is not a valid choice, please try again.");
                        testQTY = Console.ReadLine();
                        isValid = false;

                    }


                }
                else
                {

                    Console.WriteLine("That is not a valid choice, please try again.");
                    testQTY = Console.ReadLine();
                    isValid = false;


                }
            } while (!isValid);
        }

        public void ValidItemChoice()
        {
            do
            {
                if (IntegerValidator.Validate(testSelection))
                {

                    if (int.Parse(testSelection) >= 0 && int.Parse(testSelection) < 6)
                    {
                        itemSelection = int.Parse(testSelection);
                        isValid = true;

                    }
                    else
                    {
                        Console.WriteLine("That is not a valid choice, please try again.");
                        testSelection = Console.ReadLine();
                        isValid = false;

                    }


                }
                else
                {

                    Console.WriteLine("That is not a valid choice, please try again.");
                    testSelection = Console.ReadLine();
                    isValid = false;

                }
            } while (!isValid);
        }

    }
}
