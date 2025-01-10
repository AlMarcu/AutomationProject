using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace AutomationProject.Sesiune3
{
    public class AutoComplete
    {
        IWebDriver driver;

        [Test]
        public void Autocomplete()

        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IWebElement widgets = driver.FindElement(By.XPath("//h5[text()='Widgets']"));
            widgets.Click();

            //Actions actions = new Actions(driver);
            //actions.ScrollByAmount(0, 2000).Perform();

            IWebElement selectMenu = driver.FindElement(By.XPath("//*[text()='Auto Complete']"));
            selectMenu.Click();

                  

            IWebElement elementColor = driver.FindElement(By.Id("autoCompleteMultipleInput"));
            elementColor.SendKeys("Black");
            elementColor.SendKeys(Keys.Enter);
            elementColor.SendKeys("Y");
            elementColor.SendKeys(Keys.ArrowDown);
            elementColor.SendKeys(Keys.ArrowDown);
            elementColor.SendKeys(Keys.ArrowDown);
            elementColor.SendKeys(Keys.Enter);

            IWebElement elementColorS = driver.FindElement(By.Id("autoCompleteSingleInput"));
            elementColorS.SendKeys("Blue");
            elementColorS.SendKeys(Keys.Enter);
            
               


        }
    }
}
