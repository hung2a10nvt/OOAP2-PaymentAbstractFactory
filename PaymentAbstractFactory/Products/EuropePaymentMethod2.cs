using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAbstractFactory.Products
{
    public class EuropePaymentMethod2 : PaymentMethod
    {
            public override string GetMethodName()
            {
                return "Credit Card (Visa/MasterCard) - Europe";
            }

            public override string GetMethodImagePath()
            {
                return "Images/Visa.png";
            }
        }
}
