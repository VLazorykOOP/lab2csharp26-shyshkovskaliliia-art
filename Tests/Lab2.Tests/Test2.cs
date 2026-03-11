using Microsoft.ApplicationInsights;

namespace Lab2.Tests
{
    [TestClass]
    public sealed class Test2
    {
        [TestMethod]
        public void ReplaceMaxWithZero_CorrectLogic_ShouldPass()
        {
            double[] array = { 10.5, 20.0, 5.5 };
            double[] expected = { 10.5, 0, 5.5 }; 
            Task2.ReplaceMaxWithZero(array);
            CollectionAssert.AreEqual(expected, array);
        }

        [TestMethod]
        public void ReplaceMaxWithZero_WrongExpectedValue_ShouldFail()
        {
            double[] array = { 1.0, 3.0, 2.0 };
            double[] expected = { 1.0, 99.9, 2.0 };
            Task2.ReplaceMaxWithZero(array);
            CollectionAssert.AreEqual(expected, array);
        }
    }
}
