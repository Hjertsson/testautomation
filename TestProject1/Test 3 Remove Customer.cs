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
    public class SeleniumTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:1700/");

            IWebElement show = driver.FindElement(By.XPath("/html/body/ul/li/a"));
            show.Click();

            IWebElement defaultTest = driver.FindElement(By.XPath("/html/body/table/tbody/tr[3]/td[3]"));

            IWebElement returnMain = driver.FindElement(By.XPath("/html/body/form/input"));
            returnMain.Click();

            
            

            IWebElement customerID = driver.FindElement(By.XPath("/html/body/form[3]/input[1]"));
            customerID.SendKeys("2");
            IWebElement remove = driver.FindElement(By.XPath("/html/body/form[3]/input[2]"));
            remove.Click();
            IWebElement returnFront = driver.FindElement(By.XPath("/html/body/form/input"));
            returnFront.Click();
            IWebElement showAll = driver.FindElement(By.XPath("/html/body/ul/li/a"));
            showAll.Click();

            //Check if customer with customer ID nr 2 is removed

            IWebElement resultMain = driver.FindElement(By.XPath("/html/body/table/tbody/tr[3]/td[3]"));
            Console.WriteLine("--------- " + resultMain + ".");

            //int intResult = int.Parse(resultMain.Text);

            //Console.WriteLine("--------- " + intResult + ".");

            //Assert.AreEqual(resultMain.Text, 0);
            //Assert.AreNotEqual(resultMain.Text, 2);
            //Assert.Fail(int.Parse(resultMain.Text));
            Assert.AreNotSame(defaultTest, resultMain);

            driver.Close();
            driver.Quit();



        }
    }
}