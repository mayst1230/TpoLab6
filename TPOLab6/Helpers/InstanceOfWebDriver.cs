using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TPOLab6
{
    /// <summary>
    /// Статический класс для создания экземпляра IWebDriver
    /// </summary>
    public static class InstanceOfWebDriver
    {
        /// <summary>
        /// Экземпляр IWebDriver
        /// </summary>
        public static IWebDriver webDriver = new ChromeDriver();

        /// <summary>
        /// Получение экземпляра IWebDriver
        /// </summary>
        /// <returns>Статический экземпляр IWebDriver</returns>
        public static IWebDriver GetWebDriver()
        { 
            return webDriver;
        }
    }
}
