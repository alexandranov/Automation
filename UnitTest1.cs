using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTut.by
{
    [TestFixture]
    public class Tests
    {
        private string baseURL;
        private IWebDriver driver;

        
        [SetUp]

        public void Setup()
        {
            baseURL = "https://www.tut.by/";
        driver = new ChromeDriver(@"/Users/aleksandra/Documents/chromedrivers/");
       
            driver.Navigate().GoToUrl(baseURL);


        }

        [Test]
        public void Test1()
        {
            driver.Url = baseURL;
            


            string logo = "Белорусский портал";
            //string header_logo = driver.FindElement(By.XPath("//a[@class= 'header-logo']")).GetAttribute("title");
            string header_logo = driver.FindElement(By.ClassName("header_logo")).GetAttribute("title");
            
            //Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@id='search_from_str']")).SendKeys(header_logo);
            
             driver.FindElement(By.XPath("//input[@name= 'search']")).Click();
            
            if (header_logo.Contains(logo))
            {
                Assert.Pass();
            }

            
        }
    }
}
