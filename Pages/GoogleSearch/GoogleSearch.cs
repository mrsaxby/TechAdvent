using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using TechTalk.SpecFlow.CommonModels;
using WebAutomation.Pages.BasePage;
using WebAutomation.Support;

namespace WebAutomation.Pages.GoogleSearch
{
    public partial class GoogleSearch : BasePage<GoogleSearch>
    {
        public GoogleSearch(WebDriver webDriver, Context context) : base(webDriver, context) { }

        public void ISearchForFacebook()
        {
            EnterText(SearchBar , "facebook");
        }

        public void RejectSiteCookies()
        {
            // Move to helper
            if(_webDriver.FindElement(CookiesContainerHeader).Displayed)
            {
                Click(RejectCookiesButton);
            }
        }

        public void IClickTheFirstResult() 
        {
            Click(SearchResultItem(1));
        }

        public void ReturnFirstResult(string URL)
        {
            Assert.AreEqual(GetElementText(FirstCiteElement), URL, "Failover message");
        }
    }
}
