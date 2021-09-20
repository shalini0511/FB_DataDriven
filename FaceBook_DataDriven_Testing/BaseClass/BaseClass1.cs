/* Project = Automating FaceBook using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using System;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Repository;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FaceBook_DataDriven_Testing.BaseClass
{
    public class BaseClass1
    {
        public static IWebDriver driver;
        //Get Logger for fully qualified name for type of 'Tests'
        public static readonly ILog log = LogManager.GetLogger(typeof(FaceBookTest));

        //Get the default ILoggingRepository
        private static readonly ILoggerRepository repository = log4net.LogManager.GetRepository(Assembly.GetCallingAssembly());
        [SetUp]
        public void SetUp()
        {
            // Configuring Log4Net
            // BasicConfigurator.Configure();
            // Valid XML file with Log4Net Configurations
             var fileInfo = new FileInfo(@"App.config");

            // Configure default logging repository with Log4Net configurations
            log4net.Config.XmlConfigurator.Configure(repository, fileInfo);

            try
            {
                log.Info("Entering Setup");
                //local selenium webdriver
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--disable-notifications");
                driver = new ChromeDriver(options);
                driver.Url = "https://www.facebook.com/";
                //To Maximize window
                driver.Manage().Window.Maximize();
                System.Threading.Thread.Sleep(200);
                log.Debug("navigating to url");

                log.Info("Exiting setup");

            }
            catch(Exception ex)
            {
                log.Error(ex.Message);
            }

            
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
