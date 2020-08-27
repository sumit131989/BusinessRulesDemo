using BusinessRulesEngine.Helper;
using BusinessRulesEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.BusinessRules
{
    class PhysicalProductValidation : IBusinessRulesValidation<Payment>
    {
        public void ProvideService(Payment payment)
        {
            if (payment.paymentFor == PaymentFor.PhysicalProduct)
            {
                ServiceHelper.GenerateSlip(Services.Shipping);
                ServiceHelper.GenerateCommision(Services.Agent);
            }
        }
    }
}
