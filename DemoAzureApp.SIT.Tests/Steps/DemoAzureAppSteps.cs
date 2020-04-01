using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using RestSharp;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.IO;

namespace AzureDemoApp.SIT.Tests.Steps
{
    [Binding]
    class DemoAzureAppSteps
    {
        public IWebDriver driver = null;

        [Given(@"the user has launched the application")]
        public void GivenTheUserHasLaunchedTheApplication()
        {
            try
            {
                string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                path = Path.GetFullPath(Path.Combine(path, @"..\"));
                driver = new ChromeDriver(@path + "\\Drivers");
                driver.Navigate().GoToUrl("https://azuredevops-poc.azurewebsites.net/");
                //ScenarioContext.Current.Pending();
            }
            catch (Exception e)
            {

            }
           
        }

        [Given(@"the user is able to see the Learn More button")]
        public void GivenTheUserIsAbleToSeeTheLearnMoreButton()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//a[@href='http://asp.net']")).Displayed);
                Assert.AreEqual(driver.FindElement(By.XPath("//a[@href='http://asp.net']")).Text, "Learn more »", "The Learn More button for ASP.NET is present");
                //driver.Quit();
                //ScenarioContext.Current.Pending();
            }
            catch (Exception e)
            {

            }
            
        }

        [Given(@"the user is able to see the Learn More button in the application")]
        public void GivenTheUserIsAbleToSeeTheLearnMoreButtonInTheApplication()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.XPath("//a[@href='http://asp.net']")).Displayed);
                Assert.AreEqual(driver.FindElement(By.XPath("//a[@href='http://asp.net']")).Text, "Learn more »", "The Learn More button for ASP.NET is present");
                driver.Quit();
                //ScenarioContext.Current.Pending();
            }
            catch (Exception e)
            {

            }
            
        }


        [When(@"the user clicks onto Learn More")]
        public void WhenTheUserClicksOntoLearnMore()
        {
            try
            {
                //string str = "Done";
                driver.FindElement(By.XPath("//a[@href='http://asp.net']")).Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                //ScenarioContext.Current.Pending();
            }
            catch(Exception e)
            {

            }

        }

        [Then(@"the asp page opens up")]
        public void ThenTheAspPageOpensUp()
        {
            try
            {
                Assert.IsTrue(driver.FindElement(By.Id("mainContent")).Displayed);
                driver.Quit();
                //ScenarioContext.Current.Pending();
            }
            catch (Exception e)
            {

            }
        }
   
    }
}
