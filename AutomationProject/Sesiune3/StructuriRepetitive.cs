using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutomationProject.Sesiune3
{
    public class StructuriRepetitive
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

            List<IWebElement> ListElem = driver.FindElements(By.XPath("//div[@class='vertical-list-container mt-4']/div")).ToList();
            //Console.WriteLine(ListElem[0].Text);
            //Console.WriteLine(ListElem[1].Text);
            //Console.WriteLine(ListElem[2].Text);

            for (int i = 0; i < ListElem.Count; i++) Console.WriteLine(ListElem[i].Text);

        }

        [Test]
        public void StructuriRepetitiveMet2()

        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IWebElement formElement = driver.FindElement(By.XPath("//h5[text()='Forms']"));
            formElement.Click();

            IWebElement practiceFormElement = driver.FindElement(By.XPath("//span[text()='Practice Form']"));
            practiceFormElement.Click();
            Actions actions = new Actions(driver);
            actions.ScrollByAmount(0, 2000).Perform();

            IWebElement sportElement = driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-1']"));
            IWebElement readingElement = driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']"));
            IWebElement musicElement = driver.FindElement(By.XPath("//label[@for='hobbies-checkbox-3']"));

            List<IWebElement> hobbiesList = new List<IWebElement>();
            hobbiesList.Add(sportElement);
            hobbiesList.Add(readingElement);
            hobbiesList.Add(musicElement);




            string[] array = ["Sports", "Music"];
            foreach (IWebElement hobby in hobbiesList)
            {
                foreach (string item in array)
                {
                    if (hobby.Text.Equals(item))
                    {
                        hobby.Click();
                    }

                }

            }

        }

        [Test]
        public void StructuriRepetitiveMet3()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IWebElement formElement = driver.FindElement(By.XPath("//h5[text()='Forms']"));
            formElement.Click();

            IWebElement practiceFormElement = driver.FindElement(By.XPath("//span[text()='Practice Form']"));
            practiceFormElement.Click();
            Actions actions = new Actions(driver);
            actions.ScrollByAmount(0, 2000).Perform();

            IWebElement subjectElement = driver.FindElement(By.Id("subjectsInput"));
            subjectElement.SendKeys("Math");
            subjectElement.SendKeys(Keys.Enter);

            subjectElement.SendKeys("Chemistry");
            subjectElement.SendKeys(Keys.Enter);

            subjectElement.SendKeys("English");
            subjectElement.SendKeys(Keys.Enter);

            List<IWebElement> removeSubjects = driver.FindElements(By.XPath("//div[@class='css-xb97g8 subjects-auto-complete__multi-value__remove']")).ToList();
            bool subjectFlag = true;

            while (subjectFlag)
            {
                foreach (IWebElement element in removeSubjects)
                {
                    element.Click();
                    Thread.Sleep(1000);
                }
                subjectFlag = false;
            }


        }

     }
}
