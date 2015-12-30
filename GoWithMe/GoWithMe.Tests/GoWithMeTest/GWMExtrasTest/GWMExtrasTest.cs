using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoWithMe.GWMExtras;
namespace GoWithMe.Tests.GoWithMeTest.GWMExtrasTest
{
    [TestClass]
    public class GWMExtrasTest
    {
        [TestMethod]
        public void IsEmailValidTest()
        {
            GwmExtras gwmExtras = new GwmExtras();

            // The example displays the following output:
            bool result = gwmExtras.IsEmailValid("david.jones@proseware.com");
            Assert.AreEqual(true, result);  //Valid: david.jones@proseware.com

            result= gwmExtras.IsEmailValid("david.jones@proseware.com");
            Assert.AreEqual(true, result); //Valid: d.j@server1.proseware.com

            result = gwmExtras.IsEmailValid("jones@ms1.proseware.com");
            Assert.AreEqual(true, result); //Valid: jones@ms1.proseware.com

            result = gwmExtras.IsEmailValid("jsfdsf");
            Assert.AreEqual(false, result); //Invalid

         

        }
    }
}
