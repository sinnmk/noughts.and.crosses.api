using System.ComponentModel.DataAnnotations;

namespace NoughtsAndCrosses.Src.Repositories.Models
{
    public class Board
    {
        [Key]
        public int BoardId { get; set; }
        [Required]
        public int BoardDimension { get; set; }
        [Required]
        public bool IsTerminal { get; set; }
        public string BoardState { get; set; }
    }
}
