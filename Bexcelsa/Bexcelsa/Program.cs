using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Bexcelsa
{
    public class Credentials
    {
        public Credentials()
        {
            
        }

        // log in to site
        public static void Login(string username, string password, ChromeDriver driver)
        {
            // send email address
            driver.FindElement(By.Id("uh-signedin")).Click();
            driver.FindElement(By.Id("login-username")).Click();
            driver.Keyboard.SendKeys(username);
            driver.FindElement(By.Id("login-signin")).Click();
            // send password
            driver.FindElement(By.Id("login-passwd")).Click();
            driver.Keyboard.SendKeys(password);
            driver.FindElement(By.Id("login-signin")).Click();
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            var chrDr = new ChromeDriver(@"C:\Users\Rebecca\source\repos\CSharpScraper\Bexcelsa");
            chrDr.Navigate().GoToUrl("https://finance.yahoo.com/");

            Credentials.Login("ribexy@gmail.com", "ChromeDriver2018", chrDr);

            // go to portfolio
            chrDr.Navigate().GoToUrl("https://finance.yahoo.com/portfolio/p_1/view/v1");

            // get the table
            var table = chrDr.FindElementByXPath("//table[@data-test=\"contentTable\"]/tbody");

            // get all the rows
            var rows = table.FindElements(By.TagName("tr"));
            var rowCount = rows.Count;
            Console.WriteLine("Row count: " + rowCount);

            var symbolList = new List<Symbol>();

            foreach (var row in rows)
            {
                var rowTds = row.FindElements(By.TagName("td"));
                var rowTdsCount = rowTds.Count;
                symbolList.Add(new Symbol
                {
                    SymbolName = rowTds[0].Text,
                    LastPrice = rowTds[1].Text,
                    Change = rowTds[2].Text,
                    PercentChange = rowTds[3].Text,
                    Currency = rowTds[4].Text,
                    MarketTime = rowTds[5].Text,
                    Volume = rowTds[6].Text,
                    Shares = rowTds[7].Text,
                    AvgVol3Mon = rowTds[8].Text,
                    MarketCap = rowTds[12].Text
                });
//                    var a = td.FindElement(By.TagName("a"));
//                    symbol.SymbolName = a.Text;
//                    Console.WriteLine(symbol.SymbolName);
                    // var lastPrice = td.FindElement(By.TagName("span")).Text;
//                    symbol.LastPrice = Convert.ToDouble(lastPrice);
                    // Console.WriteLine(lastPrice);
                    // Console.WriteLine("added");
            }
            Symbol.SymbolPrint(symbolList);
        }
    }
}
