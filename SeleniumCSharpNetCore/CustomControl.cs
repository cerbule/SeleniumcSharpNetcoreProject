using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SeleniumCSharpNetCore
{
	public class CustomControl : DriverHelper
	{

		public static void ComboBox(string controlName, string value)
		{

			string comboControlName = "ContentPlaceHolder1_AllMealsCombo";

			IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
			comboControl.Clear();
			comboControl.SendKeys(value);

			Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();

		}


	}
}
