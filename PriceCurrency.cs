using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesClassLibrary
{
    public class PriceCurrency
    {
        public PriceCurrency (decimal price)
        {
            this.Price = price;
            this.Currency = "USD";
        }

        public decimal Price { get; set; }

        public string Currency { get; set; }

        public string GetPrice()
        {
            return this.Price + this.Currency;
        }
    }
}
