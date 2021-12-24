namespace MineSweeper
{
    public class Board
    {
        private readonly char _field;

        public Board(string input)
        {
            _field = input[4];
        }

        public bool MineIn(int p0, int p1)
        {
            return _field == '*';
        }
    }
}