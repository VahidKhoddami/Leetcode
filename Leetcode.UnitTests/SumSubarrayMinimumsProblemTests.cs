namespace Leetcode.UnitTests
{
    public class SumSubarrayMinimumsProblemTests
    {
        //Sum subarray minimums: https://leetcode.com/problems/sum-of-subarray-minimums/

        [Test]
        public void SumSubarrayMinimumsProblem_Test1()
        {
            var sumSubarrayMinimums = new SumSubarrayMinimumsProblem();
            Assert.That(sumSubarrayMinimums.SumSubarrayMins(new int[] { 3, 1, 2, 4 }),Is.EqualTo(17));
        }
    }
}