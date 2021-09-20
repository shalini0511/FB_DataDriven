/*using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FaceBook_DataDriven_Testing.FileUpload
{
    public class Fileupload
    {
        //Using page factory for initialization of Page objects
        public Fileupload(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        //using FindsBy locating the element
        [FindsBy(How = How.XPath, Using = "//span[@class='l9j0dhe7']")]
        [CacheLookup]
        public IWebElement home;

        [FindsBy(How = How.XPath, Using = "//span[@class='a8c37x1j ni8dbmo4 stjgntxs l9j0dhe7 ltmttdrg g0qnabr5']")]
        [CacheLookup]
        public IWebElement photo;
    }
}
*/