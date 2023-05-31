using Alpha3PageTests;
using OpenQA.Selenium;
using PageObjects;

namespace Tests
{
    [TestFixture]
    public class A_LoginTest : BaseTest
    {
        
        [Test]
        public void a_PositiveLogin()
        {
            LoginPage login = new LoginPage(driver);
            login.SendTextToLogin(TestSettings.AdminLoginAlpha);
            login.SendTextToPassword(TestSettings.AdminPasswordAlpha);
            login.ClickLoginBtn();
            WaitUntil.WaitElement(driver, By.XPath("//div[text()=' Никитин (Тестовый) Павел Сергеевич ']"));
            string actualError = login.GetUserLogin;
            string expectedError = "Никитин (Тестовый) Павел Сергеевич";
            Assert.AreEqual(expectedError, actualError, $"{expectedError} is not equal to {actualError}");
      
        }
        [Test]
        public void b_quitLogin()
        {
            LoginPage login = new LoginPage(driver);
            login.SendTextToLogin(TestSettings.AdminLoginAlpha);
            login.SendTextToPassword(TestSettings.AdminPasswordAlpha);
            login.ClickLoginBtn();
            Thread.Sleep(3000);
            login.ClickQuitLoginBtn();
            WaitUntil.WaitElement(driver, By.XPath("//mat-card-title[text()='Вход']"));
            string actualError = login.GetInTxt;
            string expectedError = "Вход";
            Assert.AreEqual(expectedError, actualError, $"{expectedError} is not equal to {actualError}");


        }
    }
}
