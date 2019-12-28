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
    public class OnlinePaymentPage
    {
        private IWebDriver driver;
        public OnlinePaymentPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/div/div/div[2]/div/form/div[1]/input")]
        private IWebElement  fullNameField ;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/div/div/div[2]/div/form/div[2]/input")]
        private IWebElement paymentAmountField ;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/div/div/div[2]/div/form/div[3]/textarea")]
        private IWebElement commentField;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/div/div/div[2]/div/form/div[4]/input")]
        private IWebElement agreementCheckBox;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section/div/div/div[2]/div/form/button")]
        private IWebElement sendButton;
        public OnlinePaymentPage FillInFieldDataForPayService(PaymentData payment)
        {
            fullNameField.SendKeys(payment.FullName);
            paymentAmountField.SendKeys(payment.PaymentAmount);
            commentField.SendKeys(payment.Comment);
            return this;
        }
        public OnlinePaymentPage ClickСonfirmationWithRequirements()
        {
            agreementCheckBox.Click();
            return this;
        }
        public OnlinePaymentPage ClickSendButton()
        {
            sendButton.Click();
            return this;
        }
        public bool GetErrorState()
        {
            WaiterOfItemLoad.WaitUntilClassName(driver, paymentAmountField, "input_text_style err_mess");
            return (paymentAmountField.GetAttribute("class") == "input_text_style err_mess");
        }
    }
}
