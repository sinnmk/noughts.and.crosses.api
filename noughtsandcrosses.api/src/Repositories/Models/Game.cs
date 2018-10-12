using System.ComponentModel.DataAnnotations;

namespace noughtsandcrosses.api.Models
{
    public class Game
    {
        [Required]
        public int GameId { get; set; }
        public bool IsGameOver { get; set; }
        public bool IsGameWon { get; set; }
    }
}
