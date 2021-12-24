namespace MineSweeper
{
    public class Game
    {
        private readonly Board _board;

        public Game(string input)
        {
            _board = new Board(input);
        }

        public string PrintFields()
        {
            return "Field #1:\n" + _board.PrintField();
        }
    }
}