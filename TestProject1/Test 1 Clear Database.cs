using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;



namespace SeleniumTestProject
{
    [TestClass]
    public class SeleniumTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:1700/");
           
           
            IWebElement show = driver.FindElement(By.XPath("/html/body/ul/li/a"));
            show.Click();

            IReadOnlyCollection<IWebElement> test3 = driver.FindElements(By.XPath("/html/body/table/tbody/tr"));

            Console.WriteLine("F?re    " + test3.Count + ".");

            IWebElement returnMain = driver.FindElement(By.XPath("/html/body/form/input"));
            returnMain.Click();
            IWebElement remove = driver.FindElement(By.XPath("/html/body/form[5]/input"));
            remove.Click();
            IWebElement returnMain2 = driver.FindElement(By.XPath("/html/body/form/input"));
            returnMain2.Click();
            IWebElement show2 = driver.FindElement(By.XPath("/html/body/ul/li/a"));
            show2.Click();

            IReadOnlyCollection<IWebElement> test2 = driver.FindElements(By.XPath("/html/body/table/tbody/tr"));

            Assert.AreEqual(test2.Count, 1);

            driver.Close();
            driver.Quit();

        }
    }
}