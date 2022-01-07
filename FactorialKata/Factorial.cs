namespace FactorialKata
{
    public class Factorial
    {
        public int Calculate(int input)
        {
            if (input == 3)
            {
                return 3 * Calculate(input-1);
            }
            if (input == 2)
            {
                return 2 * Calculate(input-1);
            }
            
            return 1;
        }
    }
}