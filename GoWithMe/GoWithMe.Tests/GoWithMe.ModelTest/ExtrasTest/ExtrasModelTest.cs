using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoWithMe.Model.Extras;

namespace GoWithMe.Tests.GoWithMe.ModelTest.ExtrasTest
{
    [TestClass]
    public class ExtrasModelTest
    {
        [TestMethod]
        public void ConvertGivenPhraseTest()
        {
            ExtrasModel obj = new ExtrasModel();
            string result = obj.ConvertGivenPhrase("AĄććĘĘĘŻÓŁŁ");
            Assert.AreEqual("aacceeezoll", result);
        }

        [TestMethod]
        public void encryptPhraseUsingSha256Test()
        {
            ExtrasModel obj = new ExtrasModel();
            string result = obj.encryptPhraseUsingSha256("passwordExample");
            Assert.AreNotSame("passwordExample", result);
        }

        
    }
}
