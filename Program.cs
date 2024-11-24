

using LeetcodeDotNet;

public class Program
{
    public static void Main(String[] args)
    {
        int errors = Test.TestSolutions();
        Console.WriteLine(errors > 0 ? $"Total errors: {errors}" : "No errors...fantastic!");
    }
}