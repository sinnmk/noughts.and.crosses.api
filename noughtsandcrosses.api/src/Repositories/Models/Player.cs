using System.ComponentModel.DataAnnotations;

namespace NoughtsAndCrosses.Src.Repositories.Models
{
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Required]
        public string PlayerName { get; set; }
        [Required]
        public int PlayerLevel { get; set; }
    }
}
