// Minimum Window Substring Problem - LeetCode Url: https://leetcode.com/problems/minimum-window-substring/

/*
 # Intuition
<!-- Describe your first thoughts on how to solve this problem. -->
We can solve this using hash table and sliding window approach.
# Approach
<!-- Describe your approach to solving the problem. -->
1. `needCnt` keeps track of the total count of characters in `t`, and `haveCnt` is the count of characters in the current window. *These two variables are used to save the time of counting the number of all characters each time we move the pointers to check if that window is a possible solution.*

2. Populate `need` and `have` dictionaries: `need` contains the number of each character required. `have` keeps track of count of each character in the current window.

3. Iterate through each character in string `s` and use two pointers `i` as the right of the window and `j` as the left of the window for the sliding window approach.

4. In the while loop we expand the window and move the right pointer `j` to the right to expand the window until the required count `needCnt` is equal to the current count `haveCnt` for all characters in `t`.

5. If the current window contains all characters from `t` and has a smaller length than the minimum window length seen so far, update the result.

6. Before moving the `i` pointer to the next character we check if that character was in `t`. If so, we need to reduce the number of that charachter in the `have` dictionary and also update the `haveCnt` if the number of that character is less than the required number of that in `t`.

This can help to understand the problem and the solution:
[https://www.youtube.com/watch?v=jSto0O4AJbM&ab_channel=NeetCode]()
# Complexity
- Time complexity: O(n), `n` is the length of the input string `s`
<!-- Add your time complexity here, e.g. $$O(n)$$ -->

- Space complexity: O(m), `m` is the length of the input string `t`. Because the algorithm uses two dictionaries (`need` and `have`) to store the count of characters. In the worst case, the dictionaries can have at most `m` unique characters.
<!-- Add your space complexity here, e.g. $$O(n)$$ -->
 */
public class MinimumWindowSubstringProblem
{
    public string MinWindow(string s, string t)
    {

        var have = new Dictionary<char, int>();
        var need = new Dictionary<char, int>();

        var needCnt = t.Length;
        var haveCnt = 0;

        foreach (char c in t)
        {
            if (need.ContainsKey(c))
                need[c]++;
            else
                need.Add(c, 1);

            if (!have.ContainsKey(c))
                have.Add(c, 0);
        }

        var minStrCnt = int.MaxValue;
        var resStr = "";
        var j = 0;
        for (int i = 0; i < s.Length; i++)
        {
            while (j < s.Length && needCnt != haveCnt)
            {
                if (need.ContainsKey(s[j]))
                {
                    have[s[j]]++;
                    if (have[s[j]] == need[s[j]])
                        haveCnt += need[s[j]];
                }
                j++;
            }

            if (needCnt == haveCnt && j - i < minStrCnt)
            {
                resStr = s.Substring(i, j - i);
                minStrCnt = j - i;
            }

            if (have.ContainsKey(s[i]))
            {
                have[s[i]]--;
                if (have[s[i]] < need[s[i]])
                    haveCnt -= need[s[i]];
            }

        }

        return resStr;
    }
}

