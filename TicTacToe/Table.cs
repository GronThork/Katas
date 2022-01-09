using System.Collections.Generic;

namespace TicTacToe
{
    public class Table
    {
        private readonly Dictionary<Position, Token> _grid;
        private readonly Token _tokenX = new('X');
        private readonly Token _tokenO = new('O');
        
        public char GetTokenPosition(Position position)
        {
            return _grid[position].GetToken();
        }

        public void Put(char token, Position position)
        {
            _grid[position] = token == 'X' ? _tokenX : _tokenO;
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

        public char Winner()
        {
            if (_grid[new Position(0,0)] == _tokenX &&
                _grid[new Position(0,1)] == _tokenX &&
                _grid[new Position(0,2)] == _tokenX)
            {
                return _tokenX.GetToken();
            }
            
            if (_grid[new Position(1,0)] == _tokenX &&
                _grid[new Position(1,1)] == _tokenX &&
                _grid[new Position(1,2)] == _tokenX)
            {
                return _tokenX.GetToken();
            }
            
            if (_grid[new Position(2,0)] == _tokenX &&
                _grid[new Position(2,1)] == _tokenX &&
                _grid[new Position(2,2)] == _tokenX)
            {
                return _tokenX.GetToken();
            }

            return ' ';
        }
    }
}