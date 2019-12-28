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
    public class CalculatePage
    {
        private IWebDriver driver;
        public CalculatePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/div/div[2]/form/table/tbody/tr[1]/td[4]/div/label[4]/div")]
        private IWebElement LimitationOfLiabilityCheckBox;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/div/div[2]/form/table/tbody/tr[1]/td[4]/div/label[6]/div")]
        private IWebElement ReductionOfAgeAndSeniorityCheckBox;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/div/div[2]/form/table/tbody/tr[2]/td[2]/div/img")]
        private IWebElement RetutnsDayCalendarButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/div/div[2]/form/div/a")]
        private IWebElement CalculateButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/div/div[2]/table/tbody/tr[10]/td[2]/p/span[1]")]
        private IWebElement FinalCostField;

        public CalculatePage FillCalculationParametrs()
        {
            WaiterOfItemLoad.WaitUntilElementToBeClickable(driver,LimitationOfLiabilityCheckBox);
            LimitationOfLiabilityCheckBox.Click();
            ReductionOfAgeAndSeniorityCheckBox.Click();
            new Actions(driver).MoveToElement(RetutnsDayCalendarButton).Build().Perform();
            PickTenDaysLeftDate (RetutnsDayCalendarButton);
            return this;
        }
        private void PickTenDaysLeftDate(IWebElement ReturnsDayCalendarButton)
        {
            CalendarManager.SetDate(driver, ReturnsDayCalendarButton, 10, 0);
        
        }
        public CalculatePage CalculateClick()
        {
            CalculateButton.Click();
            return this;
        }
        public int GetFinalPrice()
        {
            WaiterOfItemLoad.WaitUntilTextDontEmpty(driver, FinalCostField);
            return Int32.Parse(FinalCostField.Text.Replace(" ", ""));
        }
    }
}
