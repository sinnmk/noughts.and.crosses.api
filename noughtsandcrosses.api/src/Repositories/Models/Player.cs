using System.ComponentModel.DataAnnotations;

namespace noughtsandcrosses.api.Models
{
    public class Player
    {
        [Required]
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerLevel { get; set; }
    }
}
