using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpNetCore
{
	public class Tests : DriverHelper
	{

		[SetUp]
		public void Setup()
		{
			System.Console.WriteLine("Setup");
			ChromeOptions chromeOptions = new ChromeOptions();
			//chromeOptions.BinaryLocation = "E:\\ProjectsAutomation\\driver\\chromedriver.exe";
			Driver = new ChromeDriver("E:\\ProjectsAutomation\\driver");
		}

		[TearDown]
		public void tearDown()
		{
			Driver.Close();
			Driver.Quit();
		}

		[Test]
		public void Test1()
		{
			System.Console.WriteLine("Test1");

			Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

			Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
			Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();

			CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");


			Assert.Pass();
		}
	}
}