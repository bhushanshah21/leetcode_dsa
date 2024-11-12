namespace Algorithms;
static class Program
{
    public static void Main(string[] args)
    {
        Palindrome palindrome = new Palindrome();
        Console.WriteLine(palindrome.IsValid("A man, a plan, a canal: Panama"));
    }
}