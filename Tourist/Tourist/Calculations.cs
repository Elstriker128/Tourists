using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.CodeAnalysis;

namespace Tourist1
{
    public class Calculations
    {
        public static decimal CalculationsForMoney(List<Tourist> Tourists)
        {
            decimal sum = 0;
            foreach (Tourist tourist in Tourists)
            {
                sum+= tourist.QuarterBudget;              

            }
            return sum;
        }
        public static List<Tourist> FindingTheBigestValueAndItsTourists(List<Tourist> Tourists)
        {
            decimal biggest = 0;
            foreach (Tourist tourist in Tourists)
            {
                if (tourist.QuarterBudget > biggest)
                {
                    biggest = tourist.QuarterBudget;
                }
            }
            List<Tourist> result = new List<Tourist>();
            foreach (Tourist tourist in Tourists)
            {
                if (tourist.QuarterBudget == biggest)
                {
                    result.Add(tourist);
                }
            }
            return result;
        }
    }
}
