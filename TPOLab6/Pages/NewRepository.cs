using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading.Tasks;

namespace TPOLab6.Pages
{
    /// <summary>
    /// Модель страницы создания нового репозитория
    /// </summary>
    public class NewRepository
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
        /// Название репозитория
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@id='repository_name']")]
        [CacheLookup]
        private IWebElement name;

        /// <summary>
        /// Кнопка создания репозитория
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@data-disable-with='Creating repository&hellip;']")]
        [CacheLookup]
        private IWebElement create;

        /// <summary>
        /// Конструктор модели страницы создания нового репозитория
        /// </summary>
        /// <param name="driver">Веб-драйвер</param>
        public NewRepository(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Создание нового репозитория
        /// </summary>
        /// <returns>Модель страницы создания нового репозитория</returns>
        public NewRepository CreateNewRepo()
        {
            Task.Delay(2000).Wait();
            create.Click();

            Task.Delay(2000).Wait();
            return new NewRepository(driver);
        }

        /// <summary>
        /// Задание названия репозитория
        /// </summary>
        /// <param name="repoName">Название репозитория</param>
        public void SetRepoName(string repoName)
        {
            Task.Delay(2000).Wait();
            name.SendKeys(repoName);
        }
    }
}
