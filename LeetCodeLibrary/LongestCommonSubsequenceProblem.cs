// Longest Common Subsequence Problem Url: https://leetcode.com/problems/longest-common-subsequence

/*
 # Intuition
<!-- Describe your first thoughts on how to solve this problem. -->
This is a dynamic programming problem. I used a bottom-up approach to solve it.
# Approach
<!-- Describe your approach to solving the problem. -->
This video explains perfectly how to solve this question:
[https://www.youtube.com/watch?v=Ua0GhsJSlWM&ab_channel=NeetCode]()

# Complexity
- Time complexity: O(n*m) (If n= `text1` length, and m= `text2` length)
<!-- Add your time complexity here, e.g. $$O(n)$$ -->

- Space complexity: O(n*m) (If n= `text1` length, and m= `text2` length)
<!-- Add your space complexity here, e.g. $$O(n)$$ -->
 */
public class LongestCommonSubsequenceProblem
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        var t1L = text1.Length;
        var t2L = text2.Length;

        var dp = new int[t1L + 1, t2L + 1];

        for (int i = t1L - 1; i > -1; i--)
            for (int j = t2L - 1; j > -1; j--)
                if (text1[i] == text2[j])
                    dp[i, j] = dp[i + 1, j + 1] + 1;
                else
                    dp[i, j] = Math.Max(dp[i + 1, j], dp[i, j + 1]);

        return dp[0, 0];
    }
}

