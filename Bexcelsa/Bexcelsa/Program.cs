using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Bexcelsa
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var portfolio = new Portfolio {Name = "DaydreamsCanComeTrue"};

            var chrDr = new Driver(@"C:\Users\Rebecca\source\repos\CSharpScraper\Bexcelsa");

            // go to Yahoo Finance
            chrDr.Navigate("https://finance.yahoo.com/");

            Credentials.Login("ribexy@gmail.com", "ChromeDriver2018", chrDr);

            // go to portfolio
            chrDr.Navigate("https://finance.yahoo.com/portfolio/p_1/view/v1");

            DataCollector.GetTable(chrDr);

            var symbolList = new List<Symbol>();

            for (var i = 1; i <= rowCount; i++)
            {
                var rowIndex = $"//tr[{i}]/";

                var symbol = new Symbol
                {
                    SymbolName = table.FindElement(By.XPath(rowIndex + "td[1]/span/a")).Text,
                    LastPrice = Convert.ToDouble(table.FindElement(By.XPath(rowIndex + "td[2]/span")).Text),
                    Change = Convert.ToDouble(table.FindElement(By.XPath(rowIndex + "td[3]/span")).Text),
                    PercentChange = table.FindElement(By.XPath(rowIndex + "td[4]/span")).Text,
                    Currency = table.FindElement(By.XPath(rowIndex + "td[5]")).Text,
                    MarketTime = timeNow,
                    //MarketTime = table.FindElement(By.XPath(rowIndex + "td[6]/span")).Text,
                    Volume = table.FindElement(By.XPath(rowIndex + "td[7]/span")).Text,
                    Shares = Convert.ToDouble(table.FindElement(By.XPath(rowIndex + "td[8]")).Text),
                    AvgVol3Mon = table.FindElement(By.XPath(rowIndex + "td[9]")).Text,
                    MarketCap = table.FindElement(By.XPath(rowIndex + "td[13]/span")).Text
                };

                symbolList.Add(symbol);
            }

            //using (var db = new PortfolioContext())
            //{
            //    db.Portfolios.Add(portfolio);
            //    db.SaveChanges();

            //    var query = from b in db.Portfolios
            //        orderby b.Name
            //        select b;

            //    Console.WriteLine("All portfolios in the database: ");
            //    foreach (var item in query)
            //    {
            //        Console.WriteLine(item.Name);
            //    }

            //}
            Symbol.SymbolPrint(symbolList);

            // work on learning entity framework
        }
    }
}
