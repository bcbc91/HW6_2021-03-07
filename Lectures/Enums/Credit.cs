using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lectures.Enums
{
    public enum Credit
    {
        [Description("1 Kredi")]
        OneCredit = 1,
        [Description("2 Kredi")]
        TwoCredits = 2,
        [Description("3 Kredi")]
        ThreeCredits = 3,
        [Description("4 Kredi")]
        FourCredits = 4,
        [Description("5 Kredi")]
        FiveCredits = 5

    }
   


}
