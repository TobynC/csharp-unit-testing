using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace UnitTesting.UnitTesting
{
    [TestClass]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1707:Identifiers should not contain underscores", Justification = "<Pending>")]
    public class CustomerControllerTests
    {
        private CustomerController _customerController;

        [TestInitialize]
        public void Initialize() => _customerController = new CustomerController(); 

        [TestMethod]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            var response = _customerController.GetCustomer(0);

            Assert.IsInstanceOfType(response, typeof(NotFound));
        }
        
        [TestMethod]
        public void GetCustomer_IdIsNotZero_ReturnOK()
        {
            var response = _customerController.GetCustomer(1);

            Assert.IsInstanceOfType(response, typeof(Ok));
        }
    }
}
