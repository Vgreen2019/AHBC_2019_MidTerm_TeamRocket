//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
//{
//    public class PaymentType : IPaymentMethod
//    {
//        public double SubTotal { get; set; }
//        public double SalesTaxTotal { get; set; }
//        public double GrandTotal { get; set; }
//        public object PaymentType { get; private set; }

//        double taxRate = 0.06;

//        public Payment()
//        {
//            SubTotal = subTotal;
//            SalesTaxTotal = salesTaxTotal;
//            GrandTotal = grandTotal;
//            PaymentType = paymentType;
//        }

//        private double SubTotal()
//        {
//            // subtotal = item price * the qty of items
//            subTotal = itemPrice * itemQuantity;
//            // you would want this to return the subtotal

//            return subTotal;
//        }

//        private double SalesTaxTotal()
//        {
//            //sales tax total = subtotal * the taxrate of 6%
//            salesTaxTotal = subTotal * taxRate;
//            return salesTaxTotal;
//        }

//        private double GrandTotal()
//        {
//            // grand total = subtotal + tax total
//            grandTotal = subTotal + salesTaxTotal;
//            return grandTotal;
//        }

//        public void MethodOfPayment(string total)
//        {
//            while (true)
//            {
//                PaymentType = paymentType;
//                switch (paymentType)
//                {
//                    case 1:
//                        ();
//                        return;

//                    case 2:
//                        PayCheck();
//                        return;

//                    case 3:
//                        PayCreditCard();
//                        return;

//                    default:
//                        Console.WriteLine("I'm sorry but we do not accept this form of payment.");
//                        break;
//                }

//            }
//        }

//        //public double AddingTaxRate()
//        //{
//        //** if we decide to do non-taxable items.. maybe rename this method??
//        //}
//    }
//}
