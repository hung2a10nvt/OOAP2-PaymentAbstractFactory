using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAbstractFactory.Products
{
    public abstract class PaymentMethod
    {
        public abstract string GetMethodName();
        public abstract string GetMethodImagePath();
    }
}
