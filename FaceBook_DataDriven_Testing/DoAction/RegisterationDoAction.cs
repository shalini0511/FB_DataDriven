/*using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;

namespace FaceBook_DataDriven_Testing.DoAction
{
    public class RegisterationDoAction:BaseClass.BaseClass1
    {
        public static void SignUp()
        {
            
            Registeration.Registeration reg = new Registeration.Registeration(driver);
            reg.button.Click();
            System.Threading.Thread.Sleep(3000);

            RegisterationExcelOperation.PopulateInCollection(@"C:\Users\HP\source\repos\FaceBook_DataDriven_Testing\FaceBook_DataDriven_Testing\Registeration.xlsx");
            reg.firstName.SendKeys(ExcelOperation.ReadData(1, "firstname"));
            System.Threading.Thread.Sleep(1000);

            reg.lastName.SendKeys(ExcelOperation.ReadData(1, "secondname"));
            System.Threading.Thread.Sleep(1000);

            reg.email.SendKeys(ExcelOperation.ReadData(1, "email"));
            System.Threading.Thread.Sleep(1000);

            reg.emailConfirmation.SendKeys(ExcelOperation.ReadData(1, "emailconfirm"));
            System.Threading.Thread.Sleep(1000);

            reg.password.SendKeys(ExcelOperation.ReadData(1, "password"));
            System.Threading.Thread.Sleep(1000);

            SelectElement element1 = new SelectElement(reg.birthDay);
            element1.SelectByText("5");


            SelectElement element2 = new SelectElement(reg.birthMonth);
            element2.SelectByText("11");

            SelectElement element3 = new SelectElement(reg.birthYear);
            element3.SelectByText("1999");

            reg.sex.Click();
            System.Threading.Thread.Sleep(1000);

            reg.submit.Click();


        }
    }
}*/
