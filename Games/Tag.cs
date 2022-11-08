using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Games
{
    public class Tag
    {
        public Tag()
        {
            Games = new List<Game>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("Games")]
        public List<Game> Games { get; set; }
    }
}