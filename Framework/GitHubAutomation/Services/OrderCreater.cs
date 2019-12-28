using System;
using System.Text;
using GitHubAutomation.Models;

namespace GitHubAutomation.Services
{
    class OrderCreater
    {
        public static OrderData WithInvalidPhoneNumber()
        {
            return new OrderData(TestDataReader.GetTestData("ClassOfAuto"), TestDataReader.GetTestData("NameOfAuto"), TestDataReader.GetTestData("InvalidPhoneNumber"));
        }
        public static OrderData WithPersonalInforamation()
        {
            return new OrderData(TestDataReader.GetTestData("Surname"), TestDataReader.GetTestData("Name"),TestDataReader.GetTestData("Patronymic"), TestDataReader.GetTestData("PhoneNumber"), TestDataReader.GetTestData("BirthdayDate"));
        }
      
        public static OrderData WithPassportInforamation()
        {
            return new OrderData(true, TestDataReader.GetTestData("PassportSeriesAndNum"),
                TestDataReader.GetTestData("DateOfPassprotIssue"),
                TestDataReader.GetTestData("PlaceOfPassprotIssue"),
                TestDataReader.GetTestData("DivisionCodeOfPassprotIssue"),
                TestDataReader.GetTestData("ResidenceAddress"));
        }
        public static OrderData WithCertificateInformation()
        {
            return new OrderData(true, TestDataReader.GetTestData("Number"),
                TestDataReader.GetTestData("DateOfCertificateIssue"),
                TestDataReader.GetTestData("PlaceOfCertificateIssue"));
        }
    }
}
