using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading.Tasks;

namespace TPOLab6.Pages
{
    /// <summary>
    /// Модель главной страницы
    /// </summary>
    public class Index
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
        /// Ссылка на PullRequests
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@aria-label='Pull requests you created']")]
        [CacheLookup]
        private IWebElement pullRequests;

        /// <summary>
        /// Ссылка на Isuues
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@aria-label='Issues you created']")]
        [CacheLookup]
        private IWebElement issues;

        /// <summary>
        /// Ссылка на Marketplace
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@href='/marketplace']")]
        [CacheLookup]
        private IWebElement marketplace;

        /// <summary>
        /// Ссылка на Explore
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@href='/explore']")]
        [CacheLookup]
        private IWebElement explore;

        /// <summary>
        /// PopUp раскрытия доп. действий для пользователя
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@aria-label='View profile and more']")]
        [CacheLookup]
        private IWebElement profile;

        /// <summary>
        /// Поле для поиска репозиториев
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@id='dashboard-repos-filter-left']")]
        [CacheLookup]
        private IWebElement repoSearchField;

        /// <summary>
        /// Кнопка создания репозитория
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@data-hydro-click-hmac='ea2c2500b1948f47f1f999d450d2db8fd692c2c0d57340541e99ebe861fd168f']")]
        [CacheLookup]
        private IWebElement newRepoButton;

        /// <summary>
        /// Дефолтный репозиторий для просмотра содержимого
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@href='/silvathebest/ITdating']")]
        [CacheLookup]
        private IWebElement repoForView;

        /// <summary>
        /// Конструктор модели страницы Index
        /// </summary>
        /// <param name="driver">Веб-драйвер</param>
        public Index(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Получение репозитория для просмотра
        /// </summary>
        /// <returns>Модель страницы Index</returns>
        public Index GetRepoForView()
        {
            Task.Delay(1000).Wait();
            repoForView.Click();

            Task.Delay(1000).Wait();
            return new Index(driver);
        }

        /// <summary>
        /// Создание нового репозитория
        /// </summary>
        /// <returns>Модель страницы Index</returns>
        public Index CreateNewRepo()
        {
            Task.Delay(1000).Wait();
            newRepoButton.Click();

            Task.Delay(1000).Wait();
            return new Index(driver);
        }

        /// <summary>
        /// Поиск репозитория
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Модель страницы Index</returns>
        public Index SearchInListOfRepos(string text)
        {
            Task.Delay(1000).Wait();
            repoSearchField.SendKeys(text);

            Task.Delay(1000).Wait();
            repoSearchField.Clear();

            Task.Delay(1000).Wait();
            return new Index(driver);
        }

        /// <summary>
        /// Взаимодействие с шапкой
        /// </summary>
        /// <returns>Модель страницы Index</returns>
        public Index ClickToHeaderLinks()
        {
            Task.Delay(1000).Wait();
            pullRequests.Click();

            Task.Delay(1000).Wait();
            issues.Click();

            Task.Delay(1000).Wait();
            marketplace.Click();

            Task.Delay(1000).Wait();
            explore.Click();

            Task.Delay(1000).Wait();
            profile.Click();

            Task.Delay(1000).Wait();
            profile.Click();

            Task.Delay(1000).Wait();
            return new Index(driver);
        }

        /// <summary>
        /// Открытие PullRequests
        /// </summary>
        /// <returns>Модель страницы Index</returns>
        public Index ClickToPullRequestsLink()
        {
            Task.Delay(1000).Wait();
            pullRequests.Click();

            Task.Delay(1000).Wait();
            return new Index(driver);
        }

        /// <summary>
        /// Отркытие Issues
        /// </summary>
        /// <returns>Модель страницы Index</returns>
        public Index ClickToIssuesLink()
        {
            Task.Delay(1000).Wait();
            issues.Click();

            Task.Delay(1000).Wait();
            return new Index(driver);
        }
    }
}
