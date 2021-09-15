using NUnit.Framework;

namespace FaceBook_DataDriven_Testing
{
    public class LoginPagetest:BaseClass.BaseClass1
    {
        //Test Method to execute LoginPage
        [Test]
        public void TestMethodForLoginPage()
        {
            DoActions.InputEmailAndPassword_into_InputFields(driver);
        }
    }
}