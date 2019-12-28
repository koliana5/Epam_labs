using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Models
{
    public class OrderData
    {
        public string CarClass { get; set; }
        public string Automobile { get; set; }
        public string MobilePhone { get; set; }
        public string FullName { get; set; }
        public string Birthday { get; set; }
        public string PassportSeriesAndNum{ get; set; }
        public string DateOfIssue{ get; set; }
        public string PlaceOfIssue{ get; set; }
        public string DivisionCodeOfPassprotIssue{ get; set; }
        public string ResidenceAddress{ get; set; }
        public string Number { get; set; }
        public OrderData(string carClass,string automobile,string mobilePhone)
        {
            CarClass = carClass;
            Automobile = automobile;
            MobilePhone = mobilePhone;
        }
        public OrderData(string surname, string name, string patronymic,string mobilePhone,string birthdayDate)
        {
            FullName = surname + " " + name + " " + patronymic;
            MobilePhone = mobilePhone;
            Birthday = birthdayDate;
        }
        public OrderData(bool passport, string passportSeriesAndNum, string dateOfPassprotIssue, string placeOfPassprotIssue, string divisionCodeOfPassprotIssue, string residenceAddress)
        {
            PassportSeriesAndNum = passportSeriesAndNum;
            DateOfIssue = dateOfPassprotIssue;
            PlaceOfIssue = placeOfPassprotIssue;
            DivisionCodeOfPassprotIssue = divisionCodeOfPassprotIssue;
            ResidenceAddress = residenceAddress;
        }
        public OrderData(bool certificate, string number,string dateOfIssue,string placeOfIssue)
        {
            Number = number;
            DateOfIssue = dateOfIssue;
            PlaceOfIssue = placeOfIssue;
        }
    }
}
