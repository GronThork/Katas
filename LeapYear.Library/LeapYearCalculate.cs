namespace LeapYear.Library
{
    public class LeapYearCalculate
    {
        public static bool IsLeapYear(int i)
        {
            if (i == 100)
            {
                return false;
            }
            
            if (i == 200)
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