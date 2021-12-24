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

        public int NeigBoursMineIn(Point point)
        {
            var countMines = 0;

            for (var x = point.X-1; x <= point.X+1; x++)
            for (var y = point.Y-1; y <= point.Y+1; y++)
                if (MineIn(new Point(x, y)))
                    countMines++;
            
            return countMines;
        }
    }
}