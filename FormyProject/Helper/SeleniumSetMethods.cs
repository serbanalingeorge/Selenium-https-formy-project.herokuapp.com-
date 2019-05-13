using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FormyProject.Helper
{
    public class SeleniumSetMethods
    {
        /// <summary>
        /// Enter Text
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        /// <param name="value"></param>
        /// <param name="selectorType"></param>
        public static void EnterText(IWebDriver driver, string element, string value, string selectorType)
        {
            if (selectorType == "Id")
                driver.FindElement(By.Id(element)).SendKeys(value);
            if (selectorType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
        }

        /// <summary>
        /// Click a button, checkbox, option, etc.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        /// <param name="selectorType"></param>
        public static void Click(IWebDriver driver, string element, string selectorType)
        {
            if (selectorType == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (selectorType == "Name")
                driver.FindElement(By.Name(element)).Click();
            if (selectorType == "Css")
                driver.FindElement(By.CssSelector(element)).Click();

        }

        /// <summary>
        /// Select a drop down control
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        /// <param name="value"></param>
        /// <param name="selectorType"></param>
        public static void SelectDropDown(IWebDriver driver, string element, string value, string selectorType)
        {
            if (selectorType == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (selectorType == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
