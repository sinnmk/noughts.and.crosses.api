using System.ComponentModel.DataAnnotations;

namespace noughtsandcrosses.api.Repositories.Models
{
    public class Board
    {
        public Board()
        {

        }

        [Key]
        public int BoardId { get; set; }
        [Required]
        public int BoardDimension { get; set; }
        [Required]
        public bool IsTerminal { get; set; }
    }
}
