using System;
using System.Text;
using System.Linq;
using NUnit.Framework;
using GitHubAutomation.Driver;
using GitHubAutomation.Pages;
using GitHubAutomation.Services;
using GitHubAutomation.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.Extensions;

namespace GitHubAutomation.Tests
{
    [TestFixture]
    public class WebTests : GeneralConfig
    {

        [Test] 
        public void RentCarInOneMinitePhoneTest()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                MainPage mainPage = new MainPage(Driver)
                  .FillInFieldDataForRentInOneHour(OrderCreater.WithInvalidPhoneNumber())
                  .ClickBookButton();
                Assert.IsTrue(mainPage.IsConfirmOrderImageDisplayed());
            });
        }
        [Test] 
        public void ZeroSummPayment()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                OnlinePaymentPage mainPage = new MainPage(Driver)
                  .GoToTabOnlinePayment()
                  .FillInFieldDataForPayService(PaymentCreator.WithZeroSummPayment())
                  .ClickСonfirmationWithRequirements()
                  .ClickSendButton();
                Assert.IsTrue(mainPage.GetErrorState());
            });
        }
        [Test]
        public void EmptyCommentPayment()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                OnlinePaymentPage mainPage = new MainPage(Driver)
                  .GoToTabOnlinePayment()
                  .FillInFieldDataForPayService(PaymentCreator.WithZeroSummPayment())
                  .ClickСonfirmationWithRequirements()
                  .ClickSendButton();
                Assert.IsTrue(mainPage.GetErrorState());
            });
        }
        [Test]
        public void ViewCarsByBrand()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                CarsPage mainPage = new MainPage(Driver)
                  .GoToTabChevroletCars();
                Assert.AreEqual(Constants.pageNameOfShevroletRent, mainPage.GetHeaderText());
            });
        }

        [Test]
        public void ViewCarsForTransportOutsourcing()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                TransportOutsourcingPage mainPage = new MainPage(Driver)
                  .GoToTabTransportOutsourcing();
                Assert.AreEqual(Constants.pageNameOfTransprotOutsorting, mainPage.GetHeaderText());
            });
        }
        [Test]
        public void AddingAdditionalServices()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                MainPage mainPage = new MainPage(Driver)
                  .ClickRentChevroletButton();
                int firstCost = mainPage.GetFullCost();
                mainPage.ClickAddLimitationOfLiabilityOption();
                int limitOfLiablityPrice = mainPage.GetLimitationOfLiabilityOptionPriceCost();
                int secongCost = mainPage.GetFullCost();
                Assert.AreEqual(firstCost, secongCost - limitOfLiablityPrice);
            });
        }
        [Test]
        public void CalculateRentCost()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                CalculatePage mainPage = new MainPage(Driver)
                  .GoToTabCalculateRent()
                  .FillCalculationParametrs()
                  .CalculateClick();
                Assert.IsTrue(mainPage.GetFinalPrice() > 0);
            });
        }

        [Test]
        public void ViewRentalAgreement()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                RentalAgreementPage mainPage = new MainPage(Driver)
                  .GoToTabRentalAgreement();
                Assert.AreEqual(Constants.pageNameOfContract, mainPage.GetHeaderText());
            });
        }
        [Test]
        public void RentWithoutAnyPersonalData()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                MainPage mainPage = new MainPage(Driver)
                .ClickRentButton()
                .ClickSubmitButton();
                Assert.AreEqual(mainPage.ReturnErrorMessage(), Constants.erorMessageWithoutAnyData);
            });
        }

        [Test]
        public void ViewСontactInformation()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                ContactInformationPage mainPage = new MainPage(Driver)
                  .GoToContactInformation();
                Assert.AreEqual("КОНТАКТЫ", mainPage.GetHeaderText());
            });
        }

        [Test]
        public void RentInVeryLongTime()
        {
            Driver.Manage().Window.Maximize();
            TakeScreenshotWhenTestFailed(() =>
            {
                MainPage mainPage = new MainPage(Driver)
              .ClickRentButton()
            .FillFullPersonalInfo(OrderCreater.WithPersonalInforamation())
            .ClickPassprotFormButton()
            .FillFullPassportInfo(OrderCreater.WithPassportInforamation())
            .ClickCertificateFormButton()
            .FillFullCertificateInfo(OrderCreater.WithCertificateInformation())
            .SelectExecutionDate(12)
            .ClickSubmitButton();
                Assert.AreEqual(mainPage.GetTextFromAlert(), Constants.alertConfirmMessage);
            });
        }
    }
}
