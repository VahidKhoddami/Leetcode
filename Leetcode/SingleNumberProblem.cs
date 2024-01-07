// single-number problem: https://leetcode.com/problems/single-number/description/

public class SingleNumberProblem
{
    public int SingleNumber(int[] nums)
    {
        var result = 0;
        foreach (var num in nums)
            result ^= num;
        return result;
    }
}
