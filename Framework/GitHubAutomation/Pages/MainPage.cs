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
    public class MainPage
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this.driver = driver;
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[1]/td/div/div/table/tbody/tr[1]/td[2]/img")]
        private IWebElement ExtraditionDayButton;
        [FindsBy(How = How.XPath, Using = " /html/body/div[9]/div/a[2]/span")]
        private IWebElement NextMounthButton;
        [FindsBy(How = How.XPath, Using = " /html/body/div[4]/form/table/tbody/tr[3]/td/div[2]/a/div")]
        private IWebElement SubmitButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[3]/td/div[1]")]
        private IWebElement ErrorMessageOnFrom;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[3]/section[1]/div[1]/div/article[1]/div[1]/div[3]")]
        private IWebElement ChevreletRentButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[1]/td/div/div/div/div/table[1]/tbody/tr[1]/td[2]/p/span[1]")]
        private IWebElement FullCostField;
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[1]/td/div/div/div/div/table[2]/tbody/tr[2]/td[2]/p/span[1]")]
        private IWebElement GpsOptionCostField;
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[1]/td/div/div/div/div/table[2]/tbody/tr[5]/td[2]/p/span[1]")]
        private IWebElement LimitationOfLiabilityOptionField;
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[1]/td/div/div/div/span[6]/input")]
        private IWebElement LimitationOfLiabilityOnRentCheckBox;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[3]/section[1]/div[1]/div/article[1]/div[2]/div[1]/div[2]/a[2]")]
        private IWebElement CalculateRentButton;




        #region menu
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/nav/ul/li[4]/a")]
        private IWebElement RequirementMenuButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/nav/ul/li[4]/ul/li/a")]
        private IWebElement OnlinePaymentSubmenuButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/nav/ul/li[1]/a")]
        private IWebElement AutoparkMenuButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/nav/ul/li[1]/ul/li[4]/a")]
        private IWebElement ByBrandSubmenuButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/nav/ul/li[1]/ul/li[4]/ul/li[3]/a")]
        private IWebElement ChevreletSubMenuButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/nav/ul/li[2]/a")]
        private IWebElement ServicesMenuButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/nav/ul/li[2]/ul/li[14]/a")]
        private IWebElement TransportOutsourcingSubMenuButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/nav/ul/li[9]/a")]
        private IWebElement UsefulMenuButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/nav/ul/li[9]/ul/li[4]/a")]
        private IWebElement RentalAgreementSubmenuButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/nav/ul/li[10]/a")]
        private IWebElement ContactInformationMenuButton;
        #endregion
        #region bookCarinOneHour
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/section/div[1]/form/div/div[1]/div/div")]
        private IWebElement ClassChange;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/section/div[1]/form/div/div[2]/div/div/div")]
        private IWebElement AutoChange;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/section/div[1]/form/div/div[3]/div[2]/input")]
        private IWebElement DateOfIssue;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/section/div[1]/form/div/div[4]/input")]
        private IWebElement PhoneNumber;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/section/div[1]/form/div/div[5]/a")]
        private IWebElement BookButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/section/div[1]/form/div/div[1]/div/div/div[2]/ul")]
        private IWebElement ComboBoxAutoClass;
        [FindsBy(How = How.XPath, Using = " /html/body/div[1]/div/header/div/section/div[1]/form/div/div[2]/div/div/div/div[2]/ul")]
        private IWebElement ComboBoxAuto;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/header/div/section/img")]
        private IWebElement ConfirmOrderImage;

        #endregion
        #region personalData
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[2]/div[1]/table/tbody/tr[1]/td[2]/input")]
        private IWebElement FullNameField;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[2]/div[1]/table/tbody/tr[2]/td[2]/input")]
        private IWebElement MobilePhoneField;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[2]/div[1]/table/tbody/tr[3]/td[2]/input")]
        private IWebElement BirthdayField;
        #endregion
        #region passport
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[1]/a[2]/span")]
        private IWebElement PassprotFormButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[2]/div[3]/table/tbody/tr[1]/td[2]/input")]
        private IWebElement PassportDataField;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[2]/div[3]/table/tbody/tr[2]/td[2]/input")]
        private IWebElement DateOfIssueField;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[2]/div[3]/table/tbody/tr[3]/td[2]/input")]
        private IWebElement PlaceOfIssueField;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[2]/div[3]/table/tbody/tr[4]/td[2]/input")]
        private IWebElement DeparmetnCodeField;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[2]/div[3]/table/tbody/tr[5]/td[2]/input")]
        private IWebElement PlaceOfResidenceField;
        #endregion
        #region certificate
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[1]/a[3]/span")]
        private IWebElement CertificateFormButton;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[2]/div[2]/table/tbody/tr[1]/td[2]/input")]
        private IWebElement NumberOfCertificateField;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[2]/div[2]/table/tbody/tr[2]/td[2]/input")]
        private IWebElement DateOfIssueCertificateField;

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[2]/td/div[2]/div[2]/table/tbody/tr[3]/td[2]/input")]
        private IWebElement PlaceOfIssueCertificateField;
        #endregion
        public MainPage FillInFieldDataForRentInOneHour(OrderData orderData) //model needed
        {
            ClassChange.Click();

            ComboBoxAutoClass.FindElements(By.TagName("li"))
                   .Select(c => c)
                   .Where(c => c.Text == orderData.CarClass)
                   .First()
                   .Click();
            WaiterOfItemLoad.WaitUntilText(driver, ClassChange, orderData.CarClass); // wait until see this change but next comboboxx button is not clickable without Sleep

            Thread.Sleep(250);
            AutoChange.Click();

            ComboBoxAuto.FindElements(By.TagName("li"))
             .Select(c => c)
             .Where(c => c.Text == orderData.Automobile)
             .First()
             .Click();

            WaiterOfItemLoad.WaitUntilText(driver, AutoChange, orderData.Automobile); //wait until see this change but next comboboxx button is not clickable without Sleep
            Thread.Sleep(250);
            DateOfIssue.Click();
            PhoneNumber.SendKeys(orderData.MobilePhone);
            return this;
        }
        public MainPage ClickRentChevroletButton()
        {
            new Actions(driver).MoveToElement(ChevreletRentButton).Build().Perform();
            new Actions(driver).MoveToElement(ChevreletRentButton).Click().Perform();
            return this;
        }
        public int GetFullCost()
        {
            WaiterOfItemLoad.WaitUntilTextDontEmpty(driver, FullCostField);
            return Int32.Parse(FullCostField.Text.Replace(" ", ""));
        }
        public int GetGpsOptionPriceCost()
        {
            WaiterOfItemLoad.WaitUntilTextDontEmpty(driver, GpsOptionCostField);
            return Int32.Parse(GpsOptionCostField.Text.Replace(" ", ""));
        }
        public int GetLimitationOfLiabilityOptionPriceCost()
        {
            WaiterOfItemLoad.WaitUntilTextDontEmpty(driver, LimitationOfLiabilityOptionField);
            return Int32.Parse(LimitationOfLiabilityOptionField.Text.Replace(" ", ""));
        }
        public MainPage ClickAddLimitationOfLiabilityOption()
        {
            LimitationOfLiabilityOnRentCheckBox.Click();
            return this;
        }

        public MainPage ClickBookButton()
        {
            BookButton.Click();
            return this;
        }
        public MainPage ClickRentButton()
        {
            var actions = new Actions(driver);
            actions.MoveToElement(ChevreletRentButton).Build().Perform();
            actions.MoveToElement(ChevreletRentButton).Click().Perform();
            return this;
        }

        public MainPage ClickSubmitButton()
        {
            SubmitButton.Click();
            return this;
        }
        public string ReturnErrorMessage()
        {
            return ErrorMessageOnFrom.Text;
        }
        #region FillingMethods
        public MainPage FillFullPersonalInfo(OrderData orderData)
        {
            FullNameField.SendKeys(orderData.FullName);
            MobilePhoneField.SendKeys(orderData.MobilePhone);
            BirthdayField.SendKeys(orderData.Birthday);
            return this;
        }
        public MainPage FillFullPassportInfo(OrderData orderData)
        {

            PassportDataField.SendKeys(orderData.PassportSeriesAndNum);
            DateOfIssueField.SendKeys(orderData.DateOfIssue);
            PlaceOfIssueField.SendKeys(orderData.PlaceOfIssue);
            DeparmetnCodeField.SendKeys(orderData.DivisionCodeOfPassprotIssue);
            PlaceOfResidenceField.SendKeys(orderData.ResidenceAddress);
            return this;
        }
        public MainPage FillFullCertificateInfo(OrderData orderData)
        {
            NumberOfCertificateField.SendKeys(orderData.Number);
            DateOfIssueCertificateField.SendKeys(orderData.DateOfIssue);
            PlaceOfIssueCertificateField.SendKeys(orderData.PlaceOfIssue);
            return this;
        }
        public MainPage ClickPassprotFormButton()
        {
            PassprotFormButton.Click();
            return this;
        }
        public MainPage ClickCertificateFormButton()
        {
            CertificateFormButton.Click();
            return this;
        }
        public OnlinePaymentPage GoToTabOnlinePayment()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(RequirementMenuButton).Perform();
            WaiterOfItemLoad.WaitUntilElementToBeClickable(driver, OnlinePaymentSubmenuButton);
            OnlinePaymentSubmenuButton.Click();
            return new OnlinePaymentPage(driver);
        }
        public TransportOutsourcingPage GoToTabTransportOutsourcing()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(ServicesMenuButton).Perform();
            WaiterOfItemLoad.WaitUntilElementToBeClickable(driver, TransportOutsourcingSubMenuButton);
            TransportOutsourcingSubMenuButton.Click();
            return new TransportOutsourcingPage(driver);
        }
        public RentalAgreementPage GoToTabRentalAgreement()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(UsefulMenuButton).Perform();
            WaiterOfItemLoad.WaitUntilElementToBeClickable(driver, RentalAgreementSubmenuButton);
            RentalAgreementSubmenuButton.Click();
            return new RentalAgreementPage(driver);
        }
        public ContactInformationPage GoToContactInformation()
        {
            ContactInformationMenuButton.Click();
            return new ContactInformationPage(driver);
        }
        public CarsPage GoToTabChevroletCars()
        {
            Actions action = new Actions(driver);
            action.MoveToElement(AutoparkMenuButton).Perform();
            WaiterOfItemLoad.WaitUntilElementToBeClickable(driver, ByBrandSubmenuButton);
            action.MoveToElement(ByBrandSubmenuButton).Perform();
            WaiterOfItemLoad.WaitUntilElementToBeClickable(driver, ChevreletSubMenuButton);
            action.MoveToElement(ByBrandSubmenuButton).Perform();
            ChevreletSubMenuButton.Click();
            return new CarsPage(driver);
        }
        public CalculatePage GoToTabCalculateRent()
        {
            var actions = new Actions(driver);
            actions.MoveToElement(ChevreletRentButton).Build().Perform();
            actions.MoveToElement(CalculateRentButton).Click().Perform();
            return new CalculatePage(driver);
        }
        public MainPage SelectExecutionDate(int mounthCount)
        {
            CalendarManager.SetDate(driver, ExtraditionDayButton, 0, 12);
            return this;
        }
        public string GetTextFromAlert()
        {
            string error = "";
            try
            {
                WaiterOfItemLoad.WaitUntilAlert(driver);
            }
            catch
            {
                return null;
            }
            var alert = driver.SwitchTo().Alert();
            if (alert != null)
            {
                error = alert.Text;
                alert.Accept();
            }
            return error;
        }
        public bool IsConfirmOrderImageDisplayed()
        {
            try
            {
                WaiterOfItemLoad.WaitUntilElementDisplayed(driver, ConfirmOrderImage);
                return ConfirmOrderImage.Displayed;
            }
            catch
            {
                return ConfirmOrderImage.Displayed;
            }
        }
        #endregion
    }
}
