using Microsoft.ApplicationInsights;

namespace Lab2.Tests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Process1DArray_ValuesInInterval_ShouldBecomeZero()
        {
            int[] array = { 10, 20, 30, 40, 50 };
            int min = 15;
            int max = 35;
            int[] expected = { 10, 0, 0, 40, 50 };

            Task1.Process1DArray(array, min, max);

            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void Process2DArray_ValuesInInterval_ShouldBecomeZero()
        {
            int[,] matrix = {
                { 5, 10 },
                { 15, 20 }
            };
            int min = 8;
            int max = 18;
            int[,] expected = {
                { 5, 0 },
                { 0, 20 }
            };

            Task1.Process2DArray(matrix, min, max);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], matrix[i, j], $"Помилка в клітинці [{i},{j}]");
                }
            }
        }

        [TestMethod]
        public void Process1DArray_NoValuesInInterval_ShouldNotChange()
        {
            int[] array = { 1, 2, 3 };
            int min = 10;
            int max = 20;
            int[] expected = { 1, 2, 3 };

            Task1.Process1DArray(array, min, max);

            CollectionAssert.AreEqual(expected, array);
        }
    }
}
