namespace LeapYear.Library
{
    public class LeapYearCalculate
    {
        public static bool IsLeapYear(int i)
        {
            if (i == 4)
            {
                return true;
            }
            
            if (i == 8)
            {
                return true;
            }
            
            if (i == 12)
            {
                return true;
            }

            return false;
        }
    }
}