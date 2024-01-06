// Candy problem: https://leetcode.com/problems/candy/

public class CandyProblem
{
    public int Candy(int[] ratings)
    {
        var l=ratings.Length;
       //Samples:[0,1,2]= output[1,2,3]=6, [3,2,1,4,5]=output[3,2,1,2,3]=11
      
        var output = Enumerable.Repeat(1, l).ToArray();

        for (int i = 1; i < l; i++)
            if (ratings[i] > ratings[i-1])
                output[i] = output[i-1] + 1;
        
        for (int i =l-2 ; i > -1; i--)
            if (ratings[i] > ratings[i+1])
                output[i] =Math.Max(output[i], output[i+1] + 1);

        return output.Sum();
    }
}