using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{

    public class Check : IPaymentMethod
    {
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }


        public new void Pay(string total)
        {
            Console.WriteLine($"Total: {total}\n"); //might not need based on how user interface is set up

            Console.WriteLine("Check Number:\n");     //validation
            string checkNum = ValidateCheckNumber(Console.ReadLine());

            Console.WriteLine("Routing Number:\n");     //validation
            string routeNum = ValidateRouteNumber(Console.ReadLine());

            Console.WriteLine("Your transaction has been processed.");

        }

        private string ValidateRouteNumber(string routeNum)
        {
            Regex rgx = new Regex(@"^(\w[0-9]{8})$");

            if (rgx.IsMatch(routeNum))
            {
                return routeNum;
            }
            else
            {
                do
                {


                    Console.WriteLine("This is not a valid routing number. Please re-enter.");
                    Console.WriteLine("\nRouting Number:");
                    routeNum = (Console.ReadLine());

                }
                while (!rgx.IsMatch(routeNum));

                return routeNum;

            }
        }

        private string ValidateCheckNumber(string checkNum)
        {
            Regex rgx = new Regex(@"^(\w[0-9]{9,11})$");

            if (rgx.IsMatch(checkNum))
            {
                return checkNum;
            }
            else
            {
                do
                {


                    Console.WriteLine("This is not a valid check number. Please re-enter.");
                    Console.WriteLine("\nCheck Number:");
                    checkNum = (Console.ReadLine());

                }
                while (!rgx.IsMatch(checkNum));

                return checkNum;

            }

        }

    }

}
