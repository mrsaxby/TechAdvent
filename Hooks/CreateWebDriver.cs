using OpenQA.Selenium;
using System;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.TestFramework;
using WebAutomation.Helpers;
using WebAutomation.Support;

namespace WebAutomation.Hooks
{
    [Binding]
    public class CreateWebDriver
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly ITestRunContext _testRunContext;
        private readonly Context _context;
        WebDriver webDriver;

        public CreateWebDriver(ScenarioContext scenarioConext, ITestRunContext testRunContext) {
            _scenarioContext = scenarioConext;
            _testRunContext = testRunContext;
            _context = _scenarioContext.ScenarioContainer.Resolve<Context>();
        }

        [BeforeScenario(Order = 0)]
        public void BeforeInitializeDriver()
        {
            ChromeHelper chromeHelper = new ChromeHelper();
            webDriver = chromeHelper.CreateChromeDriver(IsIncognito());
            webDriver.Manage().Window.Maximize();
            
            _scenarioContext.ScenarioContainer.RegisterInstanceAs(webDriver, dispose: true);
            webDriver.Manage().Cookies.DeleteAllCookies();
        }

        public bool IsIncognito()
        {
            return _scenarioContext.ScenarioInfo.ScenarioAndFeatureTags.Where(x => x.Contains("Incognito")).ToList().Count > 0;
        }
    }
}
