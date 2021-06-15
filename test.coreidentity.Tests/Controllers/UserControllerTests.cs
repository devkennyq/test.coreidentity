using Microsoft.VisualStudio.TestTools.UnitTesting;
using test.coreidentity.webapi.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using test.coreidentity.core.Interfaces;
using Moq;
using System.Threading.Tasks;
using test.coreidentity.core.Models;

namespace test.coreidentity.webapi.Controllers.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        private Mock<IUserRepository> mockUserRepository;
        private UserController userController;

        [TestInitialize()]
        public void Initialize()
        {
            mockUserRepository = new Mock<IUserRepository>();
            userController = new UserController(mockUserRepository.Object);
        }

        [TestMethod()]
        public async Task AddNewUserTest()
        {
            var defaultUser = new UserInfo
            {
                UserName = "admin2",
                Email = "admin2@fake.email.com"
            };

            await userController.AddNewUser(defaultUser);
        }
    }
}