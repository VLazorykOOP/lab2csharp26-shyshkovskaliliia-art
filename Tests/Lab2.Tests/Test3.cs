using Microsoft.ApplicationInsights;

namespace Lab2.Tests
{
    [TestClass]
    public sealed class Test3
    {
        [TestMethod]
        public void GetSideDiagonalSum_StandardMatrix_ShouldReturnCorrectSum()
        {
           
            int[,] matrix = {
            { 1, 2, 3 }, 
            { 4, 5, 6 }, 
            { 7, 8, 9 } 
        };
            int expected = 3 + 5 + 7; 
            int actual = Task3.GetSideDiagonalSum(matrix);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSideDiagonalSum_WrongCalculation_ShouldFail()
        {
            int[,] matrix = {
            { 1, 0 },
            { 0, 1 }
        };
            
            int expected = 10;
            int actual = Task3.GetSideDiagonalSum(matrix);
            Assert.AreEqual(expected, actual);
        }
    }
}
    
