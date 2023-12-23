using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana05.Models
{
    public class Currency
    {
        public Currency(string name, decimal exRate)
        {
            this.name = name;
            this.exRate = exRate;
        }
        public Currency(string name)
        {
            this.name = name;
        }
        public Currency(Currency currency) : this(currency.name, currency.exRate) { }
        public Currency() { }

        protected string name;
        protected decimal exRate;
    }
}
