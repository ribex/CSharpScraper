using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Bexcelsa
{
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
                symbolList.Add(new Symbol
                {
                    SymbolName = rowTds[0].Text,
                    LastPrice = Convert.ToDouble(rowTds[1].Text),
                    Change = Convert.ToDouble(rowTds[2].Text),
                    PercentChange = rowTds[3].Text,
                    Currency = rowTds[4].Text,
                    MarketTime = rowTds[5].Text,
                    Volume = rowTds[6].Text,
                    Shares = Convert.ToDouble(rowTds[7].Text),
                    AvgVol3Mon = rowTds[8].Text,
                    MarketCap = rowTds[12].Text
                });

                var symbol = new Symbol
                {
                    SymbolName = rowTds[0].Text,
                    LastPrice = Convert.ToDouble(rowTds[1].Text),
                    Change = Convert.ToDouble(rowTds[2].Text),
                    PercentChange = rowTds[3].Text,
                    Currency = rowTds[4].Text,
                    MarketTime = rowTds[5].Text,
                    Volume = rowTds[6].Text,
                    Shares = Convert.ToDouble(rowTds[7].Text),
                    AvgVol3Mon = rowTds[8].Text,
                    MarketCap = rowTds[12].Text
                };

                using (var db = new Symbol.SymbolContext())
                {
                    db.Symbols.Add(symbol);
                    db.SaveChanges();

                }
                // Symbol.SymbolPrint(symbolList);

}
        }
    }
}
