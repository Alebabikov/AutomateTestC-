using Alpha3PageTests;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestFixture]
    public class C_ExportReportsTest : BaseTest
    {
        [Test]

        public void f_ExportDoctorPersonalDataProcessingDataTest()
        {
            LoginPage login = new LoginPage(driver);
            login.SendTextToLogin(TestSettings.AdminLoginAlpha);
            login.SendTextToPassword(TestSettings.AdminPasswordAlpha);
            login.ClickLoginBtn();
            WaitUntil.WaitElement(driver, By.XPath("//mat-icon[text()='menu']"));

            ToolbarPage toolbar = new ToolbarPage(driver);
            toolbar.ClickMenuBtn();
            WaitUntil.WaitElement(driver, By.XPath("//span[text()='Отчеты ']"));
            toolbar.ClickReportsBtn();
            WaitUntil.WaitElement(driver, By.XPath("//span[text()='Без группы ']"));

            SelectionReportsPage reports = new SelectionReportsPage(driver);
            reports.ClickReportWithoutAGroupBtn();
            WaitUntil.WaitElement(driver, By.XPath("//mat-card-title[text()='Согласия на обработку персональных данных - врачи']"));
            reports.ClickPersonalDataProcessingBtn();
            WaitUntil.WaitElement(driver, By.XPath("//div[text()='Центральное представительство ']"));

            ReportConstructorPage reportConstructor = new ReportConstructorPage(driver);
            reportConstructor.ClickCentralOfficeChevron();
            WaitUntil.WaitElement(driver, By.XPath("//div[text()='Восточная Сибирь ']"));

            IWebElement CheckBoxRegion = driver.FindElement(By.XPath("//div[text()='Восточная Сибирь ']"));
            Actions MouseClick = new Actions(driver);
            MouseClick.MoveToElement(CheckBoxRegion, -90, 1).Click().Build().Perform();

            reportConstructor.ClickToolExportBtn();
            WaitUntil.WaitElement(driver, By.XPath("//span[text()=' Экспорт ']"));
            reportConstructor.ClickExportReportBtn();
            WaitUntil.WaitElement(driver, By.XPath("//span[text()=' Экспорт ']"));

            driver.Navigate().GoToUrl("chrome://downloads/");
            WaitUntil.WaitSomeInterval();

            DownloadFilePage downloadFile = new DownloadFilePage(driver);
            string actualError = downloadFile.GetDownloadShowInFolder();
            string expectedError = "Показать в папке";
            Assert.That(() => actualError.Contains(expectedError), $"{expectedError} is not equal to {actualError}");

        }
    }
}

      

 

    

