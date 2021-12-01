using System.Collections.Generic;

namespace TennisKata
{
    public class ScoringSystem
    {
        private string _actualScore = "love";
        private bool _winner;

        public string Score()
        {
            return _actualScore;
        }

        public void MarkAPoint()
        {
            if (_actualScore == "40")
            {
                _winner = true;
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

        public bool GetWinner()
        {
            if (_actualScore == "love")
            {
                return false;
            }

            if (_actualScore == "15")
            {
                return false;
            }

            if (_actualScore == "30")
            {
                return false;
            }

            if (_actualScore == "40")
            {
                return _winner;
            }

            return true;
        }
    }
}