using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading.Tasks;

namespace TPOLab6.Pages
{
    /// <summary>
    /// Модель страницы авторизации
    /// </summary>
    public class Login
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
        /// Поле логина
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@id='login_field']")]
        [CacheLookup]
        private IWebElement login;

        /// <summary>
        /// Поле пароля
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@id='password']")]
        [CacheLookup]
        private IWebElement password;

        /// <summary>
        /// Кнопка авторизации
        /// </summary>
        [FindsBy(How = How.XPath, Using = "//*[@value='Sign in']")]
        [CacheLookup]
        private IWebElement signIn;

        /// <summary>
        /// Конструктор модели страницы авторизации
        /// </summary>
        /// <param name="driver">Веб-драйвер</param>
        public Login(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Авторизация
        /// </summary>
        /// <returns>Модель страницы авторизации</returns>
        public Login Authorization()
        {
            Task.Delay(1000).Wait();
            signIn.Click();

            return new Login(driver);
        }

        /// <summary>
        /// Передача логина и пароля в соответствующие поля
        /// </summary>
        /// <param name="loginValue">Логин</param>
        /// <param name="passwordValue">Пароль</param>
        public void SetLoginPasswordValue(string loginValue, string passwordValue)
        {
            Task.Delay(1000).Wait();
            login.SendKeys(loginValue);

            Task.Delay(1000).Wait();
            password.SendKeys(passwordValue);
        }
    }
}
