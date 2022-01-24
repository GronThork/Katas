using System;

namespace MarsRover.Api
{
    public class Position
    {
        private int _x;
        private int _y;

        public Position(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void IncrementY()
        {
            _y++;
        }
        
        public void DecrementY()
        {
            _y--;
        }

        public void IncrementX()
        {
            _x++;
        }
        
        public void DecrementX()
        {
            _x--;
        }

        
        protected bool Equals(Position other)
        {
            return _x == other._x && _y == other._y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Position) obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y);
        }

        public override string ToString()
        {
            return $"{nameof(_x)}: {_x}, {nameof(_y)}: {_y}";
        }
    }
}