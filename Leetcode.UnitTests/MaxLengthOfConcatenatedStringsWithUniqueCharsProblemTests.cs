using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.UnitTests
{
    internal class MaxLengthOfConcatenatedStringsWithUniqueCharsProblemTests
    {
        [Test]
        public void MaxLengthOfConcatenatedStringsWithUniqueCharsProblem_Test1()
        {
            var maxLengthOfConcatenatedStringsWithUniqueCharsProblem = new MaxLengthOfConcatenatedStringsWithUniqueCharsProblem();
            Assert.That(maxLengthOfConcatenatedStringsWithUniqueCharsProblem.MaxLength(new List<string> { "un", "iq", "ue" }), Is.EqualTo(4));
        } 
        [Test]
        public void MaxLengthOfConcatenatedStringsWithUniqueCharsProblem_Test2()
        {
            var maxLengthOfConcatenatedStringsWithUniqueCharsProblem = new MaxLengthOfConcatenatedStringsWithUniqueCharsProblem();
            Assert.That(maxLengthOfConcatenatedStringsWithUniqueCharsProblem.MaxLength(new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" }), Is.EqualTo(16));
        }
        
        [Test]
        public void MaxLengthOfConcatenatedStringsWithUniqueCharsProblem_Test3()
        {
            var maxLengthOfConcatenatedStringsWithUniqueCharsProblem = new MaxLengthOfConcatenatedStringsWithUniqueCharsProblem();
            Assert.That(maxLengthOfConcatenatedStringsWithUniqueCharsProblem.MaxLength(new List<string> { "cha", "r", "act", "ers" }), Is.EqualTo(6));
        } 
        
        [Test]
        public void MaxLengthOfConcatenatedStringsWithUniqueCharsProblem_Test4()
        {
            var maxLengthOfConcatenatedStringsWithUniqueCharsProblem = new MaxLengthOfConcatenatedStringsWithUniqueCharsProblem();
            Assert.That(maxLengthOfConcatenatedStringsWithUniqueCharsProblem.MaxLength(new List<string> { "abcdefghijklmnopqrstuvwxyz" }), Is.EqualTo(26));
        }
    }
}
