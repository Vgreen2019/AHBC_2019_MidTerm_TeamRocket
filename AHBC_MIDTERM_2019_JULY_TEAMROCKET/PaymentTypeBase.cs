using System;
using System.Collections.Generic;
using System.Text;

namespace AHBC_MIDTERM_2019_JULY_TEAMROCKET
{
    public abstract class PaymentTypeBase : IPayment
    {
        public string Total { get; set; }

        public void Pay(string total)
        {

        }

    }

}

