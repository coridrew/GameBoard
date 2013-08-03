namespace GameBoard.UI.Models
{
    public class Game
    {
        public string Name { get; set; }
    }

    public class Board
    {
        public Game Game { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}