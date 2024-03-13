using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;


namespace OptiProERPSWB_WebAutomation
{

    class AutomationTestUI
    {
        public static IWebDriver driver = new ChromeDriver();
        public static GetParameterValue objGetParamValue = new GetParameterValue();
        public static SetParameterValue objSetValue = new SetParameterValue();
        public static CommonFunction objCommonFunction = new CommonFunction();
        public static OptWebUnitTestSaveLog.WebUnitTestDL ObjWebUnitTestDL = new OptWebUnitTestSaveLog.WebUnitTestDL();
        //  CommonConstant.NoOfTestID = OptWebUnitTestSaveLog.GetTestIdForDB() + 1;

        static void Main(string[] args)
        {
            AutomationTestUI cSPA = new AutomationTestUI();
            //loaded chrome driver
            //CommonConstant.NoOfTestID = ObjWebUnitTestDL.GetTestIdForDB() + 1;
            //  IWebDriver driver = new ChromeDriver();
            DataTable pdDataTable = new DataTable();

            string psExlFileName = "SWB-Automation-FormList.xlsx";
            string psExlFilePath = cSPA.GetAutomationFromListPath(psExlFileName);
            pdDataTable = cSPA.LoadDataForAutomationList(psExlFilePath);

            // pdDataTable = ObjWebUnitTestDL.CheckTableisExistFormList();

            
            try
            {

                for (int idx = 0; idx < pdDataTable.Rows.Count; idx++)
                {
                    if (pdDataTable.Rows[idx]["EXECUTE"].ToString() == "Y")
                    {
                        switch (pdDataTable.Rows[idx].Field<String>("SCREEN_NAME").ToString())
                        {
                            case CommonConstant.SPALogin:

                                try
                                {

                                    SPALogin SPA = new SPALogin();
                                    DataSet pdExcelDataSetLogin = new DataSet();
                                    string ExecutionExlPath = CommonConstant.AppPathFolder + pdDataTable.Rows[idx].Field<String>("PATH").ToString();

                                     //string ExecutionExlPath = CommonConstant.AppPathFolder + pdDataTable.Rows[idx].Field<String>("PATH").ToString();
                                     string Execu5tionExlPath=  cSPA.GetExlFilePathForScreen(CommonConstant.SPALogin);
                                     pdExcelDataSetLogin = cSPA.LoadDataForExecution(cSPA.GetExlFilePathForScreen(CommonConstant.SPALogin));
                                     //pdExcelDataSetLogin = cSPA.LoadDataForExecution(ExecutionExlPath);
                                    //pdExcelDataSetLogin = ObjWebUnitTestDL.CheckTableisExistScreenList(pdDataTable.Rows[idx].Field<String>("SCREEN_NAME").ToString());

                                    SPA.StartUnitTest(pdExcelDataSetLogin);

                                }
                                catch (Exception ex)
                                {
                                    Console.Write(ex);

                                }
                                break;

                            case CommonConstant.ScheduleList:

                                try
                                {

                                    ScheduleList SPA = new ScheduleList();
                                    DataSet pdExcelDataSetLogin = new DataSet();
                                    string ExecutionExlPath = CommonConstant.AppPathFolder + pdDataTable.Rows[idx].Field<String>("PATH").ToString();

                                    //string ExecutionExlPath = CommonConstant.AppPathFolder + pdDataTable.Rows[idx].Field<String>("PATH").ToString();
                                    string Execu5tionExlPath = cSPA.GetExlFilePathForScreen(CommonConstant.ScheduleList);
                                    pdExcelDataSetLogin = cSPA.LoadDataForExecution(cSPA.GetExlFilePathForScreen(CommonConstant.ScheduleList));
                                    //pdExcelDataSetLogin = cSPA.LoadDataForExecution(ExecutionExlPath);
                                    //pdExcelDataSetLogin = ObjWebUnitTestDL.CheckTableisExistScreenList(pdDataTable.Rows[idx].Field<String>("SCREEN_NAME").ToString());

                                    SPA.StartUnitTest(pdExcelDataSetLogin);

                                }
                                catch (Exception ex)
                                {
                                    Console.Write(ex);

                                }
                                break;

                            case CommonConstant.GanttPage:

                                try
                                {

                                    GanttPage SPA = new GanttPage();
                                    DataSet pdExcelDataSetLogin = new DataSet();
                                    string ExecutionExlPath = CommonConstant.AppPathFolder + pdDataTable.Rows[idx].Field<String>("PATH").ToString();

                                    //string ExecutionExlPath = CommonConstant.AppPathFolder + pdDataTable.Rows[idx].Field<String>("PATH").ToString();
                                    string Execu5tionExlPath = cSPA.GetExlFilePathForScreen(CommonConstant.GanttPage);
                                    pdExcelDataSetLogin = cSPA.LoadDataForExecution(cSPA.GetExlFilePathForScreen(CommonConstant.GanttPage));
                                    //pdExcelDataSetLogin = cSPA.LoadDataForExecution(ExecutionExlPath);
                                    //pdExcelDataSetLogin = ObjWebUnitTestDL.CheckTableisExistScreenList(pdDataTable.Rows[idx].Field<String>("SCREEN_NAME").ToString());

                                    SPA.StartUnitTest(pdExcelDataSetLogin);

                                }
                                catch (Exception ex)
                                {
                                    Console.Write(ex);

                                }
                                break;



                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex);

            }
        }


        public DataTable LoadDataForAutomationList(string xlsFilePath)
        {

            string[] psArray = { };
            //  con.Open();           
            DataSet dsDataSetToSend = new DataSet();
            string connString = string.Empty;

            if (System.Environment.Is64BitOperatingSystem)
            {
                //  connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                //  "Data Source=" + sxlFilePath + ";Extended Properties='Excel 8.0;HDR=Yes;MaxScanRows=1;IMEX=1';"
                connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + xlsFilePath + ";Extended Properties='Excel 8.0;HDR=YES';"; //for above excel 2007  

            }
            else
            {
                connString = @"provider=provider=Microsoft.Jet.OLEDB.4.0; Data Source='" + xlsFilePath + "';Extended Properties='Excel 8.0;HDR=Yes;MaxScanRows=1;IMEX=1'";

            }

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                con.Open();
                try
                {

                    DataTable dtDataTable = new DataTable();
                    dtDataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, psArray);
                    if (dtDataTable != null || dtDataTable.Rows.Count > 0)
                    {
                        int piTableIndex = 0;

                        DataSet dssDataSet = new System.Data.DataSet();

                        for (int sheetCount = 0; sheetCount < dtDataTable.Rows.Count; sheetCount++)
                        {
                            //' Create Query to get Data from sheet. '
                            string psSheetname = dtDataTable.Rows[sheetCount]["table_name"].ToString();
                            string dstblName = dtDataTable.Rows[sheetCount]["table_name"].ToString().Replace("$", "");

                            // String str = "abcdefgh";
                            Char value = '$';
                            Boolean result = psSheetname.Contains(value);

                            if (result == true)
                            {
                                OleDbDataAdapter oleAdpt = new OleDbDataAdapter("SELECT * FROM [" + psSheetname + "]", con);
                                oleAdpt.Fill(dsDataSetToSend, dstblName);



                                DeleteBlankRowsfromDataset(dsDataSetToSend, piTableIndex);

                                //pdDataSet.Tables[psTblName[piTableIndex]].AcceptChanges();

                                //  dsDataSetToSend = pdDataSet;
                                piTableIndex = piTableIndex + 1;
                            }
                        }


                    }

                }
                catch (Exception ex)
                {
                    Console.Write(ex);

                }
                con.Close();
                DataTable results = dsDataSetToSend.Tables[0].Select("EXECUTE='Y'").CopyToDataTable();
                CommonConstant.ScreenName = results;
                return results;

            }


        }

        public string GetExlFilePathForScreen(string psScreenName)
        {
            string psExlFilePathName = "";
            DataView dvScreenName = new DataView(CommonConstant.ScreenName);

            dvScreenName.RowFilter = "SCREEN_NAME='" + psScreenName + "'";
            psExlFilePathName = (string)dvScreenName[0]["PATH"];
            psExlFilePathName = CommonConstant.AppPathFolder + psExlFilePathName;
            return psExlFilePathName;

        }

        public DataSet LoadDataForExecution(string xlsFilePath)
        {

            string[] psArray = { };
            //  con.Open();           
            DataSet dsDataSetToSend = new DataSet();
            string connString = string.Empty;

            if (System.Environment.Is64BitOperatingSystem)
            {
                //  connString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                //  "Data Source=" + sxlFilePath + ";Extended Properties='Excel 8.0;HDR=Yes;MaxScanRows=1;IMEX=1';"
                connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + xlsFilePath + ";Extended Properties='Excel 8.0;HDR=YES';"; //for above excel 2007  

            }
            else
            {
                connString = @"provider=provider=Microsoft.Jet.OLEDB.4.0; Data Source='" + xlsFilePath + "';Extended Properties='Excel 8.0;HDR=Yes;MaxScanRows=1;IMEX=1'";

            }

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                con.Open();
                try
                {

                    DataTable dtDataTable = new DataTable();
                    dtDataTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, psArray);
                    if (dtDataTable != null || dtDataTable.Rows.Count > 0)
                    {
                        int piTableIndex = 0;

                        DataSet dssDataSet = new System.Data.DataSet();

                        for (int sheetCount = 0; sheetCount < dtDataTable.Rows.Count; sheetCount++)
                        {
                            //' Create Query to get Data from sheet. '
                            string psSheetname = dtDataTable.Rows[sheetCount]["table_name"].ToString();
                            string dstblName = dtDataTable.Rows[sheetCount]["table_name"].ToString().Replace("$", "");

                            // String str = "abcdefgh";
                            Char value = '$';
                            Boolean result = psSheetname.Contains(value);

                            if (result == true)
                            {
                                OleDbDataAdapter oleAdpt = new OleDbDataAdapter("SELECT * FROM [" + psSheetname + "] WHERE EXECUTE = 'Y'", con);
                                oleAdpt.Fill(dsDataSetToSend, dstblName);

                                DeleteBlankRowsfromDataset(dsDataSetToSend, piTableIndex);

                                //pdDataSet.Tables[psTblName[piTableIndex]].AcceptChanges();

                                //  dsDataSetToSend = pdDataSet;
                                piTableIndex = piTableIndex + 1;
                            }
                        }


                    }

                }
                catch (Exception ex)
                {
                    Console.Write(ex);

                }
                con.Close();

                return dsDataSetToSend;

            }


        }

        public string GetAutomationFromListPath(string psxlFileName)
        {
            string psReturn = "";

            String psDirectory = AppDomain.CurrentDomain.BaseDirectory;
            psDirectory = psDirectory.Remove(psDirectory.IndexOf("\\bin\\Debug"));
            CommonConstant.AppPath = psDirectory;
            CommonConstant.AppPathFolder = psDirectory + "\\SWB-Automation-Test-Case\\";
            psReturn = psDirectory + "\\" + psxlFileName;
            return psReturn;
        }

        public DataSet GetExlData()
        {
            DataSet pdReturnDataset = new DataSet();


            return pdReturnDataset;
        }
        public bool DeleteBlankRowsfromDataset(DataSet pdDataset, int piTableIndex)
        {
            bool pbReturn = true;
            try
            {

                pdDataset.Tables[piTableIndex].Rows.Cast<DataRow>().ToList().FindAll(Row =>
                { return String.IsNullOrEmpty(String.Join("", Row.ItemArray)); }).ForEach(Row =>
                { pdDataset.Tables[piTableIndex].Rows.Remove(Row); });

                pdDataset.Tables[piTableIndex].AcceptChanges();

                pbReturn = true;
            }
            catch (Exception ex)
            {
                pbReturn = false;
                throw;
            }

            return pbReturn;

        }



    }
}