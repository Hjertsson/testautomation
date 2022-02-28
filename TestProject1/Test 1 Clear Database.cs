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

            Console.WriteLine("Före    " + test3.Count + ".");

            //IWebElement defaultRow1 = driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]"));
            //IWebElement defaultRow2 = driver.FindElement(By.XPath("/html/body/table/tbody/tr[3]"));
            //IWebElement defaultRow3 = driver.FindElement(By.XPath("/html/body/table/tbody/tr[4]"));
            //IWebElement defaultRow4 = driver.FindElement(By.XPath("/html/body/table/tbody/tr[5]"));
            //IWebElement defaultRow5 = driver.FindElement(By.XPath("/html/body/table/tbody/tr[6]"));


            IWebElement returnMain = driver.FindElement(By.XPath("/html/body/form/input"));
            returnMain.Click();
            IWebElement remove = driver.FindElement(By.XPath("/html/body/form[5]/input"));
            remove.Click();
            IWebElement returnMain2 = driver.FindElement(By.XPath("/html/body/form/input"));
            returnMain2.Click();
            IWebElement show2 = driver.FindElement(By.XPath("/html/body/ul/li/a"));
            show2.Click();

            //IWebElement test = driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]"));

            //IWebElement iguess = driver.FindElements(By.XPath("/html/body/table/tbody"));

            //List<IWebElement> listOfElements = driver.FindElements(By.XPath("/html/body/table/tbody"));

            IReadOnlyCollection<IWebElement> test2 = driver.FindElements(By.XPath("/html/body/table/tbody/tr"));

            

            //Console.WriteLine("Före    " + test3.Count + ".");

            Console.WriteLine("Efter   " + test2.Count + ".");

            Assert.AreEqual(test2.Count, 1);

            //IWebElement table = driver.FindElement(By.XPath("/html/body/table/tbody"));

            //Assert.IsNull(driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]")));

            //Assert.Fail(driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]")).Text);

            //Assert.IsNull(driver.FindElement(By.XPath("/html/body/table/tbody/tr[2]")));





            driver.Close();
            driver.Quit();

        }
    }
}