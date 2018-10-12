namespace noughtsandcrosses.api.Models
{
    public class Board
    {
        public int BoardId { get; set; }
        public int BoardDimension { get; set; }
        public bool IsTerminal { get; set; }
    }
}
