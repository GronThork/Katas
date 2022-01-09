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
                {new Position(0, 0), new Token(' ')},
                {new Position(0, 1), new Token(' ')},
                {new Position(0, 2), new Token(' ')},
                {new Position(1, 0), new Token(' ')},
                {new Position(1, 1), new Token(' ')},
                {new Position(1, 2), new Token(' ')},
                {new Position(2, 0), new Token(' ')},
                {new Position(2, 1), new Token(' ')},
                {new Position(2, 2), new Token(' ')}
            };
        }
    }
}