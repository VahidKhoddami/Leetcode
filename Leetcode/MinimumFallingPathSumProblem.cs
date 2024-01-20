// Minimum Falling Path Sum Problem https://leetcode.com/problems/minimum-falling-path-sum/

public class MinimumFallingPathSumProblem
{
    public int MinFallingPathSum(int[][] matrix)
    {
        var dp = new int[matrix.Length][];
        for (int i = 0; i < matrix.Length; i++)
        {
            dp[i] = new int[matrix[i].Length];
        }

        for (int i = 0; i < matrix[0].Length; i++)
        {
            dp[0][i] = matrix[0][i];
        }

        for (int i = 1; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                var min = int.MaxValue;
                if (j - 1 >= 0)
                {
                    min = Math.Min(min, dp[i - 1][j - 1]);
                }

                min = Math.Min(min, dp[i - 1][j]);

                if (j + 1 < matrix[i].Length)
                {
                    min = Math.Min(min, dp[i - 1][j + 1]);
                }

                dp[i][j] = matrix[i][j] + min;
            }
        }

        var result = int.MaxValue;
        for (int i = 0; i < dp[dp.Length - 1].Length; i++)
        {
            result = Math.Min(result, dp[dp.Length - 1][i]);
        }

        return result;
    }   
}