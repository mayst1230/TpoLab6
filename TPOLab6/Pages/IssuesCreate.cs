using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading.Tasks;

namespace TPOLab6.Pages
{
    /// <summary>
    /// Модель страницы создания нового Issue
    /// </summary>
    public class IssuesCreate
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
        /// Название Issue
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@id='issue_title']")]
        [CacheLookup]
        private IWebElement title;

        /// <summary>
        /// Кнопка создания Issue
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@class='btn-primary btn']")]
        [CacheLookup]
        private IWebElement create;

        /// <summary>
        /// Конструктор модели страницы создания нового Issue
        /// </summary>
        /// <param name="driver">Веб-драйвер</param>
        public IssuesCreate(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Создание нового Issue
        /// </summary>
        /// <returns>Модель страницы создания Issue</returns>
        public IssuesCreate CreateIssue()
        {
            Task.Delay(2000).Wait();
            create.Click();

            Task.Delay(2000).Wait();
            return new IssuesCreate(driver);
        }

        /// <summary>
        /// Передача названия Issue
        /// </summary>
        /// <param name="name">Название нового Issue</param>
        public void SetIssueTitle(string name)
        {
            Task.Delay(2000).Wait();
            title.SendKeys(name);
        }
    }
}
