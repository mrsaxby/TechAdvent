using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using WebAutomation.Support;

namespace WebAutomation.Helpers
{
    public  class ChromeHelper
    {
        private bool _isHeadless = false;
        private readonly Context context = new Context();

        public ChromeHelper() { 
        }

        public ChromeDriver CreateChromeDriver(bool isIncognito)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.prompt_for_download", false);

            if(isIncognito)
            {
                options.AddArgument("incognito");
            }

            var driverService = ChromeDriverService.CreateDefaultService(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driverService.SuppressInitialDiagnosticInformation = true;

            return new ChromeDriver(driverService, options);
        }
    }
}
