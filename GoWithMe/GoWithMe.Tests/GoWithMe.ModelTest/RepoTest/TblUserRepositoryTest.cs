using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using GoWithMe.Model.Repo;
using GoWithMe.Model.ModelDB;
using GoWithMe.Model;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

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

        [TestMethod]
        public void GetUsersTest()
        {
            var users = new List<tblUser>
            {
                new tblUser
                {
                    Email = "email@wp.pl",
                    Login = "login",
                    Password = "Password",
                    Name = "Name",
                    Surname = "Surname",
                    PhoneNumber = "999888777",
                    RegistrationDate = DateTime.Now
                },

                new tblUser
                {
                Email = "email2@wp.pl",
                Login = "login2",
                Password = "Password2",
                Name = "Name2",
                Surname = "Surname2",
                PhoneNumber = "9998887772",
                RegistrationDate = DateTime.Now
                },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<tblUser>>();
            mockSet.As<IQueryable<tblUser>>().Setup(m => m.Provider).Returns(users.Provider);
            mockSet.As<IQueryable<tblUser>>().Setup(m => m.Expression).Returns(users.Expression);
            mockSet.As<IQueryable<tblUser>>().Setup(m => m.ElementType).Returns(users.ElementType);
            mockSet.As<IQueryable<tblUser>>().Setup(m => m.GetEnumerator()).Returns(users.GetEnumerator());


            var mockContext = new Mock<GoWithMeDBContext>();
            mockContext.Setup(c => c.Users).Returns(mockSet.Object);

            var repo = new TblUserRepository(mockContext.Object);
            var usersDB = repo.GetUsers();

            Assert.AreEqual(2, usersDB.Count);
            Assert.AreEqual("login", usersDB[0].Login);
            Assert.AreEqual("login2", usersDB[1].Login);
         
        }




    }
}
