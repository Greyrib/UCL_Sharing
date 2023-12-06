using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp_Fredag_01_12_2023
{
    public class Bonuses
    {
        public static double TenPercent (double amount)
        {
            double percentage = amount * 0.1;
            return percentage;
        }

        public static double FlatTwoIfAmountMoreThanFive (double amount)
        {
            double result = 0;
            if (amount > 5)
                result = 2;
            return result;
        }
    }
}
