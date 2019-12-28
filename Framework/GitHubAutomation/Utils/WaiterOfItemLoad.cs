using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GitHubAutomation.Utils
{
    class WaiterOfItemLoad
    {
        public static void WaitUntilText(IWebDriver driver,IWebElement element,string targetText) 
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
              .Until(c => (element.Text == targetText));
        }
        public static void WaitUntilTextDontEmpty(IWebDriver driver, IWebElement element)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(drv => element.Text != "");
        }
        public static void WaitUntilElementToBeClickable(IWebDriver driver, IWebElement element)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
              .Until(ExpectedConditions.ElementToBeClickable(element));
        }
        public static void WaitUntilAlert(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.AlertIsPresent());
        }
        public static void WaitUntilElementDisplayed(IWebDriver driver, IWebElement element)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(c => element.Displayed);
        }
        public static void WaitUntilClassName(IWebDriver driver, IWebElement element, string targetClassName)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(drv => element.GetAttribute("class") == targetClassName);
        }
    }
}
