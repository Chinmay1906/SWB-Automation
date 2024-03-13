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
    class ScheduleList
    {
        string SysResultMessages = "";
        String MethodName = "";
        ScheduleList objScheduleList = null;
        OptWebUnitTestSaveLog.WebUnitTestDL ObjWebUnitTestDL = new OptWebUnitTestSaveLog.WebUnitTestDL();

        public void StartUnitTest(DataSet dsDtExecutionDataSet)
        {

            CommonConstant.ScheduleListData = dsDtExecutionDataSet.Tables[0];

            try
            {
                objScheduleList = new ScheduleList();

                AutomationTestUI.driver.Navigate().Refresh();


                for (int idx = 0; idx < CommonConstant.ScheduleListData.Rows.Count; idx++)
                {

                    MethodName = AutomationTestUI.objCommonFunction.GetStringValue(idx, FromConstant.MathodName, CommonConstant.ScheduleListData);

                    if (MethodName != "")
                    {
                        try
                        {
                            typeof(ScheduleList).GetMethod(MethodName).Invoke(objScheduleList, new object[] { idx, false });

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

        #region Click on Schedule list menu
        public void SL_Clickonmenu(int TestCaseRowIdx, bool isFuncInternalParam)
        {
            string TestCaseId = "";
            string TestCaseName = "";
            SysResultMessages = "";
            String isFuncInternalCall = "N";

            if (isFuncInternalParam == true) { isFuncInternalCall = "Y"; }

            try
            {

                //Get Value
                //psExpectedResult = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.ExpectedResult, CommonConstant.SPALoginData);
                TestCaseId = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseId, CommonConstant.ScheduleListData);
                TestCaseName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseName, CommonConstant.ScheduleListData);

                AutomationTestUI.objCommonFunction.Click(CommonID.ScheduleList);

                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                //IWebElement Addclick = AutomationTestUI.driver.FindElement(By.XPath(CommonID.CreateSchedule));
                //Addclick.Click();

                System.Threading.Thread.Sleep(500);

            }
            catch (Exception ex)
            {

                Console.Write(ex);
                ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, "", "Login", TestCaseId, TestCaseName, SysResultMessages, "Failed", ex.ToString(), "SWB", isFuncInternalCall, "");

            }

        }
        #endregion

        #region Click on Create Schedule Button
        public void SL_ClickCreateSchedule(int TestCaseRowIdx, bool isFuncInternalParam)
        {
            String psUserName = "", psPassword = "", psExpectedResult = "", TestCaseId = "", TestCaseName = "";
            SysResultMessages = "";
            String isFuncInternalCall = "N";

            if (isFuncInternalParam == true) { isFuncInternalCall = "Y"; }

            try
            {
                //Get Value
                psExpectedResult = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.ExpectedResult, CommonConstant.ScheduleListData);
                TestCaseId = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseId, CommonConstant.ScheduleListData);
                TestCaseName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseName, CommonConstant.ScheduleListData);
                

                //Click on Create Schedule button
                AutomationTestUI.driver.FindElement(By.XPath(CommonID.CreateScheduleButton)).Click();
                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, psUserName, "Login", TestCaseId, TestCaseName, SysResultMessages, "Failed", ex.ToString(), "SWB", isFuncInternalCall, "");

            }

        }
        #endregion

        #region Enter Schedule Name
        public void SL_EnterScheduleName(int TestCaseRowIdx, bool isFuncInternalParam)
        {
            String ScheduleName = "", psPassword = "", psExpectedResult = "", TestCaseId = "", TestCaseName = "";
            SysResultMessages = "";
            String isFuncInternalCall = "N";

            if (isFuncInternalParam == true) { isFuncInternalCall = "Y"; }

            try
            {
                //Get Value
                psExpectedResult = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.ExpectedResult, CommonConstant.ScheduleListData);
                TestCaseId = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseId, CommonConstant.ScheduleListData);
                TestCaseName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseName, CommonConstant.ScheduleListData);
                ScheduleName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, SL_CONSTANTS.SL_ScheduleName, CommonConstant.ScheduleListData);


                //Set Value in UI
                AutomationTestUI.objCommonFunction.SetValueByXpath(CommonID.ScheduleName, ScheduleName);
                System.Threading.Thread.Sleep(1000);

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, ScheduleName, "Login", TestCaseId, TestCaseName, SysResultMessages, "Failed", ex.ToString(), "SWB", isFuncInternalCall, "");

            }
        }
        #endregion

        #region Enter From & To Date
        public void SL_EnterDate(int TestCaseRowIdx, bool isFuncInternalParam)
        {
            String FromDate = "", ToDate = "", psExpectedResult = "", TestCaseId = "", TestCaseName = "";
            SysResultMessages = "";
            String isFuncInternalCall = "N";

            if (isFuncInternalParam == true) { isFuncInternalCall = "Y"; }

            try
            {
                //Get Value
                psExpectedResult = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.ExpectedResult, CommonConstant.ScheduleListData);
                TestCaseId = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseId, CommonConstant.ScheduleListData);
                TestCaseName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseName, CommonConstant.ScheduleListData);
                FromDate = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, SL_CONSTANTS.SL_FromDate, CommonConstant.ScheduleListData);
                ToDate = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, SL_CONSTANTS.SL_ToDate, CommonConstant.ScheduleListData);


                //Set & Clear value
                AutomationTestUI.objCommonFunction.ClearValueByXpath(CommonID.FromDate);
                System.Threading.Thread.Sleep(500);
                AutomationTestUI.objCommonFunction.SetValueByXpath(CommonID.FromDate, FromDate);
                System.Threading.Thread.Sleep(500);
                AutomationTestUI.objCommonFunction.ClearValueByXpath(CommonID.ToDate);
                AutomationTestUI.objCommonFunction.SetValueByXpath(CommonID.ToDate, ToDate);
                System.Threading.Thread.Sleep(500);

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, FromDate, "Login", TestCaseId, TestCaseName, SysResultMessages, "Failed", ex.ToString(), "PWB", isFuncInternalCall, "");

            }

        }
        #endregion

        #region Select Work Center
        public void SL_SelectWC(int TestCaseRowIdx, bool isFuncInternalParam)
        {
            String psUserName = "", WorkCenter = "", psExpectedResult = "", TestCaseId = "", TestCaseName = "";
            SysResultMessages = "";
            bool pbBtnDisable = true;
            String isFuncInternalCall = "N";

            if (isFuncInternalParam == true) { isFuncInternalCall = "Y"; }

            try
            {
                //Get Value
                psExpectedResult = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.ExpectedResult, CommonConstant.ScheduleListData);
                TestCaseId = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseId, CommonConstant.ScheduleListData);
                TestCaseName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseName, CommonConstant.ScheduleListData);
                WorkCenter = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, SL_CONSTANTS.SL_Workcenter, CommonConstant.ScheduleListData);

                try
                {
                    // Get element with tag name 'login-root'
                    IWebElement LoginRootElement1 = AutomationTestUI.driver.FindElement(By.TagName("swb-root"));
                    IWebElement VIEWROOT = LoginRootElement1.FindElement(By.TagName("view-root"));
                    IWebElement VIEWROOT1= VIEWROOT.FindElement(By.TagName("kendo-dialog"));
                    IWebElement VIEWROOT2 = VIEWROOT1.FindElement(By.TagName("select"));
                    IList<IWebElement> WCList = VIEWROOT2.FindElements(By.TagName("option"));

                    //IWebElement KendolistElement1 = LoginRootElement1.FindElement(By.TagName("kendo-dialog-titlebar"));
                    ////IWebElement KendolistElement2 = LoginRootElement1.FindElement(By.TagName("kendo-dialog-titlebar"));
                    //IList<IWebElement> WCList = KendolistElement1.FindElements(By.Name("sch_work_center"));
                    System.Console.WriteLine(WCList);
                    for(int i = 0;i<WCList.Count;i++)
                    {
                        System.Console.WriteLine(WCList[i].Text);
                        if (WorkCenter == WCList[i].Text)
                        {
                            WCList[i].Click();
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

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, psUserName, "Login", TestCaseId, TestCaseName, SysResultMessages, "Failed", ex.ToString(), "SWB", isFuncInternalCall, "");

            }
        }
        #endregion

        #region Click on Create Schedule button on pop-up
        public void SL_ClickCreatePopup(int TestCaseRowIdx, bool isFuncInternalParam)
        {
            String psUserName = "", psPassword = "", psExpectedResult = "", TestCaseId = "", TestCaseName = "";
            SysResultMessages = "";
            bool pbBtnDisable = true;
            String isFuncInternalCall = "N";

            if (isFuncInternalParam == true) { isFuncInternalCall = "Y"; }

            try
            {
                //Get Value
                psExpectedResult = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.ExpectedResult, CommonConstant.ScheduleListData);
                TestCaseId = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseId, CommonConstant.ScheduleListData);
                TestCaseName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseName, CommonConstant.ScheduleListData);

                AutomationTestUI.driver.FindElement(By.XPath(CommonID.CreateButton)).Click();
                System.Threading.Thread.Sleep(500);

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, psUserName, "Login", TestCaseId, TestCaseName, SysResultMessages, "Failed", ex.ToString(), "PWB", isFuncInternalCall, "");

            }

        }
        #endregion

        #region Create New Schedule
        public void SL_CreateNewSchedule(int TestCaseRowIdx, bool isFuncInternalParam)
        {
            String ScheduleName = "", FromDate = "", psExpectedResult = "", TestCaseId = "", TestCaseName = "", ToDate = "", WorkCenter = "";
            SysResultMessages = "";
            String isFuncInternalCall = "N";

            if (isFuncInternalParam == true) { isFuncInternalCall = "Y"; }



            //Get Value
            psExpectedResult = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.ExpectedResult, CommonConstant.ScheduleListData);
            TestCaseId = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseId, CommonConstant.ScheduleListData);
            TestCaseName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseName, CommonConstant.ScheduleListData);
            ScheduleName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, SL_CONSTANTS.SL_ScheduleName, CommonConstant.ScheduleListData);
            FromDate = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, SL_CONSTANTS.SL_FromDate, CommonConstant.ScheduleListData);
            ToDate = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, SL_CONSTANTS.SL_ToDate, CommonConstant.ScheduleListData);
            WorkCenter = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, SL_CONSTANTS.SL_Workcenter, CommonConstant.ScheduleListData);


            try
            {
                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                SL_Clickonmenu(TestCaseRowIdx, isFuncInternalParam);
                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                SL_ClickCreateSchedule(TestCaseRowIdx, isFuncInternalParam);
                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                SL_EnterScheduleName(TestCaseRowIdx, isFuncInternalParam);
                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                SL_EnterDate(TestCaseRowIdx, isFuncInternalParam);
                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                SL_SelectWC(TestCaseRowIdx, isFuncInternalParam);
                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                SL_ClickCreatePopup(TestCaseRowIdx, isFuncInternalParam);
                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            }
            catch (Exception ex)
            {

                Console.Write(ex);
                ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, "", "Login", TestCaseId, TestCaseName, SysResultMessages, "Failed", ex.ToString(), "PWB", isFuncInternalCall, "");

            }

        }
        #endregion

        #region Change Schedule
        public void SL_ChangeSchedule(int TestCaseRowIdx, bool isFuncInternalParam)
        {
            String psUserName = "", psPassword = "", psExpectedResult = "", TestCaseId = "", TestCaseName = "";
            SysResultMessages = "";
            bool pbBtnDisable = true;
            String isFuncInternalCall = "N";

            if (isFuncInternalParam == true) { isFuncInternalCall = "Y"; }

            try
            {
                //Get Value
                psExpectedResult = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.ExpectedResult, CommonConstant.ScheduleListData);
                TestCaseId = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseId, CommonConstant.ScheduleListData);
                TestCaseName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseName, CommonConstant.ScheduleListData);

                AutomationTestUI.driver.FindElement(By.XPath(CommonID.ChangeSchedule)).Click();
                System.Threading.Thread.Sleep(500);
                AutomationTestUI.driver.Al

                //OpenQA.Selenium.Interactions.Actions actions = new OpenQA.Selenium.Interactions.Actions(AutomationTestUI.driver);
                //AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                //actions.KeyDown(Keys.Enter).Perform();

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                //ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, psUserName, "Login", TestCaseId, TestCaseName, SysResultMessages, "Failed", ex.ToString(), "PWB", isFuncInternalCall, "");
                //OpenQA.Selenium.Interactions.Actions actions = new OpenQA.Selenium.Interactions.Actions(AutomationTestUI.driver);
                //AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

                //actions.KeyDown(Keys.Enter).Perform();
            }

        }
        #endregion

        #region Delete Schedule
        public void SL_DeleteSchedule(int TestCaseRowIdx, bool isFuncInternalParam)
        {
            String psUserName = "", psPassword = "", psExpectedResult = "", TestCaseId = "", TestCaseName = "";
            SysResultMessages = "";
            bool pbBtnDisable = true;
            String isFuncInternalCall = "N";

            if (isFuncInternalParam == true) { isFuncInternalCall = "Y"; }

            try
            {
                //Get Value
                psExpectedResult = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.ExpectedResult, CommonConstant.ScheduleListData);
                TestCaseId = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseId, CommonConstant.ScheduleListData);
                TestCaseName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseName, CommonConstant.ScheduleListData);

                AutomationTestUI.driver.FindElement(By.XPath(CommonID.DeleteButton)).Click();
                System.Threading.Thread.Sleep(500);
                AutomationTestUI.driver.FindElement(By.XPath(CommonID.DeleteYes)).Click();
                System.Threading.Thread.Sleep(500);

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, psUserName, "Login", TestCaseId, TestCaseName, SysResultMessages, "Failed", ex.ToString(), "PWB", isFuncInternalCall, "");

            }

        }
        #endregion

        #region Edit Schedule
        public void SL_EditSchedule(int TestCaseRowIdx, bool isFuncInternalParam)
        {
            String Edit = "", WorkCenter = "", psExpectedResult = "", TestCaseId = "", TestCaseName = "";
            SysResultMessages = "";
            bool pbBtnDisable = true;
            String isFuncInternalCall = "N";

            if (isFuncInternalParam == true) { isFuncInternalCall = "Y"; }

            try
            {
                //Get Value
                psExpectedResult = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.ExpectedResult, CommonConstant.ScheduleListData);
                TestCaseId = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseId, CommonConstant.ScheduleListData);
                TestCaseName = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, FromConstant.TestCaseName, CommonConstant.ScheduleListData);
                Edit = AutomationTestUI.objCommonFunction.GetStringValue(TestCaseRowIdx, SL_CONSTANTS.SL_EditButton, CommonConstant.ScheduleListData);

                IWebElement a = AutomationTestUI.driver.FindElement(By.XPath(CommonID.ScheduleListGrid));


                AutomationTestUI.objCommonFunction.ClickOnActionbtn(Edit, a, false, "1", "5", CommonID.EditButton, CommonID.DeleteButtonGrid);

            }
            catch (Exception ex)
            {
                Console.Write(ex);
                ObjWebUnitTestDL.SaveLogForTestCase(CommonConstant.NoOfTestID, Edit, "Login", TestCaseId, TestCaseName, SysResultMessages, "Failed", ex.ToString(), "PWB", isFuncInternalCall, "");

            }

        }
        #endregion


    }
}
