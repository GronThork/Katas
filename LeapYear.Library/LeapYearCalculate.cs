namespace LeapYear.Library
{
    public class LeapYearCalculate
    {
        public static bool IsLeapYear(int i)
        {
            if (i % 400 == 0)
            {
                return true;
            }
            
            if (i % 100 == 0)
            {
                return false;
            }
            
            if (i % 4 == 0)
            {
                return true;
            }
            
            return false;
        }
    }
}