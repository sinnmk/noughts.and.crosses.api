using System.ComponentModel.DataAnnotations;

namespace NoughtsAndCrosses.Src.Logic.Dtos
{
    public class PlayerDto
    {
        [Required]
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerLevel { get; set; }
    }
}
