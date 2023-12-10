using OpenQA.Selenium;
using WebAutomation.Pages.BasePage;

namespace WebAutomation.Pages.GoogleSearch
{
    public partial class GoogleSearch : BasePage<GoogleSearch>
    {
        private By SearchBar => By.CssSelector("textarea");
        
        private By SearchResultItem(int index) => By.CssSelector($"[data-view-type='{index}']");
        
        private By CookiesContainerHeader => By.XPath("//h1[contains(.,'Before you continue to Google')]");

        private By RejectCookiesButton => By.XPath("//button[contains(.,'Reject all')]");

        private By FirstCiteElement => By.CssSelector("cite");
    }
}
