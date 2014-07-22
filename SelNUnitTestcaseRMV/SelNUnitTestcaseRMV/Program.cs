
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SelNUnitTestcaseRMV
{
    class Program
    {
        static void Main(string[] args)

        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://www.rmv.de");
            //driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.Id("myname")).Clear();
            driver.FindElement(By.Id("myname")).SendKeys("krishnan.nagappan@gmail.com");
            driver.FindElement(By.Id("mypw")).Clear();
            driver.FindElement(By.Id("mypw")).SendKeys("Keith)98");
            //driver.FindElement(By.CssSelector("button.a11y-focus")).Click();
            driver.FindElement(By.XPath("//*[text()=\"Login\"]")).Click();
            driver.FindElement(By.Id("searchbar")).Click();
            driver.FindElement(By.Id("searchbar")).Clear();
            driver.FindElement(By.Id("searchbar")).SendKeys("hamburg");
            driver.FindElement(By.XPath("//*[text()=\"Suchen\"]")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();

            driver.Close();
        }
    }
}
