namespace Algorithms;
static class Program
{
    public static void Main(string[] args)
    {
        // Palindrome palindrome = new Palindrome();
        // Console.WriteLine(palindrome.IsValid("A man, a plan, a canal: Panama"));

        MajorityElement majorityElement = new MajorityElement();
        int[] nums = {1,1,2,3,1 };
        Console.WriteLine(majorityElement.Get(nums));
    }
}