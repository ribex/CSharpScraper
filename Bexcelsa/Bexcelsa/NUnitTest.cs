using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace Bexcelsa
{
    public class NUnitTest
    {
        private ChromeDriver _driver;

        [SetUp]
        public void Initialize()
        {
            _driver = new ChromeDriver(@"C:\Users\Rebecca\source\repos\CSharpScraper\Bexcelsa");
        }

        [Test]
        public void OpenAppTest()
        {
            _driver.Url = "http://www.demoqa.com";
        }

        [TearDown]
        public void EndTest()
        {
            _driver.Close();
        }
    }
}
