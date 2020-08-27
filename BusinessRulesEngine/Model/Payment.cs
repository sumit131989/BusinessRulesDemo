using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Model
{
    class Payment
    {
        public PaymentFor paymentFor { get; set; }
        public VideoCategories videoCategory { get; set; }
    }
}
