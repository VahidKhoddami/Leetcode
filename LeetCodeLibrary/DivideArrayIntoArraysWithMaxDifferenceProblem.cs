// Divie Array into Arrays with Max Difference Problem Url: https://leetcode.com/problems/divide-array-into-arrays-with-max-difference

/*
 The intuition is that if we divide the array into subarrays of size 3, 
then the difference between the first and the last element of each subarray will be the maximum. 
This is because the array is sorted and the difference between the first and the last element of the subarray will be the maximum possible difference between any two elements of the subarray. 
If this difference is greater than k, then we cannot divide the array into subarrays of size 3. 
Otherwise, we can divide the array into subarrays of size 3.

Complexity Analysis:
Time Complexity: O(nlogn), where n is the length of the input array.
Space Complexity: O(n), where n is the length of the input array.
 */
public class DivideArrayIntoArraysWithMaxDifferenceProblem
{
    public int[][] DivideArray(int[] nums, int k)
    {
        var n = nums.Length;
        Array.Sort(nums);
        var answer = new int[n / 3][];

        for (int i = 0; i < n - 2; i += 3)
        {
            if (nums[i + 2] - nums[i] > k)
                return new int[0][];

            answer[i / 3] = new int[] { nums[i], nums[i + 1], nums[i + 2] };
        }

        return answer;
    }
}

