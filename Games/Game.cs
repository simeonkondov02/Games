using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    public class Game
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public Genre Genre { get; set; }

        public List<GameTag> Tags { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Developer { get; set; }

        public float Price { get; set; }
    }
}
