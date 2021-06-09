using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumCSharpNetCore.pages
{
	public class HomePage : DriverHelper
	{

		private IWebElement lnkLogin => Driver.FindElement(By.LinkText("Login"));
		private IWebElement lnkLogoff => Driver.FindElement(By.LinkText("Log off"));

		public void clickLogin() => lnkLogin.Click();

		public bool isLogoffExist() => lnkLogoff.Displayed;


	}
}
