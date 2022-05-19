using OpenQA.Selenium;

namespace TPOLab6
{
    /// <summary>
    /// Расширение IWebDriver для скроллинга страницы
    /// </summary>
    public static class IWebDriverScroll
    {
        /// <summary>
        /// Получение элемента на странице и скроллмнг до полученного элемента
        /// </summary>
        /// <param name="driver">Веб-драйвер</param>
        /// <param name="by">Путь до элемента</param>
        /// <param name="speed">Скорость прокрутки</param>
        /// <returns>Найденный элемент</returns>
        public static IWebElement GetElementAndScrollTo(this IWebDriver driver, By by, int speed)
        {
            var js = (IJavaScriptExecutor)driver;

            try
            {
                var element = driver.FindElement(by);

                if (element.Location.Y > 200)
                {
                    for (int i = 0; i < element.Location.Y; i += speed)
                    {
                        js.ExecuteScript($"window.scrollTo({0}, {i})");
                    }

                }

                return element;
            }
            catch
            {
                return null;
            }
        }
    }
}
