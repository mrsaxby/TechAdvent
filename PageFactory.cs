using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAutomation.Pages.BasePage;
using WebAutomation.Pages.GoogleSearch;
using WebAutomation.Support;

namespace WebAutomation
{
    public class PageFactory
    {
        private readonly WebDriver _driver;
        private readonly Context _context;
    
    
        PageFactory(WebDriver driver, Context context)
        {
            _driver = driver;
            _context = context;
        }

  

        private GoogleSearch _googleSearch;
        public GoogleSearch GoogleSearch
        {
            get => _googleSearch = _googleSearch ?? new GoogleSearch(_driver, _context);
            set => _googleSearch = value;
        }
    
    
    
    
    
    
    
    }
}
