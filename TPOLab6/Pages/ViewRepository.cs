using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading.Tasks;

namespace TPOLab6.Pages
{
    /// <summary>
    /// Модель страницы просмотра репозитория
    /// </summary>
    public class ViewRepository
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
        /// Конструктор модели страницы просмотра репозитория
        /// </summary>
        /// <param name="driver">Веб-драйвер</param>
        public ViewRepository(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Просмотр репозитория
        /// </summary>
        /// <returns>Модель страницы просмотра репозитория</returns>
        public ViewRepository ViewRepo()
        {
            Task.Delay(2000).Wait();

            //Самописный extension для IWebDriver для прокрутки страницы до заданного элемента
            driver.GetElementAndScrollTo(By.XPath("//*[@href='https://github.com/pricing']"), 12);

            return new ViewRepository(driver);
        }
    }
}
