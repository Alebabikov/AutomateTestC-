using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V108.Debugger;
using OpenQA.Selenium.Support.UI;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Alpha3PageTests
{
    public static class WaitUntil
    {
        public static void Shouldlocate(IWebDriver driver, string location)
        {
            try
            {

                new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains(location));

            }

            catch (WebDriverTimeoutException ex)
            {
                throw new NotFoundException($"Cannot find out that app on specific location: {location}", ex);
            }

        }

        public static void WaitSomeInterval(int second = 2)
        {
            Task.Delay(TimeSpan.FromSeconds(second)).Wait();

        }

        public static void WaitElement(IWebDriver driver, By locator, int seconds = 180)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));

        }
    }
}

