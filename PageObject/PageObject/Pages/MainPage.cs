using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace PageObject.Pages
{
    class MainPage
    {
        private Actions actions;
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[3]/section[1]/div[1]/div/article[1]/div[1]/div[3]")]
        private IWebElement RentButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[1]/td/div/div/table/tbody/tr[1]/td[2]/img")]
        private IWebElement ExtraditionDayButton;
        [FindsBy(How = How.XPath, Using = " /html/body/div[9]/div/a[2]/span")]
        private IWebElement NextMounthButton;
        [FindsBy(How = How.XPath, Using = " /html/body/div[4]/form/table/tbody/tr[3]/td/div[2]/a/div")]
        private IWebElement SubmitButton;
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/form/table/tbody/tr[3]/td/div[1]")]
        private IWebElement ErrorMessageOnFrom;
        
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


        public MainPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            actions = new Actions(driver);
            this.driver = driver;
        }
        public MainPage ClickRentButton()
        {
            actions.MoveToElement(RentButton).Build().Perform();
            actions.MoveToElement(RentButton).Click().Perform();
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
        public MainPage FillFullPersonalInfo(string fullName, string mobilePhone, string birthday)
        {
            FillFullName(fullName);
            FillMobilePhone(mobilePhone);
            FillBirthday(birthday);
            return this;
        }
        public MainPage FillFullPassportInfo(string passportData, string dateOfIssue,string placeOfIssue, string deparmetnCode, string placeOfResidence)
        {
            PassprotFormButton.Click();
            FillPassportData(passportData);
            FillDateOfIssue(dateOfIssue);
            FillPlaceOfIssue(placeOfIssue);
            FillDeparmetnCode(deparmetnCode);
            FillPlaceOfResidence(placeOfResidence);
            return this;
        }
        public MainPage FillFullCertificateInfo(string numberOfCertificate, string dateOfIssueCertificate, string placeOfIssueCertificate)
        {
            CertificateFormButton.Click();
            FillNumberOfCertificate(numberOfCertificate);
            FillDateOfIssueCertificate(dateOfIssueCertificate);
            FillPlaceOfIssueCertificate(placeOfIssueCertificate);
            return this;
        }
        public MainPage FillFullName(string fullName)
        {
            FullNameField.SendKeys(fullName);
            return this;
        }

        public MainPage FillMobilePhone(string mobilePhone)
        {
            MobilePhoneField.SendKeys(mobilePhone);
            return this;
        }
        public MainPage FillBirthday(string birthday)
        {
            BirthdayField.SendKeys(birthday);
            return this;
        }
        public MainPage FillPassportData(string passportData)
        {
            PassportDataField.SendKeys(passportData);
            return this;
        }
        public MainPage FillDateOfIssue(string dateOfIssue)
        {
            DateOfIssueField.SendKeys(dateOfIssue);
            return this;
        }
        public MainPage FillPlaceOfIssue(string placeOfIssue)
        {
            PlaceOfIssueField.SendKeys(placeOfIssue);
            return this;
        }
        public MainPage FillDeparmetnCode(string deparmetnCode)
        {
            DeparmetnCodeField.SendKeys(deparmetnCode);
            return this;
        }
        public MainPage FillPlaceOfResidence(string placeOfResidence)
        {
            PlaceOfResidenceField.SendKeys(placeOfResidence);
            return this;
        }
        public MainPage FillNumberOfCertificate(string numberOfCertificate)
        {
            NumberOfCertificateField.SendKeys(numberOfCertificate);
            return this;
        }
        public MainPage FillDateOfIssueCertificate(string dateOfIssueCertificate)
        {
            DateOfIssueCertificateField.SendKeys(dateOfIssueCertificate);
            return this;
        }
        public MainPage FillPlaceOfIssueCertificate(string placeOfIssueCertificate)
        {
            PlaceOfIssueCertificateField.SendKeys(placeOfIssueCertificate);
            return this;
        }

        public MainPage SelectExecutionDate(int mounthCount)
        {
            ExtraditionDayButton.Click();
            for(int i = 0; i < mounthCount; i++)
            {
                NextMounthButton.Click();
            }
            DateTime dt = DateTime.Now;
            var datePicker = driver.FindElement(By.ClassName("ui-datepicker-calendar"));
            foreach (var date in datePicker.FindElements(By.TagName("a")))
                if (date.Text == dt.Day.ToString()) { date.Click(); return this; }
            datePicker.FindElements(By.TagName("a")).Last().Click();    
            return this;

        }
        #endregion
    }
}
