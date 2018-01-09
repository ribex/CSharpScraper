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
            // may need to add implicit wait or similar strategy
            chrDr.FindElementByXPath("//*[@id=\"sign-in\"]").Click();
            chrDr.FindElementByXPath("//*[@id=\"authentication_login_email\"]").Click();
            chrDr.Keyboard.SendKeys("rebecca.wagaman@intracitygeeks.org");
            chrDr.Keyboard.SendKeys(Keys.Tab);
            chrDr.Keyboard.SendKeys("ChromeDriver2018");
            chrDr.FindElementByXPath("//*[@id=\"authentication_login_button\"]/input").Click();

            var portfolioLink = chrDr.FindElementByXPath("//*[@id=\"nav_my_portfolio_tab\"]/a");
            if (portfolioLink != null)
            {
                // navigate to Portfolio
                try
                {
                    portfolioLink.Click();
                }
                catch (Exception e)
                {
                    throw new Exception("Automation may be detected.", e);
                }
            }

            // get portfolio elements
            var portfolioList = chrDr.FindElementsByCssSelector("#side_portfolio");
            foreach (var symbol in portfolioList)
            {
                // this puts on each line:
                // symbol as inner text in slug
                // company name as slug title
                // price as class="price-changes", class="price"
                // change and percentage as class="price-changes", class="change up" or "change down"; class="percentage up" or "percentage down"

                // example:
                // <li data-name="aapl" id="sp_slug_aapl" price="175" change="1.139" volume="23660018">

                // <div class="slug-info">
                // <a class="slug" sasource="side_portfolios" href="/symbol/AAPL" title="Apple Inc.">aapl</a>
                    // <div class="title-ticker">Apple Inc.</div>
                    // </div>

                // <div class="price-changes">
                // <div class="price">$175.00</div>
                // <div class="change up">1.97</div>
                // <div class="percentage up">(1.1%)</div>
                // </div>
                var text = symbol.Text.ToCharArray();
                Console.WriteLine(text);

            }
        }
    }
}
