// Out of boundary paths problem: https://leetcode.com/problems/out-of-boundary-paths/
/*
 Intuition
I used bottom-up dynamic programming to solve it.

Approach
Here is a great explanation:
[https://www.youtube.com/watch?v=Bg5CLRqtNmk&ab_channel=NeetCodeIO]()

Complexity
Time complexity: O(m * n * maxMove)
Space complexity: O(m * n)
 */

public class OutOfBoundaryPathsProblem
{
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
    {
        
        var (rows, cols) = (m, n);
        var dp = new int[rows, cols];
        var mod = 1000000007;

        for (int moves = 1; moves <= maxMove; moves++)
        {
            var temp = new int[rows, cols];
            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                {
                    //Rows go up and down 
                    long up = r == 0 ? 1 : dp[r - 1, c];
                    long down = r == rows - 1 ? 1 : dp[r + 1, c];
                    //Columns go left and right
                    long left = c == 0 ? 1 : dp[r, c - 1];
                    long right = c == cols - 1 ? 1 : dp[r, c + 1];

                    //Sum of all possible moves
                    temp[r, c] = (int)((up + down + left + right) % mod);
                }

            dp = temp;
        }

        //Return out of path moves starting from startRow, startColumn
        return dp[startRow, startColumn];
    }
}

