using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoWithMe;
using GoWithMe.GWMExtras;

namespace GoWithMe.Tests.GoWithMeTest.OffertsPanelTest
{
    [TestClass]
    public class OffertsPanelAspxTest
    {
        [TestMethod]
        public void ChangeNumberFormaGivenNumberTest()
        {
            string result = GwmExtras.ChangeNumberFormat("987654321");
            Assert.AreEqual("987-654-321", result);
        }
    }
}
