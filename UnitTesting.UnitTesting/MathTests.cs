using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "<Pending>")]
    [TestClass]
    public class MathTests
    {
        private Math _math;

        [TestInitialize]
        public void Initialize() => _math = new Math();

        [TestMethod]
        [DataRow(1, 1, 2)]
        public void Add_WhenCalled_ReturnSumOfArguments(int a, int b, int expectedResult)
        {
            var result = _math.Add(a, b);

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        [DataRow(2, 1, 2)]
        [DataRow(1, 2, 2)]
        [DataRow(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {          
            var result = _math.Max(a, b);

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        [DataRow(7, new int[] { 1, 3, 5, 7 })]
        public void GetOddNumbers_LimitGreaterThanZero_ReturnOddNumberUpToLimit(int a, int[] expectedResult)
        {
            var result = _math.GetOddNumbers(a);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Any());
            CollectionAssert.AreEqual(result.ToArray(), expectedResult);
        }
    }
}