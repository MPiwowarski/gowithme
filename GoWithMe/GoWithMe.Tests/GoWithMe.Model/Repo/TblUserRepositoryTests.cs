using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoWithMe.Model.Repo;
using GoWithMe.Model.ModelDB;
using GoWithMe.Model.Repo;

namespace GoWithMe.Tests.GoWithMe.Model.Repo
{
    [TestClass]
    public class TblUserRepositoryTests
    {
        [TestMethod]
        public void SearchIfGivenLoginAlreadyExists()
        {
            ITblUserRepository repo = new TblUserRepository();

            
            string login = "sdf";

            Assert.AreEqual(true, repo.SearchIfGivenLoginAlreadyExists(login));
        }

    }
}
