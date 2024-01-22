namespace Leetcode.UnitTests
{
    public class SetMismatchProblemTests
    {
        [Test]
        public void SetMismatchProblem_Test1()
        {
            var setMismatchProblem = new SetMismatchProblem();
            Assert.That(setMismatchProblem.FindErrorNums(new int[] { 1, 2, 2, 4 }), Is.EqualTo(new int[] { 2, 3 }));
        }
    }

    
}
