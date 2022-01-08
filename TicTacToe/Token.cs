namespace TicTacToe
{
    public class Token
    {
        private readonly char _token;
        public Token(char token)
        {
            _token = token;
        }

        public char GetToken( )
        {
            return _token;
        }
    }
}