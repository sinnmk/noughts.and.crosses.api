using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public string BoardState { get; set; }
    }
}
