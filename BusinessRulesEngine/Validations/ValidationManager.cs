using BusinessRulesEngine.BusinessRules;
using BusinessRulesEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Validations
{
    class ValidationManager
    {
        public void ValidateBusinessRules(IEnumerable<IBusinessRulesValidation<Payment>> rules, Payment payment)
        {
            foreach (var rule in rules)
            {
                rule.ProvideService(payment);
            }
        }
    }
}
