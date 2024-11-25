/*

https://leetcode.com/problems/contains-duplicate-ii

Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such 
that nums[i] == nums[j] and abs(i - j) <= k.

*/

namespace Algorithms;

public class ContainsDuplicate
{
    public ContainsDuplicate()
    {

    }
    public bool IsContains(int[] nums, int k)
    {
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     // for (int j = i + 1; j < nums.Length; j++)
        //     // {
        //     //     if (nums[i] == nums[j] && Math.Abs(i - j) == k)
        //     //     {
        //     //         return true;
        //     //     }
        //     // }

        //     int j = i+1;
        //     while(j<nums.Length && Math.Abs(i-j)<=k)
        //     {
        //         if(nums[i] == nums[j])
        //         {
        //             Console.WriteLine(i + " " + j);
        //             return true;
        //         }
        //         j++;
        //     }
        // }

        // return false;
        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (keyValuePairs.ContainsKey(nums[i]))
            {
                if (Math.Abs(keyValuePairs[nums[i]] - i) <= k)
                {
                    return true;
                }
            }
            keyValuePairs[nums[i]] = i;
        }
        return false;

    }
}