using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.Fundamentals;

namespace UnitTesting.UnitTesting
{
    [TestClass]
    public class ErrorLoggerTests
    {
        private ErrorLogger _errorLogger;
        
        [TestInitialize]
        public void Initialize() => _errorLogger = new ErrorLogger();

        [TestMethod]
        [DataRow("a")]
        public void Log_WhenCalled_SetTheLastErrorProperty(string input)
        {
            _errorLogger.Log(input);

            Assert.AreEqual(_errorLogger.LastError, input);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string input) => 
            Assert.ThrowsException<System.ArgumentNullException>(() => _errorLogger.Log(input));

        [TestMethod]
        public void Log_ValidError_RaiseErrorLoggedEvent( )
        {
            var id = Guid.Empty;

            _errorLogger.ErrorLogged += (sender, args) => { id = args; };
            _errorLogger.Log("something");

            Assert.AreNotEqual(id, Guid.Empty);
        }
    }
}
