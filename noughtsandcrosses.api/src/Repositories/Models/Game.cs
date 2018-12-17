using System.ComponentModel.DataAnnotations;

namespace noughtsandcrosses.api.Repositories.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public int TurnChoice { get; set; }
        [Required]
        public int GameLevel { get; set; }
        public int BoardDimension { get; set; }
        [Required]
        public bool IsGameOver { get; set; }
        public bool IsGameWon { get; set; }
    }
}
