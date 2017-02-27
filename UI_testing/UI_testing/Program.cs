using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace UI_testing
{
	public class Program
	{
		static void Main(string[] args)
		{
			IWebDriver driver = new ChromeDriver("/Users/valfitri/projects/UI_testing/UI_testing");
			driver.Navigate().GoToUrl("http://www.cisvpdx.com/");
			//driver.Url = "www.cisvpdx.com";
			//driver.Navigate().GoToUrl("http://www.google.com/");

		}
	}
}
