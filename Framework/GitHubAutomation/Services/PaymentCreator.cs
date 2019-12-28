using System;
using System.Text;
using GitHubAutomation.Models;

namespace GitHubAutomation.Services
{
    class PaymentCreator
    {
        public static PaymentData WithZeroSummPayment()
        {
            return new PaymentData(TestDataReader.GetTestData("Surname")+" "+ TestDataReader.GetTestData("Name")+" "+ TestDataReader.GetTestData("Patronymic"), TestDataReader.GetTestData("ZeroPayment"), TestDataReader.GetTestData("Comment"));
        }
        public static PaymentData WithEmptyComment()
        {
            return new PaymentData(TestDataReader.GetTestData("Surname") + " " + TestDataReader.GetTestData("Name") + " " + TestDataReader.GetTestData("Patronymic"), TestDataReader.GetTestData("Payment"), TestDataReader.GetTestData("EmptyComment"));
        }
    }
}
