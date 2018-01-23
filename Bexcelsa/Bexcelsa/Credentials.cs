using System.Threading;
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
            Thread.Sleep((3000));
            driver.FindElement(By.Id("uh-signedin")).Click();
            Thread.Sleep((3000));
            driver.FindElement(By.Id("login-username")).Click();
            driver.Keyboard.SendKeys(username);
            driver.FindElement(By.Id("login-signin")).Click();
            // send password
            Thread.Sleep((3000));
            driver.FindElement(By.Id("login-passwd")).Click();
            driver.Keyboard.SendKeys(password);
            driver.FindElement(By.Id("login-signin")).Click();
        }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}