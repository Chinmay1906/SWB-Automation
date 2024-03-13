using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace OptiProERPSWB_WebAutomation
{

    class SPALogin
    {
       
        string SysResultMessages = "";
        String MethodName = "";
        SPALogin objSPALogin = null;
        OptWebUnitTestSaveLog.WebUnitTestDL ObjWebUnitTestDL = new OptWebUnitTestSaveLog.WebUnitTestDL();

        public void StartUnitTest(DataSet dsDtExecutionDataSet)
        {
       
            CommonConstant.SPALoginData = dsDtExecutionDataSet.Tables[0];
        
            try
               {
                    objSPALogin = new SPALogin();
                   
                    AutomationTestUI.driver.Navigate().Refresh();
                

                for (int idx = 0; idx < CommonConstant.SPALoginData.Rows.Count; idx++)
                {

                    MethodName = AutomationTestUI.objCommonFunction.GetStringValue(idx, FromConstant.MathodName, CommonConstant.SPALoginData);

                    if (MethodName != "")
                    {
                        try
                        {
                            typeof(SPALogin).GetMethod(MethodName).Invoke(objSPALogin, new object[] { idx,false});

                        }
                        catch (Exception ex)
                        {
                            Console.Write(ex);

                        }
                    }


                }
                ObjWebUnitTestDL.Dispose();

            }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
            
        }

        #region Verify the URL.
        public void SPALogIn_VerifyURL(int TestCaseRowIdx, bool isFuncInternalParam)
        {
            AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            String psExpectedResult = "";
            string TestCaseId = "";
            string TestCaseName = "", psUrl = "";
            SysResultMessages = "";
            String isFuncInternalCall = "N";
            bool pbResult = false;

            if (isFuncInternalParam == true) { isFuncInternalCall = "Y"; }

            try
            {

                //Get Value
                psExpectedResult = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.ExpectedResult, CommonConstant.SPALoginData);
                TestCaseId = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseId, CommonConstant.SPALoginData);
                TestCaseName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseName, CommonConstant.SPALoginData);
                psUrl = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, Login.URL, CommonConstant.SPALoginData);

                System.Threading.Thread.Sleep(500);

                try
                {
                    AutomationTestUI.driver.Navigate().GoToUrl(psUrl);
                    AutomationTestUI.driver.Manage().Window.Maximize();
                    AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    //IJavaScriptExecutor js = (IJavaScriptExecutor)AutomationTestUI.driver;
                    //js.ExecuteScript("return localStorage.setItem('devtools','true')");
                    //js.ExecuteScript("return localStorage.setItem('import-map-override:@optiproerp/cnf','http://localhost:4220/main.js');");
                    Console.WriteLine("Browser Maximized");
                    WebDriverWait pwait = new WebDriverWait(AutomationTestUI.driver, TimeSpan.FromMinutes(1));
                    IWebElement pssearchResult = pwait.Until(x => x.FindElement(By.Id(CommonID.loginConnectID)));
                    AutomationTestUI.driver.Navigate().Refresh();
                    pbResult = true;

                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, "", "Login", TestCaseId, TestCaseName, SysResultMessages, CommonConstant.Failed, ex.ToString(), CommonConstant.ProductCode, isFuncInternalCall, MethodName);
                    pbResult = false;
                }

                if (pbResult == true)
                {
                    ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, "", "Login", TestCaseId, TestCaseName, SysResultMessages, CommonConstant.Pass, "NoExep", CommonConstant.ProductCode, isFuncInternalCall, MethodName);

                }
                else
                {
                    ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, "", "Login", TestCaseId, TestCaseName, SysResultMessages, CommonConstant.Failed, "NoExep", CommonConstant.ProductCode, isFuncInternalCall, MethodName);

                }

            }
            catch (Exception ex)
            {

                Console.Write(ex);
                ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, "", "Login", TestCaseId, TestCaseName, SysResultMessages, CommonConstant.Failed, ex.ToString(), CommonConstant.ProductCode, isFuncInternalCall, MethodName);

            }

        }
        #endregion

        #region Login
        public void SPALogin_SWB(int TestCaseRowIdx, bool isFuncInternalParam)
        {
            AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            String psUserName = "", psPassword = "", psExpectedResult = "", psCompanyName = "", TestCaseId = "", TestCaseName = "", psProductName = "";
            SysResultMessages = "";
            String psConfigurationSc1 = "", psSideMenu = "";
            bool pbLoginConFIDExists = false;
            bool pbResult = true;
            WebDriverWait wait;
            String isFuncInternalCall = "N";

            if (isFuncInternalParam == true) { isFuncInternalCall = "Y"; }

            try
            {
                //Get Value
                psExpectedResult = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.ExpectedResult, CommonConstant.SPALoginData);
                TestCaseId = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseId, CommonConstant.SPALoginData);
                TestCaseName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseName, CommonConstant.SPALoginData);
                psUserName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, Login.UserId, CommonConstant.SPALoginData);
                psPassword = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, Login.Password, CommonConstant.SPALoginData);
                psCompanyName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, Login.CompanyName, CommonConstant.SPALoginData);
                psProductName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, Login.ProductName, CommonConstant.SPALoginData);
                //Clear value
                AutomationTestUI.objCommonFunction.ClearValue(CommonID.userID);
                AutomationTestUI.objCommonFunction.ClearValue(CommonID.Password);

                //Set Value in UI
                AutomationTestUI.objCommonFunction.SetValue(CommonID.userID, psUserName);
                System.Threading.Thread.Sleep(500);
                AutomationTestUI.objCommonFunction.SetValue(CommonID.Password, psPassword);
                System.Threading.Thread.Sleep(500);

                AutomationTestUI.objCommonFunction.Click(CommonID.loginConnectID);
                System.Threading.Thread.Sleep(2500);

                wait = new WebDriverWait(AutomationTestUI.driver, TimeSpan.FromMinutes(1));

                AutomationTestUI.objCommonFunction.Click(CommonID.companyID);

                System.Threading.Thread.Sleep(500);

                CommonConstant.SPALoginUserName = psUserName;
                try
                {
                    // Get element with tag name 'login-root'
                    IWebElement LoginRootElement1 = AutomationTestUI.driver.FindElement(By.TagName("login-root"));
                    IWebElement KendolistElement1 = LoginRootElement1.FindElement(By.TagName("kendo-popup"));
                    IList<IWebElement> Companylist = KendolistElement1.FindElements(By.ClassName("k-item"));

                    foreach (IWebElement e in Companylist)
                    {
                        System.Console.WriteLine(e.Text);
                        if (psCompanyName == e.Text)
                        {
                            e.Click();
                            AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                            break;
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);

                }

                System.Threading.Thread.Sleep(500);

                AutomationTestUI.objCommonFunction.Click(CommonID.login_product);

                try
                {

                    IWebElement LoginRootElement1 = AutomationTestUI.driver.FindElement(By.TagName("login-root"));
                    IWebElement KendolistElement3 = LoginRootElement1.FindElement(By.TagName("kendo-popup"));
                    IList<IWebElement> ProductList = KendolistElement3.FindElements(By.ClassName("k-item"));

                    foreach (IWebElement e in ProductList)
                    {
                        System.Console.WriteLine(e.Text);
                        if (psProductName == e.Text)
                        {
                            e.Click();
                            AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                            break;
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.Write(ex);

                }


                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
                AutomationTestUI.objCommonFunction.Click(CommonID.loginButtonID);
                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(2);

                AutomationTestUI.driver.FindElement(By.XPath(CommonID.ConfirmationYES)).Click();

                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                // SL_CreateNewSchedule(TestCaseRowIdx,isFuncInternalParam);


                ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, CommonConstant.SPALoginUserName, "Login", TestCaseId, TestCaseName, "Logged in Successfully", CommonConstant.Pass, "", CommonConstant.ProductCode, isFuncInternalCall, MethodName);
            }

            catch (Exception ex)
            {
                Console.Write(ex);
                ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, CommonConstant.SPALoginUserName, "Login", TestCaseId, TestCaseName, SysResultMessages, CommonConstant.Failed, ex.ToString(), CommonConstant.ProductCode, isFuncInternalCall, MethodName);

                System.Threading.Thread.Sleep(5000);


            }
}

        #endregion


    }


}
