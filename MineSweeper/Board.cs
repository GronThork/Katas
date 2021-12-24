using System;
using System.Text;

namespace MineSweeper
{
    public class Board
    {
        private readonly char[,] _fields;
        private readonly int _height;
        private readonly int _width;

        public Board(string input)
        {
            var dataRows = input.Split('\n');
            var boardSize = dataRows[0].Split(' ');
            _height = Convert.ToInt32(boardSize[0]);
            _width = Convert.ToInt32(boardSize[1]);
            var iteration = 0;

            foreach (var row in dataRows)
            {
                if (iteration == 0)
                {
                    _fields = new char[
                        Convert.ToInt32(boardSize[0]), 
                        Convert.ToInt32(boardSize[1])];
                }
                else
                {
                    for (var i = 0; i < row.Length; i++)
                        _fields[iteration-1, i] = row[i];
                }
                iteration++;
            }
        }

        public bool MineIn(Point point)
        {
            if (point.X < 0 || point.X >= _height || point.Y < 0 || point.Y >= _width)
            {
                return false;
            }
            
            return _fields[point.X,point.Y] == '*';
        }

        public int NeighboursMineIn(Point point)
        {
            var countMines = 0;

            for (var x = point.X-1; x <= point.X+1; x++)
            for (var y = point.Y-1; y <= point.Y+1; y++)
                if (MineIn(new Point(x, y)))
                    countMines++;
            
            return countMines;
        }

        public string PrintField()
        {
            StringBuilder fieldWithNeighbours = new();

            for (int x = 0; x < _fields.GetLength(0); x++)
            {
                for (int y = 0; y < _fields.GetLength(1); y++)
                {
                    if (MineIn(new Point(x,y)))
                    {
                        fieldWithNeighbours.Append('*');
                    }
                    else
                    {
                        fieldWithNeighbours.Append(NeighboursMineIn(new Point(x, y)));
                    }
                }

                fieldWithNeighbours.Append('\n');
            }
            
            return fieldWithNeighbours.Remove(fieldWithNeighbours.Length - 1, 1).ToString();;
        }
    }
}