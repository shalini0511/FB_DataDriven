using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FaceBook_DataDriven_Testing
{
    public  class LoginPage
    {
          //Using page factory for initialization of Page objects
            public LoginPage(IWebDriver driver)
            {
                PageFactory.InitElements(driver, this);
            }
            //using FindsBy locating the element
            [FindsBy(How = How.Name, Using = "email")]
            [CacheLookup]
            public IWebElement email;

            [FindsBy(How = How.Id, Using = "pass")]
            [CacheLookup]
            public IWebElement password;

            [FindsBy(How = How.Name, Using = "login")]
            [CacheLookup]
            public IWebElement loginBtn;

            

    }

    
}
