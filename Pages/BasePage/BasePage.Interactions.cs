using OpenQA.Selenium;

namespace WebAutomation.Pages.BasePage
{
    public abstract partial class BasePage<T> where T : BasePage<T>
    {
       
        public void Click(By element)
        {
            GetElement(element).Click();
        }

        public void EnterText(By element, string text)
        {
            GetElement(element).SendKeys(text);
        }

        public void ClearInput(By element)
        {
            GetElement(element).Clear();
        }
    }
}
