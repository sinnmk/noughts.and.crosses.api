using System.ComponentModel.DataAnnotations;

namespace NoughtsAndCrosses.Server.Src.Repositories.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public bool IsGameOver { get; set; }
        [Required]
        public bool IsGameWon { get; set; }
    }
}
