using BankingApp.Areas.Home.Controllers;
using BankingApp.Controllers;
using BankingApp.Entities.Services.Interfaces;
using BankingApp.Utilities;
using BankingApp.Utilities.Interfaces;
using Moq;
using NUnit.Framework;

namespace BankingApp.Test
{
    [TestFixture]
    internal class LoginControllerTest
    {
        [Test]
        public void CreateReadUserTest()
        {
            var mockBankAccountsService = new Mock<IBankAccountsService>();
            var mockBankAccountContext = new Mock<IBankingAppContext>();
            var controller = new HomeController(mockBankAccountContext.Object, mockBankAccountsService.Object);
        }
    }
}