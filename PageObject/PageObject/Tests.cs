
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using PageObject.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace PageObject
{
    [TestClass]
    public class Tests
    {
        private IWebDriver driver;
        private static string HomePage = "https://titanprokat.ru/";
        [TestMethod]
        public void RentInVeryLongTime()
        {
            OpenBrowser(HomePage);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            Actions actions = new Actions(driver);
            MainPage mainpage = new MainPage(driver);
            mainpage.ClickRentButton();
            mainpage.FillFullPersonalInfo("1", "2", "3");
            mainpage.FillFullPassportInfo("1", "2", "3","4","5");
            mainpage.FillFullCertificateInfo("1", "2", "3");
            mainpage.SelectExecutionDate(13);
            mainpage.ClickSubmitButton();
            string alertText = GetTextFromAlert();
            Assert.AreEqual(alertText, "Спасибо, Ваша заявка принята, в ближайшее время менеджер свяжется с Вами");
            CloseBrowser();
        }
        [TestMethod]
        public void RentWithoutAnyPersonalData()
        {
            OpenBrowser(HomePage);
            Actions actions = new Actions(driver);
            MainPage mainpage = new MainPage(driver);
            mainpage.ClickRentButton();
            mainpage.ClickSubmitButton();
            string tt = mainpage.ReturnErrorMessage();
            Assert.AreEqual(tt, "Заявка не может быть отправлена, пожалуйста заполните:\r\nЛичные данные: Телефон *;  Личные данные: ФИО *;  Личные данные: Дата рождения *;  Паспорт: Cерия и номер паспорта *;  Паспорт: Дата выдачи *;  Паспорт: Кем выдан *;  Паспорт: Код подразделения *;  Паспорт: Адрес прописки *;  Удостоверение: Номер *;  Удостоверение: Дата выдачи *;  Удостоверение: Кем выдан *");
            CloseBrowser();
        }
        private void OpenBrowser(string link)
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(300);
            driver.Navigate().GoToUrl(link);
        }

        private void CloseBrowser()
        {
            driver.Close();
        }
        private string GetTextFromAlert()
        {
            string error = "";
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.AlertIsPresent());
            var alert = driver.SwitchTo().Alert();
            if (alert != null)
            {
                error = alert.Text;
                alert.Accept();
            }
            return error;
        }
    }
}
