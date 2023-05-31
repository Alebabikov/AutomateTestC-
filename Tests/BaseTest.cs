using Alpha3PageTests;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageObjects;

namespace Tests
{

    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]

        public void Setup()
        {   
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AcceptInsecureCertificates = true;
            driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl(TestSettings.HostPrefix);
            driver.Manage().Window.Maximize();
        }



        [TearDown]
        protected void DoAfterEach()
        {
          driver.Quit();
        }

    }

}
