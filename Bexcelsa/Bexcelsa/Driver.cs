using OpenQA.Selenium.Chrome;

namespace Bexcelsa
{
    public class Driver : ChromeDriver
    {
        public ChromeDriver driver;

        public Driver(string fileLocation)
        {
            driver = new ChromeDriver(fileLocation);
        }

        public void Navigate(string address)
        {
            driver.Navigate().GoToUrl(address);
        }

    }
}