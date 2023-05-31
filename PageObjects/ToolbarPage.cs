using Docker.DotNet.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class ToolbarPage : BasePage
    {
        public ToolbarPage(IWebDriver driver):base(driver)
        {

        }

        private IWebElement btnMenu => driver.FindElement(By.XPath("//mat-icon[text()='menu']"));
        private IWebElement sidenav => driver.FindElement(By.XPath("//span[text()='Администрирование ']"));
        private IWebElement btnReports => driver.FindElement(By.XPath("//span[text()='Отчеты ']"));





        public void ClickMenuBtn() => btnMenu.Click();
        public string GetSidenav => sidenav.Text;
        public void ClickReportsBtn() => btnReports.Click();


    }
}
