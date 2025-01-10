using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace AutomationProject1
{
    public class test2
    {
        IWebDriver driver;

        [Test]
        public void TestMethod()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IWebElement ElementButton = driver.FindElement(By.XPath("//h5[text()='Elements']"));
            ElementButton.Click();

            //IWebElement ElementWebTables = driver.FindElement(By.XPath("//div[@class='Web Tables']"));
            //ElementWebTables.Click();
            IWebElement WebTablesButton1 = driver.FindElement(By.XPath("//span[text()='Web Tables']"));
            WebTablesButton1.Click();
            

            IWebElement ElementAdd = driver.FindElement(By.Id("addNewRecordButton"));
            ElementAdd.Click();

            IWebElement popupFirstName = driver.FindElement(By.Id("firstName"));
            IWebElement popupLastName = driver.FindElement(By.Id("lastName"));
            IWebElement popupUserEmail = driver.FindElement(By.Id("userEmail"));
            IWebElement popupAge = driver.FindElement(By.Id("age"));
            IWebElement popupSalary = driver.FindElement(By.Id("salary"));
            IWebElement popupDepartment = driver.FindElement(By.Id("department"));

            popupFirstName.SendKeys("Alexandrina");
            popupLastName.SendKeys("Marcu");
            popupUserEmail.SendKeys("sanda@yahoo.co.uk");
            popupAge.SendKeys("47");
            popupSalary.SendKeys("25555");
            popupDepartment.SendKeys("IT");

            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            jse.ExecuteScript("arguments[0].click();", submitButton);

            //submitButton.Submit();

            IWebElement newRowWebTable = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]"));
            Console.WriteLine(newRowWebTable.Text);

            //Assert.True(newRowTable.Text.Contains("Alexandrina"));
            //Assert.True(newRowTable.Text.Contains("Marcu"));
            //Assert.True(newRowTable.Text.Contains("sanda@yahoo.co.uk"));
            //Assert.True(newRowTable.Text.Contains("47"));
            //Assert.True(newRowTable.Text.Contains("25555"));
            //Assert.True(newRowTable.Text.Contains("IT"));

            IWebElement firstName = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][1]"));
            IWebElement lastName = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][2]"));
            IWebElement age = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][3]"));
            IWebElement email = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][4]"));
            IWebElement salary = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][5]"));
            IWebElement department = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][6]"));

            Assert.That(firstName.Text.Equals("Alexandrina"));
            Assert.That(lastName.Text.Equals("Marcu"));
            Assert.That(age.Text.Equals("47"));
            Assert.That(email.Text.Equals("sanda@yahoo.co.uk"));
            Assert.That(salary.Text.Equals("25555"));
            Assert.That(department.Text.Equals("IT"));



            //[TearDown]
            //public void TearDown()
            //{
            //    driver.Quit();
            //    driver.Close();
            //}
        }
    }

}
