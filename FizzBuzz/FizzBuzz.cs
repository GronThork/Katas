namespace FizzBuzz;

public static class FizzBuzz
{
    public static string Convert(int input)
    {
        if (MultipleOf3(input) && MultipleOf5(input))
            return "FizzBuzz";
        
        if (MultipleOf5(input))
            return "Buzz";

        if (MultipleOf3(input))
            return "Fizz";
        
        return input.ToString();
    }

    private static bool MultipleOf3(int input)
    {
        return input % 3 == 0;
    }

    private static bool MultipleOf5(int input)
    {
        return input % 5 == 0;
    }
}