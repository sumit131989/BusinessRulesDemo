using BusinessRulesEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.BusinessRules
{
    interface IVideosRulesValidation<T, X> where T: Payment where X: Videos
    {
        void ProvideService(Dictionary<Payment, Videos> input);
    }
}
