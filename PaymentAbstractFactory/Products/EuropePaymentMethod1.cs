using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAbstractFactory.Products
{
    public class EuropePaymentMethod1 : PaymentMethod
    {
        public override string GetMethodName()
        {
            return "SEPA Payment (Europe)";
        }

        public override string GetMethodImagePath()
        {
            return "Images/SEPA.png";
        }
    }
}
