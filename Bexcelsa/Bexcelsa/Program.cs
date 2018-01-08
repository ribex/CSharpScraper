using System;
using System.Collections.Generic;
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
            // if this fails, site thinks we are using automation to access it... which we are
            chrDr.FindElementByXPath("//*[@id=\"sign-in\"]").Click();
            chrDr.FindElementByXPath("//*[@id=\"authentication_login_email\"]").Click();
            chrDr.Keyboard.SendKeys("rebecca.wagaman@intracitygeeks.org");
            chrDr.Keyboard.SendKeys(Keys.Tab);
            chrDr.Keyboard.SendKeys("ChromeDriver2018");
            chrDr.FindElementByXPath("//*[@id=\"authentication_login_button\"]/input").Click();

            // navigate to Portfolio
            chrDr.FindElementByXPath("//*[@id=\"nav_my_portfolio_tab\"]/a").Click();

            // get portfolio elements
            var portfolioList = chrDr.FindElementsByCssSelector("#side_portfolio");
            foreach (var symbol in portfolioList)
            {
                Console.WriteLine(symbol.Text);
            }
        }
    }
}
