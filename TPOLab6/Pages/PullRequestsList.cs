using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading.Tasks;

namespace TPOLab6.Pages
{
    /// <summary>
    /// Модель страницы со списком PullRequests
    /// </summary>
    public class PullRequestsList
    {
        /// <summary>
        /// Веб-драйвер
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        /// Ожидание инициализации элементов в DOM
        /// </summary>
        private WebDriverWait wait;

        /// <summary>
        /// Дефолтный PullRequest для просмотра
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@id='issue_15_mayst1230_PIbd-22-Mayorov-Y.A.-TravelAgency_link']")]
        [CacheLookup]
        private IWebElement pullRequest;

        /// <summary>
        /// Конструктор модели страницы со списком PullRequests
        /// </summary>
        /// <param name="driver">Веб-драйвер</param>
        public PullRequestsList(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Получение PullRequest для просмотра
        /// </summary>
        /// <returns>Модель страницы со списком PullRequests</returns>
        public PullRequestsList GetPullRequest()
        {
            Task.Delay(2000).Wait();
            pullRequest.Click();

            return new PullRequestsList(driver);
        }
    }
}
