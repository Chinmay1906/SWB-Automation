using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OpenQA.Selenium;

namespace OptiProERPSWB_WebAutomation
{
    class GetParameterValue
    {
        public String GetStringValue (int piRowId,string psColumnName, DataTable ObjDataTable)
        {
            string psReturn = "";
            psReturn = Convert.ToString(ObjDataTable.Rows[piRowId].Field<String>(""+ psColumnName +""));
            return psReturn;
        }
        public int GetIntValue()
        {
            int piReturn=0 ;
            return piReturn;
        }

        public DateTime GetDateValue()
        {
            DateTime pdReturn= DateTime.Today;
            return pdReturn;
        }

        public string GetPlaceholderValueUI(string psIdName)
        {
            string psReturn = "";
            psReturn = AutomationTestUI.driver.FindElement(By.Id(psIdName)).GetAttribute("placeholder");
            return psReturn;
        }
        public void Click(string psIdName)
        {
            AutomationTestUI.driver.FindElement(By.Id(psIdName)).Click();
        }

        public string GetTextBoxValueUI(string psIdName)
        {
            string psReturn = "";
            psReturn = AutomationTestUI.driver.FindElement(By.Id(psIdName)).GetAttribute("value");
            return psReturn;
        }

        public string GetErrorMsgForBlurUI(string psIdName)
        {
            string psReturn = "";
            psReturn = AutomationTestUI.driver.FindElement(By.Id(psIdName)).Text;
            return psReturn;
        }
    }
}
