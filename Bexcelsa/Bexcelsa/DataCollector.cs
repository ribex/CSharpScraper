using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Bexcelsa
{
    public class DataCollector
    {
        public DataCollector()
        {
            
        }

        public static void GetTable(ChromeDriver driver)
        {
            // get current date time and apply to symbols
            var timeNow = DateTime.Now;

            // get the table
            Thread.Sleep(3000);
            var table = driver.FindElementByXPath("//table[@data-test=\"contentTable\"]/tbody");

            // get all the rows
            var rows = table.FindElements(By.TagName("tr"));
            var rowCount = rows.Count;
            // Console.WriteLine("Row count: " + rowCount);
        }
    }
}