using System;
using System.Collections.Generic;
using System.Text;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    class IntegerValidator
    {
        private string _inputString { get; set; }
        private bool _outputInt { get; set; }

        public static bool Validate(string intInQuestion)
        {
            bool temp = int.TryParse(intInQuestion, out int result);
            if (!temp)
            {
                Console.Clear();
                Console.Write("That is not a valid option. ");
            }

            return temp;



        }





    }
}
