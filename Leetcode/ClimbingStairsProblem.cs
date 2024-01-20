// Candy problem: https://leetcode.com/problems/candy/
//var candy = new CandyProblem();
//Console.WriteLine(candy.Candy(new int[] { 3, 2, 1, 4, 5 }).ToString());

public class ClimbingStairsProblem
{
    public int ClimbStairs(int n)
    {
        if (n == 1)
            return 1;

        var dp = new int[n + 1];
        dp[1] = 1;
        dp[2] = 2;

        for (int i = 3; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }

        return dp[n];
    }
}