using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class DownloadFilePage : BasePage
    {
        public DownloadFilePage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement btnDownloadShowInFolder => driver.FindElement(By.CssSelector("html body"))
                                                     .FindElement(By.CssSelector("downloads-manager")).GetShadowRoot()
                                                     .FindElement(By.CssSelector("div[id='mainContainer']"))
                                                     .FindElement(By.CssSelector("iron-list"))
                                                     .FindElement(By.CssSelector("downloads-item")).GetShadowRoot()
                                                     .FindElement(By.CssSelector("div[id='content']"))
                                                     .FindElement(By.CssSelector("div[id='details']"))
                                                     .FindElement(By.CssSelector("div[id='safe']"))
                                                     .FindElement(By.CssSelector("span[role='gridcell']"))
                                                     .FindElement(By.CssSelector("a[id='show']"));





        public string GetDownloadShowInFolder() => btnDownloadShowInFolder.Text;
    }
}
