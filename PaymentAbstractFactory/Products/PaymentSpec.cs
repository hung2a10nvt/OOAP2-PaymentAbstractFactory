using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAbstractFactory.Products
{
    public abstract class PaymentSpec
    {
        public abstract string GetSpecInfo();
    }
}
