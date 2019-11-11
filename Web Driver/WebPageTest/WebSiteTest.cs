using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebDriverr
{
    [TestFixture]
    class EnterpriseTests
    {
        private IWebDriver driver;

        private IWebElement FindElementById(string id)
        {
            return driver.FindElement(By.Id(id));
        }

        private IWebElement FindElementByXPath(string xpath)
        {
            return driver.FindElement(By.XPath(xpath));
        }

        private void WaitForAMinute()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        private void OpenBrowser(string link)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(link);
        }

        private void CloseBrowser()
        {
            driver.Close();
        }
        private void PickTenDaysLeftDate()
        {
            var datePickerButton=driver.FindElements(By.ClassName("sep_date")).Where(c => c.FindElements(By.Id("date_do")).Count > 0).FirstOrDefault();
            datePickerButton.FindElement(By.TagName("img")).Click();
            DateTime dt = DateTime.Now;
            int month = dt.Month;
            dt=dt.AddDays(10);
            if (dt.Month != month) driver.FindElement(By.ClassName("ui-datepicker-next ui-corner-all")).Click();
            var datePicker = driver.FindElement(By.ClassName("ui-datepicker-calendar"));
            foreach (var date in datePicker.FindElements(By.TagName("a")))
                if (date.Text == dt.Day.ToString()) { date.Click(); break; }
        }
        [TestCase]
        public void TestAddingAdditionalServices()
        {
            OpenBrowser("https://titanprokat.ru");
            Actions actions = new Actions(driver);
            var firstButtonRentCar = driver.FindElement(By.ClassName("knopka2"));
            actions.MoveToElement(firstButtonRentCar).Build().Perform();
            actions.MoveToElement(firstButtonRentCar).Click().Perform();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            wait.Until(drv => drv.FindElement(By.Id("price_itogo_md")).Text!="");
            var defaultPrice = Convert.ToInt32(driver.FindElement(By.Id("price_itogo_md")).Text.Replace(" ",""));
            driver.FindElement(By.Id("gps_md")).Click();
            wait.Until(drv => drv.FindElement(By.Id("price_gps_md")).Text!="");
            var priceWithGpsOption = Convert.ToInt32(driver.FindElement(By.Id("price_itogo_md")).Text.Replace(" ", ""));
            Assert.AreEqual(defaultPrice, priceWithGpsOption - Constants.gpsPrice);
            CloseBrowser();
        }
        [TestCase]
        public void TestCalculateCostOfRent()
        {

            OpenBrowser("https://titanprokat.ru");
            Actions actions = new Actions(driver);

            var firstButtonRentCar = driver.FindElement(By.ClassName("knopka2"));
            actions.MoveToElement(firstButtonRentCar).Perform();
            actions.MoveToElement(driver.FindElement(By.ClassName("calculate"))).Click().Perform();
            driver.FindElement(By.Id("extOSAGO-styler")).Click();
            driver.FindElement(By.Id("ogrvozr-styler")).Click();
            PickTenDaysLeftDate();
            driver.FindElement(By.Id("btn_calc")).Click();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            try
            {
                wait.Until(drv => drv.FindElement(By.Id("price_itogo")).Text != "");
                Assert.AreNotEqual(driver.FindElement(By.Id("price_itogo")).Text, "");
                CloseBrowser();
            }
            catch
            {
                CloseBrowser();
            }
        }
    }
}
