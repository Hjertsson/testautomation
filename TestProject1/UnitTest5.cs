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
    public class SeleniumTest5
    {
        [TestMethod]
        public void TestMethod5()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:1700/");

            string[] customerIDArray = new string[] {"1", "2", "3", "4", "5", "6", "7", "8",
                "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25"};

           

            IWebElement removeAll = driver.FindElement(By.XPath("/html/body/form[5]/input"));
            removeAll.Click();
            IWebElement returnFront = driver.FindElement(By.XPath("/html/body/form/input"));
            returnFront.Click();

            for (int i = 0; i < 25; i++)
            {
                IWebElement firstName = driver.FindElement(By.XPath("/html/body/form[1]/input[1]"));
                firstName.SendKeys("Gustav");
                IWebElement lastName = driver.FindElement(By.XPath("/html/body/form[1]/input[2]"));
                lastName.SendKeys("Hjertsson");
                IWebElement customerID = driver.FindElement(By.XPath("/html/body/form[1]/input[3]"));
                customerID.SendKeys(customerIDArray[i]);
                IWebElement phoneNr = driver.FindElement(By.XPath("/html/body/form[1]/input[4]"));
                phoneNr.SendKeys("123456789");
                IWebElement commit = driver.FindElement(By.XPath("/html/body/form[1]/input[5]"));
                commit.Click();
                IWebElement returnFront2 = driver.FindElement(By.XPath("/html/body/form/input"));
                returnFront2.Click();

            };


            //check that 25 customer has been added



            driver.Close();
            driver.Quit();



        }
    }
}