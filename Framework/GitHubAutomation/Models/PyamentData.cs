using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Models
{
    public class PaymentData
    {
        public string FullName { get; set; }
        public string PaymentAmount { get; set; }
        public string Comment { get; set; }
        public PaymentData(string fullName,string paymentAmount,string comment)
        {
            FullName = fullName;
            PaymentAmount = paymentAmount;
            Comment = comment;
        }
    }
}
