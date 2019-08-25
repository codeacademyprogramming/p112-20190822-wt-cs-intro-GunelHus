using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    class Account
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        public double Amount { get; set; }

        public void addAmount (string amount)
        {
            double newAmountDouble;
            Double.TryParse(amount, out newAmountDouble);
            this.Amount += newAmountDouble;
        }
        public void minusAmount(string amount)
        {
            double newAmountDouble;
            Double.TryParse(amount, out newAmountDouble);
            this.Amount -= newAmountDouble;
        }
    }
}
