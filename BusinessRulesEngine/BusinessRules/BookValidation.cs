using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Helper;
using BusinessRulesEngine.Model;

namespace BusinessRulesEngine.BusinessRules
{
    class BookValidation : IBusinessRulesValidation<Payment>
    {
        public void ProvideService(Payment payment)
        {
            if (payment.paymentFor == PaymentFor.Book)
            {
                ServiceHelper.CreateDuplicateSlip(Services.RoyaltyDepartment);
                ServiceHelper.GenerateCommision(Services.Agent);
            }
        }
    }
}
