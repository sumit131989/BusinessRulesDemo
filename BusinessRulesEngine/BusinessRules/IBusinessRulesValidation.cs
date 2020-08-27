using BusinessRulesEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.BusinessRules
{
    interface IBusinessRulesValidation<T> where T: Payment
    {
        void ProvideService(Payment payment);
    }
}
