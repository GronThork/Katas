using System.Collections.Generic;

namespace TennisKata
{
    public class ScoringSystem
    {
        private string _actualScore = "love";
        
        public string Score()
        {
            return _actualScore;
        }

        public void MarkAPoint()
        {
            _actualScore = "15";
        }
    }
}