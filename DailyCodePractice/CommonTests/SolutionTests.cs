using NUnit.Framework;
using CommonSolution;
using System.Linq;

namespace Tests
{
    public class Tests
    {
        public Solution sol;
        [SetUp]
        public void Setup()
        {
            sol = new Solution();
        }

        [Test]
        public void ProductOfOtherElements_WhenElementsAre1_expect1()
        {
            var orignal = new int[] { 1 };

            var prodArray = sol.ProductOfOtherElements(orignal);

            var result = new int[] { 1 };
            Assert.That(orignal.SequenceEqual(result), Is.True);
        }

        [Test]
        public void ProductOfOtherElements_WhenElementsAre2_3_Expect3_2()
        {
            // Arrange
            var original = new int[] { 2, 3 };

            // Act
            var productOfOthers = sol.ProductOfOtherElements(original);
            var result = new int[] { 3, 2 };

            Assert.That(result.SequenceEqual(result), Is.True);
        }

        [Test]
        public void ProductOfOtherElements_WhenElementsAre2_3_4_Expect12_8_6()
        {
            // Arrange
            var original = new int[] { 2, 3, 4 };

            // Act
            var productOfOthers = sol.ProductOfOtherElements(original);
            var result = new int[] { 12, 8, 6 };

            Assert.That(result.SequenceEqual(result), Is.True);
        }
    }
}