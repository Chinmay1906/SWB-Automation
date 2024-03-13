using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiProERPSWB_WebAutomation
{
    class CommonConstant
    {
        public const string SPALogin = "SPALogin";
        public const int NoOfTest = 0;
        public const string Failed = "Failed";
        public const string NoExep = "NoExep";
        public const string Pass = "Pass";
        public const string SWB = "SWB";
        public const string ProductCode = "SWB";
        public const string ScheduleList = "ScheduleList";
        public const string GanttPage = "GanttPage";

        //   public const string SPALoginUser = "";

        public const string Spot_Count = "Spot_Count";
        public const string AUTOPHYSICAL_COUNT = "AUTOPHYSICAL_COUNT";
        public const string AUTOSO_DELIVERY = "AUTOSO_DELIVERY";
        public const string AUTOPICKLIST_DELIVERY = "AUTOPICKLIST_DELIVERY";

        private static string psAppPath; // field
     
        public static string AppPath   // property
        {
            get { return psAppPath; }   // get method
            set { psAppPath = value; }  // set method
        }

        private static string psAppPathFolder; // field
        public static string AppPathFolder   // property
        {
            get { return psAppPathFolder; }   // get method
            set { psAppPathFolder = value; }  // set method
        }

        private static DataTable pdScreenName; // field
        public static DataTable ScreenName   // property
        {
            get { return pdScreenName; }   // get method
            set { pdScreenName = value; }  // set method
        }

        private static DataTable pdSO_DeliveryData; // field
        public static DataTable SO_DeliveryData   // property
        {
            get { return pdSO_DeliveryData; }   // get method
            set { pdSO_DeliveryData = value; }  // set method
        }

        private static DataTable pdScheduleListData; // field
        public static DataTable ScheduleListData   // property
        {
            get { return pdScheduleListData; }   // get method
            set { pdScheduleListData = value; }  // set method
        }

        private static DataTable pdGanttPage; // field
        public static DataTable SL_GanttPage   // property
        {
            get { return pdGanttPage; }   // get method
            set { pdGanttPage = value; }  // set method
        }

        private static DataTable pdPicklist_DeliveryData; // field
        public static DataTable Picklist_DeliveryData   // property
        {
            get { return pdPicklist_DeliveryData; }   // get method
            set { pdPicklist_DeliveryData = value; }  // set method
        }


        private static DataTable pdSpot_CountData; // field
        public static DataTable Spot_CountData   // property
        {
            get { return pdSpot_CountData; }   // get method
            set { pdSpot_CountData = value; }  // set method
        }

        private static DataTable pdPhysical_CountData; // field
        public static DataTable Physical_CountData   // property
        {
            get { return pdPhysical_CountData; }   // get method
            set { pdPhysical_CountData = value; }  // set method
        }

        private static DataTable pdSPALoginData; // field
        public static DataTable SPALoginData   // property
        {
            get { return pdSPALoginData; }   // get method
            set { pdSPALoginData = value; }  // set method
        }

        private static int pdNoOfTestID;
        public static int NoOfTestID // property
        {
            get { return pdNoOfTestID; } // get method
            set { pdNoOfTestID = value; } // set method
        }

        private static string psSPAUserName; // field
        public static string SPALoginUserName   // property
        {
            get { return psSPAUserName; }   // get method
            set { psSPAUserName = value; }  // set method
        }
       

    }
}
