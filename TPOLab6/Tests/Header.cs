using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using TPOLab6.Pages;

namespace TPOLab6
{
    [TestClass]
    public class Header
    {
        private IWebDriver webDriver = InstanceOfWebDriver.GetWebDriver();

        [SetUp]
        private void Setup() 
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Url = "https://github.com/login";
            Auth();
        }

        [TestMethod]
        public void HeaderTest()
        {
            Setup();
            Index page = new Index(webDriver);
            page.ClickToHeaderLinks();
        }

        public Login Auth()
        {
            Login loginPage = new Login(webDriver);
            loginPage.SetLoginPasswordValue("mayst1230", "Rjvgm.nth!23");
            loginPage.Authorization();

            return new Login(webDriver);
        }
    }
}
