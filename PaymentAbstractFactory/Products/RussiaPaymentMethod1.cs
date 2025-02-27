using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAbstractFactory.Products
{
    public class RussiaPaymentMethod1 : PaymentMethod
    {
        public override string GetMethodName()
        {
            return "Credit Card / Mir Card (Russia)";
        }

        public override string GetMethodImagePath()
        {
            return "Images/MIR.png";
        }
    }
}
