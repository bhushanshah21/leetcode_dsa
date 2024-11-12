// 125. Valid Palindrome
// https://leetcode.com/problems/valid-palindrome/description/
/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all 
non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.
*/
namespace Algorithms;
public class Palindrome {

    public Palindrome() {

    }
    public bool IsValid(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return true;

        int left = 0;
        int right = input.Length - 1;

        while (left < right)
        {
            // Move left pointer to the next alphanumeric character
            while (left < right && !char.IsLetterOrDigit(input[left]))
            {
                left++;
            }

            // Move right pointer to the previous alphanumeric character
            while (left < right && !char.IsLetterOrDigit(input[right]))
            {
                right--;
            }

            // Compare characters (case-insensitive)
            if (char.ToLower(input[left]) != char.ToLower(input[right]))
            {
                return false; // Not a palindrome
            }

            // Move both pointers towards the center
            left++;
            right--;
        }

        return true; // It is a palindrome
    }
}