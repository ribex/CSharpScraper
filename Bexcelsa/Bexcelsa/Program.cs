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
            chrDr.Navigate().GoToUrl("https://finance.yahoo.com/");

//            chromeDriver.FindElementByXPath("//*[@id=\"hd-auto\"]").Click();
//            chromeDriver.Keyboard.SendKeys("Amazon");
//            chromeDriver.Keyboard.SendKeys(Keys.Enter);

            // log in to site
            // send email address
            chrDr.FindElementByXPath("//*[@id=\"uh-signedin\"]").Click();
            chrDr.FindElementByXPath("//*[@id=\"login-username\"]").Click();
            chrDr.Keyboard.SendKeys("ribexy@gmail.com");
            chrDr.FindElementByXPath("//*[@id=\"login-signin\"]").Click();
            // send password
            chrDr.FindElementByXPath("//*[@id=\"login-passwd\"]").Click();
            chrDr.Keyboard.SendKeys("ChromeDriver2018");
            chrDr.FindElementByXPath("//*[@id=\"login-signin\"]").Click();

            // go to portfolios
            chrDr.FindElementByXPath("//*[@id=\"Nav-0-DesktopNav\"]/div/div[3]/div/div[1]/ul/li[2]/a").Click();

//            var portfolioLink = chrDr.FindElementByXPath("//*[@id=\"nav_my_portfolio_tab\"]/a");
//            if (portfolioLink != null)
//            {
//                // navigate to Portfolio
//                try
//                {
//                    portfolioLink.Click();
//                }
//                catch (Exception e)
//                {
//                    throw new Exception("Automation may be detected.", e);
//                }
//            }

            // get portfolio elements
//            var portfolioList = chrDr.FindElementsByCssSelector("#side_portfolio");
//            foreach (var symbol in portfolioList)
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
//                var text = symbol.Text.ToCharArray();
//                Console.WriteLine(text);

            }
        }
    }
}
