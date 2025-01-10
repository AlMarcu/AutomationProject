using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AutomationProject.Sesiune3
{
    public class SelectMenu
    {
        IWebDriver driver;

        [Test]
        public void Selectmenu()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IWebElement widgets = driver.FindElement(By.XPath("//h5[text()='Widgets']"));
            widgets.Click();

            Actions actions = new Actions(driver);
            actions.ScrollByAmount(0, 2000).Perform();

            IWebElement selectMenu = driver.FindElement(By.XPath("//*[text()='Select Menu']"));
            selectMenu.Click();

        }
    }
}
