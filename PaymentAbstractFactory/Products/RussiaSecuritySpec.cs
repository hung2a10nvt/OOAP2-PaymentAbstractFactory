using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAbstractFactory.Products
{
    public class RussiaSecuritySpec : PaymentSpec
    {
        public override string GetSpecInfo()
        {
            return "Local regulations for card transactions (Mir), data protection in Russia";
        }
    }
}
