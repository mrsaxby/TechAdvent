using TechTalk.SpecFlow;
using OpenQA.Selenium;
using WebAutomation.Support;
using WebAutomation.Helpers;

namespace WebAutomation.StepDefinitions
{
    public class BaseStepDefinitions
    {
        protected readonly Context _context;
        protected readonly WebDriver _webDriver;
        protected readonly PageFactory _pageFactory;

        public BaseStepDefinitions(Context context, WebDriver webDriver, PageFactory pageFactory) {
            _context = context;
            _webDriver = webDriver;
            _pageFactory = pageFactory;
        }

        ScenarioContext scenarioContext;
        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            _context.ScenarioContext = scenarioContext;
        }

        [Given(@"I navigate to '(.*)'")]
        public void NavigateToGoogleSerach(string URL)
        {
            WebDriverHelper.NavigateToURL(_webDriver, URL);
        }
    }
}
