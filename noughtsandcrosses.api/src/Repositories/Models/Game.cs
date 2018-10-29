using System.ComponentModel.DataAnnotations;

namespace noughtsandcrosses.api.Repositories.Models
{
    public class Game
    {
        public Game()
        {

        }

        [Key]
        public int GameId { get; set; }
        [Required]
        public bool IsGameOver { get; set; }
        [Required]
        public bool IsGameWon { get; set; }
    }
}
