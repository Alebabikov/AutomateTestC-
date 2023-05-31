using Alpha3PageTests;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver):base(driver)
        {
        
        }
        private IWebElement txtLogin => driver.FindElement(By.XPath("//input[@name='userName']"));
        private IWebElement txtPassword => driver.FindElement(By.XPath("//input[@type='password']"));
        private IWebElement btnLogin => driver.FindElement(By.XPath("//span[text()='Log in']"));
        private IWebElement errorNotification => driver.FindElement(By.XPath("//div[@aria-label='Неверный логин или пароль']"));
        private IWebElement userLogin => driver.FindElement(By.XPath("//div[text()=' Никитин (Тестовый) Павел Сергеевич ']"));
        private IWebElement btnquitLogin => driver.FindElement(By.XPath("//button[@mattooltip='Выход']"));
        private IWebElement txtIn => driver.FindElement(By.XPath("//mat-card-title[text()='Вход']"));
        


        public void SendTextToLogin(string text) => txtLogin.SendKeys(text);
        public void SendTextToPassword(string text) => txtPassword.SendKeys(text);
        public void ClickLoginBtn() => btnLogin.Click();
        public string GetErrorNotification => errorNotification.Text;
        public string GetUserLogin => userLogin.Text;
        public void ClickQuitLoginBtn() => btnquitLogin.Click();
        public string GetInTxt => txtIn.Text;

        


    }
}
