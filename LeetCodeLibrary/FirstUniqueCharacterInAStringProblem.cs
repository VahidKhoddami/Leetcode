//First Unique Character in a String (Easy) Url: https://leetcode.com/problems/first-unique-character-in-a-string/  

/*
 Intuition
We can implement this using a fixed-sized array of size 26, as we know that there are only lowercase alphabet characters.

Approach
We can keep track of the count of each character at its relative position in the lst array.

Then, we loop through every character in s from the beginning and check if the total count of that character is equal to 1; if so, we can return that index as the first non-repeating character.

If we go through all the characters and do not find a non-repeating character, we simply return -1.

Complexity
Time complexity: O(n), n is the length of the input string s
Space complexity: O(1), the size of the array lst is constant at 26, regardless of the input size
 */
public class FirstUniqueCharacterInAStringProblem
{
    public int FirstUniqChar(string s)
    {
        var lst = new int[26];
        var first = 'a';

        foreach (char c in s)
            lst[c - first]++;

        for (int i = 0; i < s.Length; i++)
            if (lst[s[i] - first] == 1)
                return i;

        return -1;
    }

}

