using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading.Tasks;

namespace TPOLab6.Pages
{
    /// <summary>
    /// Модель страницы просмотра PullRequest
    /// </summary>
    public class PullRequestInfo
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
        /// Вкладка с измененными файлами
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@id='repo-content-pjax-container']/div/div[2]/div[2]/nav/a[4]")]
        [CacheLookup]
        private IWebElement filesChanged;

        /// <summary>
        /// Конструктор модели страницы просмотра PullReques
        /// </summary>
        /// <param name="driver">Веб-драйвер</param
        public PullRequestInfo(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2000));
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Просмотр PullRequest
        /// </summary>
        /// <returns>Модель страницы просмотра PullRequest</returns>
        public PullRequestInfo ViewPullRequest()
        {
            Task.Delay(1000).Wait();
            filesChanged.Click();

            Task.Delay(2000).Wait();
            driver.GetElementAndScrollTo(By.XPath("//*[@href='https://github.com/pricing']"), 100);

            Task.Delay(2000).Wait();
            return new PullRequestInfo(driver);
        }
    }
}
