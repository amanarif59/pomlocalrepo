using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POM.Pages;

namespace TestAutomation.TestCases
{
    [TestFixture]
    public class OrderTest
    {
        [Test]
        public void TestMethod()
        {
            LaunchPage launchPage = new LaunchPage();
            LoginPage loginPage = launchPage.GoToLoginPage();
            MyHomePage myHomePage = loginPage.DoLogin("aman123", "testing123");
            ShoppingCartPage shoppingCartPage = myHomePage.BuyProduct("top");
            OrderReviewPage orderReviewPage = shoppingCartPage.ConfirmOrder();
            OrderStatusPage orderStatusPage = orderReviewPage.PlaceOrder();
            orderStatusPage.GeTTopMenu().LogOut(); // loging out
        }
    }
}
