using OpenQA.Selenium;

namespace WebAutomation.Helpers
{
    public static class WebDriverHelper
    {
        public static string parentWindow;

        public static string GetURL(this WebDriver webDriver)
        {
            return webDriver.Url;
        }

        public static string GetTitle(this WebDriver webDriver)
        {
            return webDriver.Title;
        }

        public static void RefreshPage(this WebDriver webDriver)
        {
            webDriver.Navigate().Refresh();
        }

        public static void ClickForwardBrowserButton(this WebDriver webDriver)
        {
            webDriver.Navigate().Forward();
        }

        public static void ClickBackBrowserButton(this WebDriver webDriver)
        {
            webDriver.Navigate().Back();
        }

        public static void NavigateToURL(this WebDriver webDriver, string URL)
        {
            webDriver.Navigate().GoToUrl(URL);
        }
    }
}
