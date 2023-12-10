using TechTalk.SpecFlow;
using WebAutomation.Support;
using OpenQA.Selenium;

namespace WebAutomation.StepDefinitions
{
    [Binding]
    public sealed class GoogleSearchStepDefinitions : BaseStepDefinitions
    {
        public GoogleSearchStepDefinitions(Context context, WebDriver driver, PageFactory pageFactory) : base(context, driver, pageFactory) { }

        [StepDefinition(@"I search for facebook")]
        public void SearchForFacebook()
        {
            _pageFactory.GoogleSearch.ISearchForFacebook();   
        }

        [StepDefinition(@"I reject the site cookies")]
        public void RejectSiteCookies()
        {
            _pageFactory.GoogleSearch.RejectSiteCookies();
        }

        [StepDefinition(@"I click the first result")]
        public void IClickTheFirstResult()
        {
            _pageFactory.GoogleSearch.IClickTheFirstResult();
        }

        [StepDefinition(@"The first result is '(.*)'")]
        public void ReturnFirstResult(string URL)
        {
            _pageFactory.GoogleSearch.ReturnFirstResult(URL);
        }

    }
}
