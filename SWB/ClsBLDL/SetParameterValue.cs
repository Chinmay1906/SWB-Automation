using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiProERPSWB_WebAutomation
{
    class SetParameterValue
    {
        public void SetValue(string psIdName, string psvalue)
        {
            AutomationTestUI.driver.FindElement(By.Id(psIdName)).SendKeys(psvalue);
        }
        public void ClearValue(string psIdName)
        {
            AutomationTestUI.driver.FindElement(By.Id(psIdName)).Clear();
        }

    }

}
