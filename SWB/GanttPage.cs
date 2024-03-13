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
    class GanttPage
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

        #region SelectWO
        public void SL_SelectPO(int TestCaseRowIdx, bool isFuncInternalParam)
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

                AutomationTestUI.driver.FindElement(By.XPath(CommonID.SelectWO)).Click();
                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                AutomationTestUI.driver.FindElement(By.XPath(CommonID.ClickEdit)).Click();
                AutomationTestUI.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

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
