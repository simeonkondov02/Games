using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesClassLibrary
{
    public class Game
    {
        public Game ()
        {
            Tags = new List<Tag>();

        }

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Genre Genre { get; set; }

        public List<Tag> Tags { get; set; }

        public string GetPriceAndCurrency()
        {
            return this.Price + "USD";
        }
    }
}
