using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Tide_com_Nuint.DMethod;
using Tide_com_Nuint.Utility;

namespace Tide_com_Nuint.PageOMethod
{
    public class ContactUs
    {
        public static void NavigateURL()
        {
            method.driver.Manage().Window.Maximize();
            method.driver.Navigate().GoToUrl(Spreadsheet.excelRead(1, 1));
        }
        public static void ClickOnButton()
        {
            Thread.Sleep(3000);
            method.driver.FindElement(By.XPath("/html/body/div[6]/div/a")).Click();

            //Thread.Sleep(3000);
            method.driver.FindElement(By.XPath("/html/body/div[1]/div[1]/header/div[1]/div/div/div/div[2]/a[2]")).Click();
        }
        public static void TakeSshottest()
        {
            Screenshoot.TakeSshoot("ScrollToLiveChat");
        }
    }
}
