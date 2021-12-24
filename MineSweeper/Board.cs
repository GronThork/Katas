namespace MineSweeper
{
    public class Board
    {
        private readonly char[,] _field;

        public Board(string input)
        {
            var dataRows = input.Split('\n');
            var iteration = 0;

            foreach (var row in dataRows)
            {
                if (iteration == 0)
                {
                    _field = new char[row[0], row[1]];
                }
                else
                {
                    for (int i = 0; i < row.Length; i++)
                        _field[iteration-1, i] = row[i];
                }
                iteration++;
            }
        }

        public bool MineIn(Point point)
        {
            return _field[point.X,point.Y] == '*';
        }

        public int MineNeigBoursIn(Point point)
        {
            throw new System.NotImplementedException();
        }
    }
}