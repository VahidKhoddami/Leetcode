// K Inverse Pairs Array Problem Url: https://leetcode.com/problems/k-inverse-pairs-array
//https://www.youtube.com/watch?v=dglwb30bUKI&ab_channel=NeetCodeIO
public class KInversePairsArrayProblem
{
    public int KInversePairs(int n, int k)
    {
        var prev = new int[k + 1];
        prev[0] = 1;
        var mod = 1000000007;

        for (int i = 1; i <= n; i++)
        {
            var cur = new int[k + 1];
            long total = 0;
            for (int j = 0; j <= k; j++)
            {
                if (j >= i)
                    total = (total - prev[j - i] + mod) % mod;
                total = (total + prev[j]) % mod;
                cur[j] = (int)total;
            }

            prev = cur;
        }

        return prev[k];
    }
}

