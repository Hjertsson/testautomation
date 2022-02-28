using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Threading;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;


namespace SeleniumTestProject
{
    [TestClass]
    public class SeleniumTest4
    {
        [TestMethod]
        public void TestMethod4()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:1700/");

            IWebElement show = driver.FindElement(By.XPath("/html/body/ul/li/a"));
            show.Click();

            IWebElement defaultTest = driver.FindElement(By.XPath("/html/body/table/tbody/tr[6]/td[1]"));

            IWebElement returnMain = driver.FindElement(By.XPath("/html/body/form/input"));
            returnMain.Click();


            IWebElement firstName = driver.FindElement(By.XPath("/html/body/form[4]/input[1]"));
            firstName.SendKeys("Edited");
            IWebElement lastName = driver.FindElement(By.XPath("/html/body/form[4]/input[2]"));
            lastName.SendKeys("Edited");
            IWebElement customerID = driver.FindElement(By.XPath("/html/body/form[4]/input[3]"));
            customerID.SendKeys("5");
            IWebElement phoneNr = driver.FindElement(By.XPath("/html/body/form[4]/input[4]"));
            phoneNr.SendKeys("123456789");
            IWebElement save = driver.FindElement(By.XPath("/html/body/form[4]/input[5]"));
            save.Click();
            IWebElement returnFront = driver.FindElement(By.XPath("/html/body/form/input"));
            returnFront.Click();
            IWebElement showAll = driver.FindElement(By.XPath("/html/body/ul/li/a"));
            showAll.Click();

            IWebElement nameCheck = driver.FindElement(By.XPath("/html/body/table/tbody/tr[7]/td[1]"));          

            Assert.AreNotEqual(nameCheck, defaultTest);

            


            driver.Close();
            driver.Quit();



        }
    }
}