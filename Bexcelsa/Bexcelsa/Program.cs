using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Bexcelsa
{
    class Program
    {
        static void Main(string[] args)
        {
            var chrDr = new ChromeDriver(@"C:\Users\Rebecca\source\repos\CSharpScraper\Bexcelsa");
            chrDr.Navigate().GoToUrl("https://seekingalpha.com/");

//            chromeDriver.FindElementByXPath("//*[@id=\"hd-auto\"]").Click();
//            chromeDriver.Keyboard.SendKeys("Amazon");
//            chromeDriver.Keyboard.SendKeys(Keys.Enter);

            // log in to site
            chrDr.FindElementByXPath("//*[@id=\"sign-in\"]").Click();
            chrDr.FindElementByXPath("//*[@id=\"authentication_login_email\"]").Click();
            chrDr.Keyboard.SendKeys("rebecca.wagaman@intracitygeeks.org");
            chrDr.Keyboard.SendKeys(Keys.Tab);
            chrDr.Keyboard.SendKeys("ChromeDriver2018");
            chrDr.Keyboard.SendKeys(Keys.Tab);
            chrDr.Keyboard.SendKeys(Keys.Enter);
        }
    }
}
