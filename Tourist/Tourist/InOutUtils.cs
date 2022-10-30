using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace Tourist1
{
    public class InOutUtils
    {
        public static List<Tourist> ReadTourists(string filename)
        {
            List<Tourist> Tourists = new List<Tourist>();
            string[] lines = File.ReadAllLines(filename, Encoding.UTF8);
            foreach (string line in lines)
            {
                string[] Values = line.Split(';');
                string name = Values[0];
                string surname = Values[1];
                decimal budget = decimal.Parse(Values[2]);

                Tourist tourist = new Tourist(name, surname, budget);
                Tourists.Add(tourist);
            }
            return Tourists;
        }
        public static void PrintTourists(List<Tourist> Tourists)
        {
            Console.WriteLine(new string('-', 48));
            Console.WriteLine("| {0,-15} | {1,-15} | {2,8} |", "Name", "Surname", "Budget");
            Console.WriteLine(new string('-', 48));
            foreach (Tourist tourist in Tourists)
            {
                Console.WriteLine("| {0,-15} | {1,-15} | {2,8:f} |", tourist.Name, tourist.Surname, tourist.Budget);
            }
            Console.WriteLine(new string('-', 48));
        }
        public static void PrintFullSum(decimal sum)
        {
            Console.WriteLine(new string('-', 48));
            Console.WriteLine("Everyone's contribution: {0:f2}", sum);
            Console.WriteLine(new string('-', 48));
        }
        public static void PrintBiggestContributors(List<Tourist> result)
        {
            Console.WriteLine(new string('-', 48));
            Console.WriteLine("The biggest contributor(-s): ");
            Console.WriteLine(new string('-', 48));
            foreach (Tourist tourist in result)
            {
                Console.WriteLine(" | {0,-15} | {1,-15} | {2:f2} |", tourist.Name, tourist.Surname, tourist.QuarterBudget);
            }
            Console.WriteLine(new string('-', 48));
        }

    }
}
