using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAbstractFactory.Products
{
    public class EuropeSecuritySpec : PaymentSpec
    {
        public override string GetSpecInfo()
        {
            return "GDPR Compliance & PSD2 Strong Customer Authentication (Europe)";
        }
    }
}
