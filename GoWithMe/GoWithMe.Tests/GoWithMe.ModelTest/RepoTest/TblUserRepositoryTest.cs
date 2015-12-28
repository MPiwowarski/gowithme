using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using GoWithMe.Model.Repo;
using GoWithMe.Model.ModelDB;
using GoWithMe.Model;
using System.Data.Entity;
namespace GoWithMe.Tests.GoWithMe.ModelTest.RepoTest
{
    [TestClass]
    public class TblUserRepositoryTest
    {
        [TestMethod]
        public void AddNewUserTest()
        {
            var mockSet = new Mock<DbSet<tblUser>>();

            var mockContext = new Mock<GoWithMeDBContext>();
            mockContext.Setup(m => m.Users).Returns(mockSet.Object);

            var repo = new TblUserRepository(mockContext.Object);

            tblUser newUser = new tblUser();
            newUser.Email = "email@wp.pl";
            newUser.Login = "login";
            newUser.Password = "Password";
            newUser.Name = "Name";
            newUser.Surname = "Surname";
            newUser.PhoneNumber = "999888777";
            newUser.RegistrationDate = DateTime.Now;

            repo.AddNewUser(newUser);

            mockSet.Verify(m => m.Add(It.IsAny<tblUser>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }
    }
}
