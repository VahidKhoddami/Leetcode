using System;

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
}

