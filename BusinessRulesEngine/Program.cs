using BusinessRulesEngine.BusinessRules;
using BusinessRulesEngine.Model;
using BusinessRulesEngine.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payment();
            payment.paymentFor = PaymentFor.WatchVideos;

            var businessRules = new List<IBusinessRulesValidation<Payment>>();
            businessRules.Add(new BookValidation());
            businessRules.Add(new MembershipUpgradeValidation());
            businessRules.Add(new MembershipValidation());
            businessRules.Add(new PhysicalProductValidation());
            businessRules.Add(new VideoValidation());

            var validationManager = new ValidationManager();
            validationManager.ValidateBusinessRules(businessRules, payment);
            Console.ReadLine();
        }
    }
}
