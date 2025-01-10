
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationProject
{
    public class TextBoxTest
    {
   
        IWebDriver driver;
                   
        [Test]
        public void Test1()
        {
            driver = new ChromeDriver ();
            driver.Navigate ().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();
            
            //IJavaScriptExecutor JS = (IJavaScriptExecutor)driver;
            //JS.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement ElementsButton = driver.FindElement (By.XPath("//h5[text()='Elements']"));
            ElementsButton.Click();

           IWebElement TextBoxButton = driver.FindElement(By.XPath("//*[text()='Text Box']"));
           TextBoxButton.Click ();

            IWebElement ElementFirstName = driver.FindElement(By.Id("userName"));
            ElementFirstName.SendKeys("Alexandrina Marcu");

            IWebElement ElementEmail = driver.FindElement(By.Id("userEmail"));
            ElementEmail.SendKeys("alexandrinaclaudia.marcu@endava.com");

            IWebElement ElementAddress = driver.FindElement(By.Id("currentAddress"));
            ElementAddress.SendKeys("Targu Mures str Fabricii de Zahar nr 18 jud Mures");

            IWebElement ElementAddressP = driver.FindElement(By.Id("permanentAddress"));
            ElementAddressP.SendKeys("Targu Mures str Viile Dealul Mic nr 37 jud Mures");

                   }

        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //    driver.Close();
        //}
    }
}