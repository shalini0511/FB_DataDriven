using System;
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
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[2]/div[3]/div/div[1]/div[1]/ul/li[1]/span/div")]
        [CacheLookup]
        public IWebElement home;


         [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[3]/div/div/div[1]/div[1]/div/div[2]/div/div/div/div[3]/div/div[2]/div/div/div/div[2]/div[2]/div[1]/span[2]/span")]
         [CacheLookup]
         public IWebElement photo;


         [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/div/div[4]/div/div/div[1]/div/div[2]/div/div/div/form/div/div[1]/div/div/div/div[2]/div[1]/div[1]/div[1]/div/div/div/div/div/div/div[2]/div/div/div/div")]
         [CacheLookup]
         public IWebElement text;


         [FindsBy(How = How.XPath, Using = "//*[@class='s45kfl79 emlxlaya bkmhp75w spb7xbtv bp9cbjyn" +
                                           " rt8b4zig n8ej3o3l agehan2d sk4xxmp2" +
                                           " rq0escxv pq6dq46d taijpn5t l9j0dhe7 tdjehn4e qypqp5cg q676j6op']")]
         [CacheLookup]
         public IWebElement addPhoto;


         [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[1]/div[4]/div[1]/" +
                                           "div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/div[1]/form[1]/div[1]/div[1]/div[1]/div[1]/div[1]" +
                                           "/div[3]/div[2]/div[1]/div[1]/div[1]")]
         [CacheLookup]
         public IWebElement post;





        /*[FindsBy(How = How.XPath, Using = "//*[@class='dwxx2s2f dicw6rsg kady6ibp rs0gx3tq'] [1]")]
        [CacheLookup]
        public IWebElement uploadPhoto;*/

        

    }
}
