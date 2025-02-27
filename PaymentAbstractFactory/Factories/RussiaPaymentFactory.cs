using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaymentAbstractFactory.Products;

namespace PaymentAbstractFactory.Factories
{
    public class RussiaPaymentFactory : IPaymentFactory
    {
        private Random _random = new Random();

        public PaymentMethod CreatePaymentMethod()
        {
            var methods = new List<PaymentMethod>
            {
                new RussiaPaymentMethod1(),
                new RussiaPaymentMethod2(),
            };

            int index = _random.Next(methods.Count);
            return methods[index];
        }

        public PaymentSpec CreatePaymentSpec()
        {
            return new RussiaSecuritySpec();
        }
    }
}
