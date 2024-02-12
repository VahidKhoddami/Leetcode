// Mjority Element (Easy) Problem URL: https://leetcode.com/problems/majority-element/

//Solution using Using the Boyer–Moore majority vote algorithm
public class MajorityElementEProblem
{
    public int MajorityElement(int[] nums)
    {
        var majorityElement = 0;
        var count = 0;

        foreach (var num in nums)
        {
            if (count == 0)
                majorityElement = num;

            count += num == majorityElement ? 1 : -1;
        }

        return majorityElement;
    }
}

