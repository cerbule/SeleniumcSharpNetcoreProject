using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumCSharpNetCore.pages
{
	public class LoginPage : DriverHelper
	{
		private IWebElement userNameField => Driver.FindElement(By.Id("UserName"));
		private IWebElement passwordField => Driver.FindElement(By.Id("Password"));
		private IWebElement loginButton => Driver.FindElement(By.XPath("//input[@class='btn btn-default']"));


		public void enterUserNameAndPassword(string userName, string password)
		{
			userNameField.SendKeys(userName);
			passwordField.SendKeys(password);
		}

		public void clickOnLoginButton()
		{
			loginButton.Click();
		}

	}
}
