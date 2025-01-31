using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;

namespace AutomationProject.Sesiune3
{
    public class TemaSelectable
    {
         
        IWebDriver driver;

        [Test]
        public void StructuriRepetitiveMet()

        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IWebElement Interaction = driver.FindElement(By.XPath("//h5[text()='Interactions']"));
            Interaction.Click();

            List<IWebElement> ListInteraction = driver.FindElements(By.XPath("//div[@class='element-list collapse show']/ul[@class='menu-list']/li[@class='btn btn-light ']")).ToList();
            ListInteraction[0].Click();

            IWebElement Selectable = driver.FindElement(By.XPath("//span[text()='Selectable']"));
            Selectable.Click();

            IWebElement gridSelectable = driver.FindElement(By.Id("demo-tab-grid"));
            gridSelectable.Click();

            IReadOnlyCollection<IWebElement> cells = driver.FindElements(By.XPath("//li[@class='list-group-item list-group-item-action']"));

            List<string> cellList = new List<string> { "One", "Three","Five", "Seven", "Nine" };

            foreach (IWebElement cell in cells)
            {
                string cellText = cell.Text;
                if (cellList.Contains(cellText)) cell.Click();
             }



                //IWebElement oneElement = driver.FindElement(By.XPath("//li[text()='One']"));
                ////oneElement.Click();
                //IWebElement twoElement = driver.FindElement(By.XPath("//li[text()='Two']"));
                //IWebElement threeElement = driver.FindElement(By.XPath("//li[text()='Three']"));
                ////threeElement.Click();

                //Actions actions = new Actions(driver);
                //actions.ScrollByAmount(0, 2000).Perform();

                //IWebElement fourElement = driver.FindElement(By.XPath("//li[text()='Four']"));
                //IWebElement fiveElement = driver.FindElement(By.XPath("//li[text()='Five']"));
                ////fiveElement.Click();
                //IWebElement sixElement = driver.FindElement(By.XPath("//li[text()='Six']"));
                //IWebElement sevenElement = driver.FindElement(By.XPath("//li[text()='Seven']"));
                ////sevenElement.Click();
                //IWebElement eightElement = driver.FindElement(By.XPath("//li[text()='Eight']"));
                //IWebElement nineElement = driver.FindElement(By.XPath("//li[text()='Nine']"));
                ////nineElement.Click();
                //IWebElement tenElement = driver.FindElement(By.XPath("//li[text()='Ten']"));


            }
    }
}
