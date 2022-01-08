namespace TicTacToe
{
    public class Table
    {
        private char _token;

        public char GetTokenPosition(Coordinates coordinates)
        {
            return _token;
        }

        public void Put(Token token, Coordinates coordinates)
        {
            _token = token.GetToken();
        }
    }
}