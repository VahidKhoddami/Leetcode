// Determine if two strings are close: https://leetcode.com/problems/determine-if-two-strings-are-close/
//
// 
/*
 The intuition is that for the two strings to be close, they need to have the same characters, 
and for each character in word1, there must be the same or another character in word2 with 
the same number of occurrences. This means that we can rearrange the characters in word1 
to attain word2 and vice versa. 
Therefore, we need to count the number of occurrences of each character in each string.
 */

/*
 First, we check if the length of the two strings is the same; if not, we return false.
Then, we initialize two arrays of size 26 to store the count of each character in each string.
Next, we iterate over the length of one of the strings (since they are of the same size) and increment the count of the corresponding character in both arrays.
Subsequently, we iterate through the 26 characters:
Check if there is a character in one array that doesn't exist in the other array; if so, we return false.
In an inner loop, we iterate through the 26 characters of the word2 list. For each character in word1, check if there is any character in word2 that has the same number of occurrences. If found, add that character to a set to avoid counting it again. If no such character is found in word2, return false.
If we complete the loops without returning false, it means that the two strings are close, and we return true.

Complexity
Time complexity: O(n), the length of the either of the strings
Space complexity: O(1), as the additional space requirements are constant (each with the length of 26) and independent of the input size
 */

public class DetermineIfTwoStringsAreCloseProblem
{
    public bool CloseStrings(string word1, string word2)
    {

        if (word1.Length != word2.Length)
            return false;

        var offset = 'a';
        var w1List = new int[26];
        var w2List = new int[26];
        var length = word1.Length;
        var seenChars = new HashSet<char>();
        var theSameCharIsFound = false;

        for (int i = 0; i < length; i++)
        {
            w1List[word1[i] - offset]++;
            w2List[word2[i] - offset]++;
        }

        for (int i = 0; i < 26; i++)
        {
            // if char exists in one word but not in other
            if ((w1List[i] > 0 && w2List[i] == 0) || (w2List[i] > 0 && w1List[i] == 0))
                return false;

            for (int j = 0; j < 26; j++)
            {
                if (w1List[i] == w2List[j] && !seenChars.Contains((char)(j + offset)))
                {
                    seenChars.Add((char)(j + offset));
                    theSameCharIsFound = true;
                    break;
                }
            }

            if (!theSameCharIsFound)
                return false;

            theSameCharIsFound = false;
        }

        return true;
    }
}