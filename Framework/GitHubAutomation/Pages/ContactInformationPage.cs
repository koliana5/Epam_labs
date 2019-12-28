using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using GitHubAutomation.Models;
using GitHubAutomation.Utils;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GitHubAutomation.Pages
{
    public class ContactInformationPage
    {
        private IWebDriver driver;
        public ContactInformationPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/div/div/div[1]/div/h1")]
        private IWebElement pageHeader;

        public string GetHeaderText()
        {
            return pageHeader.Text;
        }
    }
}
