using System.Collections.Generic;

namespace TennisKata
{
    public class ScoringSystem
    {
        private string _actualScore = "love";
        public bool Winner { get; private set; }

        public string Score()
        {
            return _actualScore;
        }

        public void MarkAPoint()
        {
            if (_actualScore == "40")
            {
                Winner = true;
            }

            if (_actualScore == "30")
            {
                _actualScore = "40";
            }

            if (_actualScore == "15")
            {
                _actualScore = "30";
            }
            
            if (_actualScore == "love")
            {
                _actualScore = "15";
            }
        }
    }
}