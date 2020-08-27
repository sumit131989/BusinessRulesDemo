using BusinessRulesEngine.Helper;
using BusinessRulesEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.BusinessRules
{
    class MembershipUpgradeValidation : IBusinessRulesValidation<Payment>
    {
        public void ProvideService(Payment payment)
        {
            if (payment.paymentFor == PaymentFor.MembershipUpgrade)
            {
                ServiceHelper.UpgradeMembership(Services.MembershipOwner);
                ServiceHelper.SendEmailToOwner(Services.MembershipOwner);
            }
        }
    }
}
