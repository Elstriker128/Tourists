using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tourist1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Tourist> Tourists = InOutUtils.ReadTourists(@"Tourists.csv");
            Console.WriteLine("Tourist information");
            InOutUtils.PrintTourists(Tourists);
            InOutUtils.PrintFullSum(Calculations.CalculationsForMoney(Tourists));
            InOutUtils.PrintBiggestContributors(Calculations.FindingTheBigestValueAndItsTourists(Tourists));
        }
    }
}