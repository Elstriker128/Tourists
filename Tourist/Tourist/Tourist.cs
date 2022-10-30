using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist1
{
    public class Tourist
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Budget { get; set; }
        public decimal QuarterBudget { get; set; }

        public Tourist(string name, string surname, decimal budget)
        {
            this.Name = name;
            this.Surname = surname;
            this.Budget = budget;
            this.QuarterBudget = budget / 4;
        }
    }
}
