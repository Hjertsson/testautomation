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
    public class SeleniumTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:1700/");

            IWebElement firstName = driver.FindElement(By.XPath("/html/body/form[1]/input[1]"));
            firstName.SendKeys("Gustav");
            IWebElement lastName = driver.FindElement(By.XPath("/html/body/form[1]/input[2]"));
            lastName.SendKeys("Hjertsson");
            IWebElement customerID = driver.FindElement(By.XPath("/html/body/form[1]/input[3]"));
            customerID.SendKeys("6");
            IWebElement phoneNr = driver.FindElement(By.XPath("/html/body/form[1]/input[4]"));
            phoneNr.SendKeys("123456789");
            IWebElement commit = driver.FindElement(By.XPath("/html/body/form[1]/input[5]"));
            commit.Click();
            IWebElement returnMain3 = driver.FindElement(By.XPath("/html/body/form/input"));
            returnMain3.Click();
            IWebElement showAll = driver.FindElement(By.XPath("/html/body/ul/li/a"));
            showAll.Click();
            //Assert.AreEqual(By.XPath("/html/body/table/tbody/tr[7]/td[3]", 6);
            IWebElement resultMain = driver.FindElement(By.XPath("/html/body/table/tbody/tr[7]/td[3]"));
            string text = resultMain.Text;

            Console.WriteLine("--------- " + text + ".");
            Assert.AreEqual(resultMain, 6);


            //Assert.That(popUpAdress.Text, Is.EqualTo("HELLO@INCEPTIVE.SE"));


            //IWebElement resultMain = driver.FindElement(By.XPath("/html/body/table/tbody/tr[7]"));
            //Assert.IsNotNull(resultMain);
            //Assert.IsNull(resultMain);



            driver.Close();
            driver.Quit();



        }
    }
}