// Palindromic Substrings - Medium URL: https://leetcode.com/problems/palindromic-substrings/

/*
 # Intuition
To solve this problem, it is important to understand that for each string `s` to be a palindrome, it needs to have the same characters when moving from the center character to the left and right of the center. Additionally, each time we move in both directions, if the characters are the same, it indicates a palindrome substring, and we can count it as such. Conversely, if we encounter different characters during these movements, the substring is no longer a palindrome, even if we continue moving in both directions and find equal characters afterward.


# Approach
<!-- Describe your approach to solving the problem. -->
In this approach, we iterate through each character in the string `s`. We assume the current character as the center and check both left and right of that character, starting with both left and right equal to the current character. We continue this process as long as neither the left nor right characters are out of bounds (`0` and `s.Length`). Once they are out of bounds, we stop counting and move on to the next character in s.

The previous solution only counts the number of palindrome substrings with odd length. To count palindrome substrings with even length, we follow the same procedure as described above, but this time starting with the left equal to the current character and the right equal to the next character.

You can find more explanation in this video:
[https://youtu.be/4RACzI5-du8?si=kdwzu-LGwjU7fy4C]()


# Complexity
- Time complexity:$$O(n^2)$$, where n is the length of the input string `s`.
<!-- Add your time complexity here, e.g. $$O(n)$$ -->

- Space complexity:$$O(1)$$
<!-- Add your space complexity here, e.g. $$O(n)$$ -->
 */

public class PalindromicSubstringsMProblem
{
    public int CountSubstrings(string s)
    {

        var countRes = 0;
        for (int i = 0; i < s.Length; i++)
        {
            countRes += CountPalindromes(s, i, i);
            countRes += CountPalindromes(s, i, i + 1);
        }

        return countRes;
    }

    private int CountPalindromes(string s, int l, int r)
    {
        var count = 0;

        while (l >= 0 && r < s.Length && s[l] == s[r])
        {
            count++;
            l--;
            r++;
        }

        return count;
    }
}

