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
}