/*using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace FaceBook_DataDriven_Testing.Registeration
{
    public class Registeration
    {
        
        public Registeration(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this); 
        }
        //using FindsBy locating the element
        [FindsBy(How = How.XPath, Using = "//*[@class='_6ltg'][2]")]
        [CacheLookup]
        public IWebElement button;
        
        [FindsBy(How = How.Name, Using = "firstname")]
        [CacheLookup]
        public IWebElement firstName;

        [FindsBy(How = How.Name, Using = "lastname")]
        [CacheLookup]
        public IWebElement lastName;

        [FindsBy(How = How.Name, Using = "reg_email__")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "reg_email_confirmation__")]
        [CacheLookup]
        public IWebElement emailConfirmation;

        [FindsBy(How = How.Name, Using = "reg_passwd__")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "birthday_day")]
        [CacheLookup]
        public IWebElement birthDay;

        [FindsBy(How = How.Id, Using = "month")]
        [CacheLookup]
        public IWebElement birthMonth;

        [FindsBy(How = How.Id, Using = "year")]
        [CacheLookup]
        public IWebElement birthYear;

        [FindsBy(How = How.Name, Using = "sex")]
        [CacheLookup]
        public IWebElement sex;


        [FindsBy(How = How.Name, Using = "websubmit")]
        [CacheLookup]
        public IWebElement submit;



    }
}*/
