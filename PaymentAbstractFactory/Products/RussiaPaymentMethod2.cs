using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAbstractFactory.Products
{
    public class RussiaPaymentMethod2 : PaymentMethod
    {
        public override string GetMethodName()
        {
            return "SBP (СБП) - Russia";
        }

        public override string GetMethodImagePath()
        {
            return "Images/SBP.png";
        }
    }
}
