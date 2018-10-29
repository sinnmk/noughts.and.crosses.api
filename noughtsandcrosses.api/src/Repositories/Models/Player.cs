using System.ComponentModel.DataAnnotations;

namespace noughtsandcrosses.api.Repositories.Models
{
    public class Player
    {
        public Player()
        {

        }
        
        [Key]
        public int PlayerId { get; set; }
        [Required]
        public string PlayerName { get; set; }
        [Required]
        public int PlayerLevel { get; set; }
    }
}
