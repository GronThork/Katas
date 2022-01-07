namespace FactorialKata
{
    public class Factorial
    {
        public int Calculate(int input)
        {
            if (input == 0)
            {
                return 1;
            }

            return input * Calculate(input-1);
        }
    }
}