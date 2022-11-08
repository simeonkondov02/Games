using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesClassLibrary
{
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Genre Genre { get; set; }

        public List<Tag> Tags { get; set; }
    }
}
