using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using TPOLab6.Pages;

namespace TPOLab6
{
    [TestClass]
    public class PullRequests
    {
        private IWebDriver webDriver = InstanceOfWebDriver.GetWebDriver();

        [SetUp]
        private void Setup()
        {
            webDriver.Url = "https://github.com/";
        }

        [TestMethod]
        public void ViewPullRequest()
        {
            Setup();

            Index indexPage = new Index(webDriver);
            indexPage.ClickToPullRequestsLink();

            PullRequestsList pullRequestsListPage = new PullRequestsList(webDriver);
            pullRequestsListPage.GetPullRequest();

            PullRequestInfo pullRequestInfoPage = new PullRequestInfo(webDriver);
            pullRequestInfoPage.ViewPullRequest();
        }
    }
}
