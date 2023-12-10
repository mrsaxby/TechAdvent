using OpenQA.Selenium;
using WebAutomation.Support;

namespace WebAutomation.Pages.BasePage
{
    public abstract partial class BasePage<T> where T : BasePage<T>
    {
        protected readonly WebDriver _webDriver;

        public BasePage(WebDriver webDriver, Context context) {
            _webDriver = webDriver;
        }

        public IWebElement GetElement(By element) {
            return _webDriver.FindElement(element);
        }

        public string GetElementText(By element)
        {
            return GetElement(element).Text;
        }

        public string GetElementValue(By element, string attribute)
        {
            return GetElement(element).GetAttribute(attribute);
        }
    }
}
