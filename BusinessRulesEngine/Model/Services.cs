using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Model
{
    public enum Services
    {
        [Description("Shipping")]
        Shipping,
        [Description("Royality department")]
        RoyaltyDepartment,
        [Description("Membership owner")]
        MembershipOwner,
        [Description("Agent")]
        Agent

    }
}
