﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    public class Receipt
    {
        public double ReceiptGrandTotal { get; set; }
        public double ReceiptSubTotal { get; set; }
        public List<StoreItem> UserShoppingCart { get; set; }
        //public Payment userPayments { get; set; }

        public Receipt(double feedTotal, double feedSubTotal, List<StoreItem> shoppingItems/* Payment userPa*/)
        {
            ReceiptGrandTotal = feedTotal;
            ReceiptSubTotal = feedSubTotal;
            UserShoppingCart = shoppingItems;
            //userPayments.SubTotal = userPay.SubTotal;
            //userPayments.GrandTotal = userPay.GrandTotal;
            
        }

        public void PrintReceipt()
        {
            int i = 1;
            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Printing Recepit for you.....");
            foreach (var item in UserShoppingCart)
            {
                //Console.WriteLine($"{item.NameOfItem}");
                //Console.WriteLine($"{item.ItemCategory}");
                //Console.WriteLine($"{item.ItemQuantity}");
                Console.WriteLine($"{i} {item.NameOfItem}\tQTY: {item.ItemCategory}\tQuantity: {item.ItemQuantity}");
                i++;
            }
            Console.WriteLine($"Subtotal: {/*userPayments.SubTotal*/ ReceiptSubTotal}");
            Console.WriteLine($"GrandTotal: {/*userPayments.GrandTotal*/ReceiptGrandTotal}");
        }
    }
}
