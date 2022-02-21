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
    public class SeleniumTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ChromeDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:1700/");
           

            //IWebElement utbKnapp = driver.FindElement(By.LinkText("REMOVE ALL EXISTING CUSTOMERS")); // Steg 1 vi pekar ut knappen med länktexten "Våra utbildningar" och ger den namnet utbKnapp
            //utbKnapp.Click(); // Steg 2 vi klickar på knappen som vi gjorde i tidigare steg
            //IWebElement remove = driver.FindElement(By.TagName("/html/body/form[5]"));

            // TEST 1
            IWebElement show = driver.FindElement(By.XPath("/html/body/ul/li/a"));
            show.Click();
            IWebElement returnMain = driver.FindElement(By.XPath("/html/body/form/input"));
            returnMain.Click();
            IWebElement remove = driver.FindElement(By.XPath("/html/body/form[5]/input"));
            remove.Click();
            IWebElement returnMain2 = driver.FindElement(By.XPath("/html/body/form/input"));
            returnMain2.Click();
            IWebElement show2 = driver.FindElement(By.XPath("/html/body/ul/li/a"));
            show2.Click();

            //TEST 2


            driver.Close();
            driver.Quit();

            // Olika typer av metoder

            /* 

            Exempel:
            (Hitta något med hjälp av LinkText)
            IWebElement utbKnapp = driver.FindElement(By.LinkText("Våra utbildningar")); // Steg 1 vi pekar ut knappen med länktexten "Våra utbildningar" och ger den namnet utbKnapp
            utbKnapp.Click(); // Steg 2 vi klickar på knappen som vi gjorde i tidigare steg
            ----OLIKA LOCATORS----
            (Du behöver byta namnet "ElementetsNamn")
            IWebElement ElementetsNamn = driver.FindElement(By.ClassName("Class-namnet skrivs här"));
            IWebElement ElementetsNamn = driver.FindElement(By.CssSelector("CSS-selectorn skrivs här"));
            IWebElement ElementetsNamn = driver.FindElement(By.Id("ID:t skrivs här"));
            IWebElement ElementetsNamn = driver.FindElement(By.LinkText("Länktexten skrivs här"));
            IWebElement ElementetsNamn = driver.FindElement(By.Name("Namnet skrivs här"));
            IWebElement ElementetsNamn = driver.FindElement(By.PartialLinkText("Del av länktexten skrivs här"));
            IWebElement ElementetsNamn = driver.FindElement(By.TagName("Taggnamnet skrivs här"));
            IWebElement ElementetsNamn = driver.FindElement(By.XPath(string xpath));
            ----OLIKA KOMMANDON----
            element.Click();
            ----OLIKA ASSERTS----
            EXEMPEL: 
            Assert.AreEqual("1,5 år", ElementetsNamn.Text); // frågar om det stämmer att texten säger 1,5 år
            */

        }
    }
}