using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject.Sesiune3
{
    public class PracticeForms
    {
        IWebDriver webdriver;

        [Test]

        public void TestMethod()
        {
            webdriver = new ChromeDriver();
            webdriver.Navigate().GoToUrl("https://demoqa.com/");
            webdriver.Manage().Window.Maximize();

            IWebElement FormsButton = webdriver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][2]"));
            FormsButton.Click();

            IWebElement PracticeFormElement = webdriver.FindElement(By.XPath("//*[text()='Practice Form']"));
            PracticeFormElement.Click();

            IWebElement genderMale = webdriver.FindElement(By.XPath("//label[@for='gender-radio-1']"));
            IWebElement genderFemale = webdriver.FindElement(By.XPath("//label[@for='gender-radio-2']"));
            IWebElement genderOther = webdriver.FindElement(By.XPath("//label[@for='gender-radio-3']"));

            string gender = "Male";
            //if (gender.Equals("Male"))
            //{
            //    genderMale.Click();
            //}
            //else if (gender.Equals("Female"))
            //{

            //}   

            switch (gender)
            {
                case "Male":
                    genderMale.Click();
                    break;
                case "Female":
                    genderFemale.Click();
                    break;
                case "Other":
                    genderOther.Click();
                    break;
            }


            IWebElement ElementSubject = webdriver.FindElement(By.Id("subjectsInput"));
            ElementSubject.SendKeys("English");
            ElementSubject.SendKeys(Keys.Enter);
            ElementSubject.SendKeys("C");
            ElementSubject.SendKeys(Keys.ArrowDown);
            ElementSubject.SendKeys(Keys.ArrowDown);
            ElementSubject.SendKeys(Keys.ArrowDown);
            ElementSubject.SendKeys(Keys.Enter);
        }
    }
}
