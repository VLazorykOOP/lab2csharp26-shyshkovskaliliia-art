using Microsoft.ApplicationInsights;

namespace Lab2.Tests
{
    [TestClass]
    public sealed class Test4
    {
        [TestMethod]
        public void CountPositiveInRows_VariousElements_ShouldReturnCorrectCounts()
        {
            int[][] jaggedArray = new int[][]
            {
            new int[] { 1, -2, 3 },     
            new int[] { 0, 0 },         
            new int[] { 10, 20, 30, 40 } 
            };
            int[] expected = { 2, 0, 4 };

            int[] actual = Task4.CountPositiveInRows(jaggedArray);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CountPositiveInRows_WrongExpectation_ShouldFail()
        {
            int[][] jaggedArray = new int[][]
            {
            new int[] { 5, 6, -1 } 
            };
            int[] expected = { 10 };

            int[] actual = Task4.CountPositiveInRows(jaggedArray);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
