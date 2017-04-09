using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
namespace UI_testing
{
	public class NUnitTest
	{
		IWebDriver driver;

		[SetUp]
		public void Initialize()
		{
			driver = new ChromeDriver("/Users/valfitri/projects/UI_testing/UI_testing");
			driver.Navigate().GoToUrl("http://www.cisvpdx.com/");
		}

		[Test]
		public void VerifyNavbarExists()
		{
			Assert.IsTrue(driver.FindElement(By.ClassName("navbar-header")) != null);
		}

		[Test]
		public void VerifyNavbarLinksExists()
		{
			Assert.IsTrue(driver.FindElement(By.LinkText("About")) != null);
			Assert.IsTrue(driver.FindElement(By.LinkText("Gallery")) != null);
			Assert.IsTrue(driver.FindElement(By.LinkText("Programs")) != null);
			Assert.IsTrue(driver.FindElement(By.LinkText("Calendar")) != null);
			Assert.IsTrue(driver.FindElement(By.LinkText("Contact")) != null);
		}


		[TearDown]
		//Close the browser
		public void EndTest()
		{
			driver.Close();
		}
	}
}
