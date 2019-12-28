using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GitHubAutomation.Utils
{
    class CalendarManager
    {
        public static void SetDateCalendar(IWebElement calendar, int days)
        {
            var keys = days > 0 ? Keys.ArrowRight : Keys.ArrowLeft;

            for (int i = 0; i < Math.Abs(days); i++)
                calendar.SendKeys(keys);
        }
        public static void SetDate(IWebDriver driver,IWebElement CalendarButton,int daysPassed, int mouthPassed)
        {
            CalendarButton.Click();
            DateTime dt = DateTime.Now;
            int month = dt.Month;
            dt = dt.AddDays(10);
            if (dt.Month != month)
            {
                mouthPassed += 1;
            }
            for (int i = 0; i < mouthPassed; i++)
            {
                driver.FindElement(By.ClassName("ui-datepicker-next")).Click();
            }
            var datePicker = driver.FindElement(By.ClassName("ui-datepicker-calendar"));
            foreach (var date in datePicker.FindElements(By.TagName("a")))
                if (date.Text == dt.Day.ToString())
                { date.Click(); break; }
        }
    }
}
