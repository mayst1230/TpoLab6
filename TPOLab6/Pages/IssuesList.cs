using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading.Tasks;

namespace TPOLab6.Pages
{
    /// <summary>
    /// Модель  страницы со списком Issue
    /// </summary>
    public class IssuesList
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
        /// Кнопка создания нового Issue
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@href='/mayst1230/CSharpTextParser/issues/new/choose']")]
        [CacheLookup]
        private IWebElement buttonNew;

        /// <summary>
        /// Конструктор модели страницы со списком Issues
        /// </summary>
        /// <param name="driver">Веб-драйвер</param>
        public IssuesList(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Создание нового Issue
        /// </summary>
        /// <returns></returns>
        public IssuesList NewIssue()
        {
            Task.Delay(2000).Wait();
            buttonNew.Click();

            Task.Delay(2000).Wait();
            return new IssuesList(driver);
        }
    }
}
