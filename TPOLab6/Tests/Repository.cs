using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TPOLab6.Pages;

namespace TPOLab6
{
    [TestClass]
    public class Repository
    {
        private const string Equal = "testTpoLab6 ";
        private IWebDriver webDriver = InstanceOfWebDriver.GetWebDriver();

        [SetUp]
        private void Setup()
        {
            webDriver.Url = "https://github.com/";
        }

        [TestMethod]
        public void FindInRepositories()
        {
            Setup();

            Index indexPage = new Index(webDriver);
            indexPage.SearchInListOfRepos("ITdating");

            NUnit.Framework.Assert.AreEqual("ITdating", "ITdating");
        }

        [TestMethod]
        public void CreateNewRepository()
        {
            Setup();

            Index indexPage = new Index(webDriver);
            indexPage.CreateNewRepo();

            NewRepository newRepositoryPage = new NewRepository(webDriver);
            var randomName = new Random().Next(100000, 999999);
            newRepositoryPage.SetRepoName("testTpoLab6 " + randomName.ToString());
            newRepositoryPage.CreateNewRepo();

            NUnit.Framework.Assert.AreEqual("testTpoLab6 " + randomName.ToString(), Equal + randomName.ToString());
        }

        [TestMethod]
        public void ViewRepository()
        {
            Setup();

            Index indexPage = new Index(webDriver);
            indexPage.GetRepoForView();

            ViewRepository viewRepositoryPage = new ViewRepository(webDriver);
            viewRepositoryPage.ViewRepo();

            webDriver.Quit();
        }
    }
}