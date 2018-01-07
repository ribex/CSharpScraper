using System;
using OpenQA.Selenium.Chrome;

namespace Bexcelsa
{
    class Program
    {
        static void Main(string[] args)
        {
            var chromeDriver = new ChromeDriver(@"C:\Users\Rebecca\source\repos\CSharpScraper\Bexcelsa");
            chromeDriver.Navigate().GoToUrl("https://seekingalpha.com/");
        }
    }
}
