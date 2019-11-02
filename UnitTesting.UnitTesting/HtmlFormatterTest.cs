using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace UnitTesting.UnitTesting
{
    [TestClass]
    public class HtmlFormatterTest
    {
        private HtmlFormatter _htmlFormatter;

        [TestInitialize]
        public void Initialize() => _htmlFormatter = new HtmlFormatter();

        [TestMethod]
        [DataRow("abc")]
        [DataRow("def")]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement(string input)
        {
            var result = _htmlFormatter.FormatAsBold(input);

            Assert.IsTrue(result.StartsWith("<strong>", System.StringComparison.Ordinal));
            Assert.IsTrue(result.EndsWith("</strong>", System.StringComparison.Ordinal));
            Assert.IsTrue(result.Contains(input, System.StringComparison.Ordinal));
        }
    }
}
