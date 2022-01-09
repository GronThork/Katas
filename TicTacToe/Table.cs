using System.Collections.Generic;

namespace TicTacToe
{
    public class Table
    {
        private readonly Dictionary<Position, Token> _grid;

        public char GetTokenPosition(Position position)
        {
            return _grid[position].GetToken();
        }

        public void Put(Token token, Position position)
        {
            _grid[position] = token;
        }

        public Table()
        {
            _grid = new Dictionary<Position, Token>
            {
                {new Position(0, 0), null},
                {new Position(1, 0), null}
            };
        }
    }
}