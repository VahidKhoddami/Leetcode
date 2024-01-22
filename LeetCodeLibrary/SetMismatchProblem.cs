using System;
/*
 Intuition
We can use hashset to find the missing and repeating numbers.

Approach
This code aims to find and return a pair of numbers in an array, where one number is repeated, and another number is missing. It utilizes a HashSet named numSet initially containing all numbers from 1 to n. The algorithm iterates through the given nums array, attempting to remove each element from the hashset. If the removal is unsuccessful, it indicates that the current number is the repeated one (the item was already removed).

After processing all elements, the HashSet will contain only the missing number, as it wasn't removed during the iteration.

The result array is then constructed with the repeated number as the first element and the missing number as the second element.

Complexity
Time complexity: o(n)
Space complexity: O(n)
 */
public class SetMismatchProblem
{
    public int[] FindErrorNums(int[] nums)
    {
        var l = nums.Length;
        var numSet = new HashSet<int>(nums);
        var repeatingNumSet = new HashSet<int>();
        var repeated = 0;
        var missing = 0;

        for (int i = 0; i < l; i++)
        {
            if (repeatingNumSet.Contains(nums[i]))
                repeated = nums[i];

            if (!numSet.Contains(i + 1))
                missing = i + 1;

            if (repeated > 0 && missing > 0)
                break;

            repeatingNumSet.Add(nums[i]);

        }
        return new int[] { repeated, missing };
    }

    /*
     public int[] FindErrorNums(int[] nums) {
        var l = nums.Length;
        var numSet = new HashSet<int>(Enumerable.Range(1,l));
        var repeated = 0;

        for (int i = 0; i < l; i++)
        {
            if (!numSet.Remove(nums[i]))
                repeated = nums[i];
        }

        var missing = numSet.First();
        return [repeated, missing];
    }
     */
}

