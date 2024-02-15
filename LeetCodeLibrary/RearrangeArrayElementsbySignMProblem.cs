// Rearrange Array Elements by Sign (M) Problem URL: https://leetcode.com/problems/rearrange-array-elements-by-sign/
/*
Intuition
We can also use queue to solve this problem.

Approach
We can initialize two queues one for positive and one for negative numbers.
First we go through all the numbers and add each number to the corresponding positive and negative queues.
Then for each number in the nums array we replace that number from the positive or negative queue.

Complexity
Time complexity:O(n)O(n)O(n)
Space complexity:O(n)O(n)O(n) 
 */
public class RearrangeArrayElementsbySignMProblem
{
    public int[] RearrangeArray(int[] nums)
    {
        var pos = new Queue<int>();
        var neg = new Queue<int>();
        var addPos = true;

        foreach (var num in nums)
            if (num > 0)
                pos.Enqueue(num);
            else
                neg.Enqueue(num);

        for (int i = 0; i < nums.Length; i++)
        {
            if (addPos)
                nums[i] = pos.Dequeue();
            else
                nums[i] = neg.Dequeue();

            addPos = !addPos;
        }

        return nums;
    }

    /* A faster efficient solution
     public int[] RearrangeArray(int[] nums) {
        var posIndex=0;
        var negIndex=1;
        var res=new int[nums.Length];
        
        for(int i=0;i<nums.Length;i++){
            if(nums[i]>0){
                res[posIndex]=nums[i];
                posIndex+=2;
            }
            else
            {
                res[negIndex]=nums[i];
                negIndex+=2;
            }
        }

        return res;
    }
     */
}

