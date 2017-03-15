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
		}

		[Test]
		//Open the application
		public void OpenAppTest()
		{
			driver.Navigate().GoToUrl("http://www.cisvpdx.com/");
		}

		[TearDown]
		//Close the browser
		public void EndTest()
		{
			driver.Close();
		}
	}
}
