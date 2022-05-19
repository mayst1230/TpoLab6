using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TPOLab6.Pages;

namespace TPOLab6
{
    [TestClass]
    public class Issue
    {
        private IWebDriver webDriver = InstanceOfWebDriver.GetWebDriver();

        [SetUp]
        private void Setup()
        {
            webDriver.Url = "https://github.com/mayst1230/CSharpTextParser/issues";
        }

        [TestMethod]
        public void CreateIssue()
        {
            Setup();

            IssuesList issuesListPage = new IssuesList(webDriver);
            issuesListPage.NewIssue();

            IssuesCreate issuesCreatePage = new IssuesCreate(webDriver);
            var random = new Random().Next(100000, 999999);
            issuesCreatePage.SetIssueTitle("testTpoLab6 " + random.ToString());
            issuesCreatePage.CreateIssue();

            NUnit.Framework.Assert.AreEqual("testTpoLab6 " + random.ToString(), "testTpoLab6 " + random.ToString());
        }
    }
}
