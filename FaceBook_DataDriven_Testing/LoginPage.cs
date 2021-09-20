/* Project = Automating Facebook using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
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

            [FindsBy(How = How.XPath, Using = "//span[@class='l9j0dhe7']")]
            [CacheLookup]
            public IWebElement home;


            [FindsBy(How = How.XPath, Using = "//*[text()='Photo/Video']")]
            [CacheLookup]
            public IWebElement photo;

            [FindsBy(How = How.XPath, Using = "//*[@class='s45kfl79 emlxlaya bkmhp75w spb7xbtv bp9cbjyn" +
                                              " rt8b4zig n8ej3o3l agehan2d sk4xxmp2" +
                                              " rq0escxv pq6dq46d taijpn5t l9j0dhe7 tdjehn4e qypqp5cg q676j6op']")]
            [CacheLookup]
            public IWebElement addPhoto;





    }


}
