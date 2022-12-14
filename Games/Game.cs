using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games
{
    public class Game
    {
        public Game ()
        {
            Tags = new List<Tag>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [ForeignKey("Tags")]
        public List<Tag> Tags { get; set; }
    }
}
