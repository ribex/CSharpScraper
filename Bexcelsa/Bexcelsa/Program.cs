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
            // var portfolioName = "DaydreamsCanComeTrue";


            var chrDr = new ChromeDriver(@"C:\Users\Rebecca\source\repos\CSharpScraper\Bexcelsa");
            chrDr.Navigate().GoToUrl("https://finance.yahoo.com/");

            // log in to site
            // send email address
            chrDr.FindElement(By.Id("uh-signedin")).Click();
            chrDr.FindElement(By.Id("login-username")).Click();
            chrDr.Keyboard.SendKeys("ribexy@gmail.com");
            chrDr.FindElement(By.Id("login-signin")).Click();
            // send password
            chrDr.FindElement(By.Id("login-passwd")).Click();
            chrDr.Keyboard.SendKeys("ChromeDriver2018");
            chrDr.FindElement(By.Id("login-signin")).Click();

            // go to portfolio
            chrDr.Navigate().GoToUrl("https://finance.yahoo.com/portfolio/p_1/view/v1");

            // var table = chrDr.FindElementByXPath("//*[@id=\"main\"]/section/section[2]/div[2]/table");
            var table = chrDr.FindElementByXPath("//table[@data-test=\"contentTable\"]/tbody");
            var rows = table.FindElements(By.TagName("tr"));
            foreach (var row in rows)
            {
                Console.WriteLine(row.Text);
            }

            // get portfolio elements
            //            var tableBody = chrDr.FindElementByXPath("//*[@id=\"main\"]/section/section[2]/div[2]/table/tbody");
            //
            //            var bodyText = tableBody.ToString();
            //
            //            Console.WriteLine(bodyText);



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
