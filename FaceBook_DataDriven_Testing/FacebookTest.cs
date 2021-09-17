using NUnit.Framework;

namespace FaceBook_DataDriven_Testing
{
    public class FacebookTest:BaseClass.BaseClass1
    {
        //Test Method to execute LoginPage
        [Test,Order (1)]
        public void TestMethodForLoginPage()
        {
            DoActions.InputEmailAndPassword_into_LoginInputFields(driver);
        }

    }
}