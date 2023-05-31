using Docker.DotNet.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects
{
    public class MouseControl : BasePage
    {

        public MouseControl(IWebDriver driver) : base(driver)
        {

        }
        public static Actions actions = new Actions(driver);
    }
}