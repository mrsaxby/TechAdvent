using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace WebAutomation.Support
{
    public class Context
    {
        public Dictionary<string, string> TestData = new Dictionary<string, string>();
        
        public Context() { }    

        public EnvironmentEnums Env
        {
            get
            {
                var env = Environment.GetEnvironmentVariable("ENV") ?? "localhost";
                return env.ToLower() switch
                {
                    "localhost" => EnvironmentEnums.LOCALHOST,
                    "dev" => EnvironmentEnums.DEV,
                    _ => throw new NotImplementedException()
                };
            }
        }

        public string GetDefaultURL
        {
            get
            {
                return Env switch
                {
                    EnvironmentEnums.LOCALHOST => "Some URL",
                    EnvironmentEnums.DEV => "Some dev URL",
                    _ => throw new NotImplementedException(),
                };
            }
        }

        public string GetProxy => Env switch
        {
            EnvironmentEnums.LOCALHOST => "some proxy .pac path",
            EnvironmentEnums.DEV => throw new NotImplementedException(),
            _ => throw new NotImplementedException(),
        };

        public ScenarioContext ScenarioContext { get; internal set; }
    }
}
