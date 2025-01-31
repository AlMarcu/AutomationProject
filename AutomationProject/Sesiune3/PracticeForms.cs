using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

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


            IWebElement dateofBirth = webdriver.FindElement(By.Id("dateOfBirthInput"));
            dateofBirth.Click();

            IWebElement datepickerMonth = webdriver.FindElement(By.XPath("//select[@class='react-datepicker__month-select']"));
            SelectElement monthDrop = new SelectElement(datepickerMonth);
            monthDrop.SelectByValue("2");

            IWebElement datepickerYear = webdriver.FindElement(By.XPath("//select[@class='react-datepicker__year-select']"));
            SelectElement yearDrop = new SelectElement(datepickerYear);
            yearDrop.SelectByValue("1990");

            IWebElement datepickerDate = webdriver.FindElement(By.XPath("//*[@class='react-datepicker__day react-datepicker__day--006' and not (contains(@class,'--outsidemonth'))]"));
            SelectElement dateDrop = new SelectElement(datepickerDate);
            dateDrop.SelectByValue("6");


            //*[@class='react-datepicker__day react-datepicker__day--011' and not (contains(@class,, '--outsidemonth'))]


            //IWebElement dateMYpicker = webdriver.FindElement(By.XPath("//select[aria-label='Choose Tuesday, December 17th, 2024']"));
            //dateMYpicker.Click();

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
