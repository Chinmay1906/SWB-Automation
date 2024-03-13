namespace OptiProERPSWB_WebAutomation
{
    class CommonID
    {
        // Login
       
        public static string userID = "login_username"; 
        public static string Password = "login_password";
        public static string loginConnectID = "login_connect";
        public static string ScheduleName = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-scheduling/kendo-dialog/div[2]/div/form/div[1]/div/input";
        public static string FromDate = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-scheduling/kendo-dialog/div[2]/div/form/div[2]/div[1]/div/input";
        public static string ToDate = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-scheduling/kendo-dialog/div[2]/div/form/div[2]/div[2]/div/input";
        public static string SelectWC = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-scheduling/kendo-dialog/div[2]/div/form/div[3]/div/select";
        public static string CreateButton = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-scheduling/kendo-dialog/div[2]/div/form/kendo-dialog-actions/div/input[2]";
        public static string DeleteButton = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-scheduling/div/div/div/div/div[2]/div/div/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr/td[5]/button[2]";
        public static string DeleteYes = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-scheduling/app-custom-dialogs/kendo-dialog/div[2]/kendo-dialog-actions/div/button[2]";
        public static string ChangeSchedule = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-gantt/div/div/div/div/div/div/div[1]/div/div[3]/div/div/button[14]";
        public static string ScheduleListGrid = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-scheduling/div/div/div/div/div[2]";
        public static string EditButton = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-scheduling/div/div/div/div/div[2]/div/div/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[5]/button[1]";
        public static string DeleteButtonGrid = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-scheduling/div/div/div/div/div[2]/div/div/kendo-grid/div/kendo-grid-list/div/div[1]/table/tbody/tr[1]/td[5]/button[2]";

        public static string companyID = "login_company";
        public static string whseId = "warehouse"; //name
        public static string Role = "role"; //name
        public static string login_product = "login_product";

        public static string ScheduleList = "Schedule List";
        public static string ConfirmationPopupID = "/html/body/main/div[2]/div/swb-root/div/kendo-dialog/div[1]";
        public static string ConfirmationPopup = "/html/body/main/div[2]/div/swb-root/div/kendo-dialog/div[2]";
        public static string ConfirmationNO = "/html/body/main/div[2]/div/swb-root/div/kendo-dialog/div[2]/kendo-dialog-actions/button[1]";
        public static string ConfirmationYES = "/html/body/main/div[2]/div/swb-root/div/kendo-dialog/div[2]/kendo-dialog-actions/button[2]";
        public static string CreateSchedule = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-scheduling/div/div/div/div/div[3]/button";
        public static string CreateScheduleButton = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-scheduling/div/div/div/div/div[3]/button";

        public static string loginButtonID = "login_login";
        public static string resetBtn = "login_reset";
        public static string companyPopupID = "/html/body/main/div/login-root/kendo-popup/div/kendo-list/div/ul/li[2]";
        public static string SelectWO = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-gantt/div/div/div/div/div/div/div[2]/div/div/div/div/div[1]/div[1]/div/div/div[2]/div[1]/div[2]";
        public static string ClickEdit = "/html/body/main/div[2]/div/swb-root/div/view-root/div/main/div/app-gantt/div/div/div/div/div/div/div[2]/div/div/div/div/div[1]/div[3]/div/div/div[2]/div[4]/div[3]/div";

        public static string WMSConfMsg = "/html/body/main/div[2]/div/wms-root/kendo-dialog/div[2]/kendo-dialog-actions";
        public static string WMSConfig_Yes = "/html/body/main/div[2]/div/wms-root/kendo-dialog/div[2]/kendo-dialog-actions/button[2]";
        public static string WMSConfig_No = "/html/body/main/div[2]/div/wms-root/kendo-dialog/div[2]/kendo-dialog-actions/button[1]";

        public static string Login_Submit_btn = "/html/body/main/div[2]/div/wms-root/kendo-dialog/div[2]/kendo-dialog-actions/button[2]";
        public static string Login_Cancel_btn = "/html/body/main/div[2]/div/wms-root/kendo-dialog/div[2]/kendo-dialog-actions/button[1]";


        public static string loginConfID = "//*[@id='single-spa-application:@optiproerp/qcdc']/qcdc-root/div/kendo-dialog/div[2]/kendo-dialog-actions/button[2]";
        public static string selectProductMenuBtn = "//*[@id='single-spa-application:@optiproerp/header']/header-root/app-header/ul/li[1]/a/i";
        public static string PWBProductSelect = "//*[@id='single-spa-application:@optiproerp/header']/header-root/app-header/ul/li[1]/div/a[9]/span";
       
        public static string UserNameCssSelector = "input[id*= 'login_username']";
        public static string PasswordCssSelector = "input[id*= 'login_password']";

        


        //**For Logout**//
        public static string LogOutMenu = "/html/body/wms-root/app-portal-home/div[1]/app-header/ul/li[2]";
        public static string LogOutBtn = "/html/body/wms-root/app-portal-home/div[1]/app-header/ul/li[2]/ul";
        public static string LogOutBtn_yes = "/html/body/wms-root/app-portal-home/span/app-comon-confirm-dialog/kendo-dialog/div[2]/kendo-dialog-actions/button[2]";
        public static string LogOutBtn_NO = "/html/body/wms-root/app-portal-home/span/app-comon-confirm-dialog/kendo-dialog/div[2]/kendo-dialog-actions/button[1]";

        //**************************************For Click to Spotcount**************************************************************//

        public static string SideMenu_AdjCou = "adjustcountSidenav";
        public static string SpotCountLink = "15113";
        public static string SpotCountpagetitle = "title";

        //**For Spotcount Screen**//
        public static string CountDate = "//input[@placeholder = 'dd/MM/yyyy']";  // ID Required
        public static string Refrances = "references";  
        public static string PriceSource = "priceSource";
        public static string DocumentRemarks = "refRemarks"; 
        public static string ItemCodeClear = "clearLineFields";
        public static string ItemCodeInput = "itemCodeInputPC"; 
        public static string ItemCodeSearch = "itemCodeSearch"; 
        public static string ItemName = "Phyitemname"; 
        public static string Price = "Price";
        public static string BinNo = "BinNo"; 
        public static string BinNoSearch = "binLookup"; 
        public static string CountedQty = "CountedQty"; 
        public static string UoMCode = "UoMEntryVal"; 
        public static string ItemRemarks = "lineRemarks"; 
        public static string CancelButton = "btnCancel";
        public static string AddItemButton = "btnAddItem"; 
        public static string PostButton = "btnSubmit"; 
        public static string InwarehouseQTY_Batch = "QtyOnHand";
        public static string InwarehouseQTY_Serial = "QtyOnHand"; 
        public static string InwarehouseQTY_None = "InWhseQty"; 

        //For Spot count Hidden fields for batch
        public static string BatchNo = "batchSerialInputPC"; 
        public static string BatchSearch = "batchSrLookup"; 
        public static string MultipleAddedBatchesShow = "batchSrBtn"; 
        public static string CountedQTYBatch = "LotSerQtyInputPC"; 
        public static string CountedQTYAddMultipleBatches = "batchSrAdd"; 
        public static string BatchShow_grid = "batchserDataGrid";
        public static string BatchShow_cancel = "LotSerShow_cancel";

        //For Spot count Hidden fields for serial 
        public static string SerialNo = "batchSerialInputPC"; 
        public static string SerialSearch = "batchSrLookup"; 
        public static string MultipleAddedSerialShow = "batchSrBtn"; 
        public static string CountedQTYAddMultipleSerial = "batchSrAdd"; 
        public static string SerialShow_grid = "batchserDataGrid";
        public static string SerialShow_cancel = "LotSerShow_cancel";
        

        //For Price_list
        public static string PriceList = "priceList";

        //LookUp- itemCode
        public static string ItemCodeLookupGrid = "commonPopUpGrid";
        public static string ICLookupCloseButton = "commonPopUpCloseBtn";

        //Lookup-BinNo
        public static string BinNoLookupGrid = "commonPopUpGrid";
        public static string BinNoLookupCloseButton = "commonPopUpCloseBtn";

        //Serial_Config (it comes when click on tab )
        public static string SerialAddpopup = "confirmLoginDialogue";
        public static string serialAddpopupYes = "commonCfmYesbtn";
        public static string serialAddpopupNo = "commonCfmNobtn";

        //Serial No lookup 
        public static string SerialLookupgrid = "commonPopUpGrid";
        public static string SerialLookupCloseButton = "commonPopUpCloseBtn";

        //Batch_popup
        public static string BatchAddpopup = "confirmLoginDialogue";
        public static string BatchAddpopupYes = "commonCfmYesbtn";
        public static string BatchAddpopupNo = "commonCfmNobtn";

        //BatchNo Lookup
        public static string BatchLookupgrid = "commonPopUpGrid";
        public static string BatchLookupCloseButton = "commonPopUpCloseBtn";

        //get data from grid
        public static int batchSerCol = 1; 


        //***********************************************Physical Count***********************************************************//

        public static string PhysicalCountLink = "15112";
        public static int ItemcodeID = 2;
        public static int DocNoID = 1;

        public static string inventory_Couting_list_grid = "commonPopUpGrid";
        public static string inventory_Couting_list_cancelButton = "commonPopUpCloseBtn";
        public static string PH_pageTitle = "title";

        public static string PH_DocNo = "DocNo";
        public static string PH_CountedDate = "CountDate";
        public static string DocumentRemarksPHC = "refRemarks"; //id
        public static string scanInputFieldPC = "scanInputFieldPC"; //id
        public static string itemCodeInputPC = "itemCodeInputPC"; //Id
        public static string itemcodesearchbutton = "binTransferScanItemCodeBtn"; //id
        public static string itemcodeclearbutton = "clearLineBtn";
        public static string ItemCodeLookupGridPHC = "itemCodeGrid";
        public static string ItemCodeLookupCloseButton = "itemCodeCloseBtn";
        public static string ItemCodeName = "ItemName";
        public static string PH_BinNo = "BinNo";
        public static string PH_InwhseQTY = "QtyOnHand";
        public static string PH_PreCountQTY = "SAPPrevCntQty";
        public static string PH_Variance = "variance";
        
        public static string CountedQTY_PHC = "countedQtyInputPC"; //id
        public static string CountedQTYSerial = "LotSerQtyInputPC"; //id
        public static string countedQTYSerialAddbtn = "batchSrItemBtn";
        public static string UOMCode = "UoMEntryVal";  //id
        public static string InventoryUOM = "UOM";
        public static string LineRemarks = "LineRemarks"; //id
        public static string CountedCheckbox = "ch7"; //id
        public static string CancelButton_PHC = "cancelbtn";
        public static string SaveNextbtn = "savebtn";
        public static string SubmitButton = "submitbtn";

        //for Batch
        public static string batchInputPC = "batchSerialInputPC"; //id
        public static string BatchInputSearch = "binTransferScanItemCodeBtn"; //id
        public static string CountedQTYBatch_PHC = "LotSerQtyInputPC";
        public static string CountedQTYBatchAddbutton = "batchSrItemBtn";
        public static string PC_MultipleAddedBatchShowbutton = "lotSerListbtn";
        public static string PC_BatchShowGrid = "reportqtypopup";
        public static string PC_BatchshowCancel = "itemcancelbtn";
        //For Serial
        public static string PC_SerialShowGrid = "reportqtypopup";
        public static string PC_SerialshowCancel = "itemcancelbtn";
        public static string PC_MultipleAddedSerialShowbutton = "lotSerListbtn";
        public static string CountedQTYSerial_PHC = "LotSerQtyInputPC";
        public static string CountedQTYSerialAddbutton = "batchSrItemBtn";
        public static string SerialInputPC = "batchSerialInputPC"; //id
        public static string SerialInputsearch = "binTransferScanItemCodeBtn"; //id

        //Serial_Config (it comes when click on tab )
        public static string PC_SerialAddpopup = "confirmLoginDialogue";
        public static string PC_serialAddpopupYes = "commonCfmYesbtn";
        public static string PC_serialAddpopupNo = "commonCfmNobtn";

        //Serial No lookup 
        public static string PC_SerialLookupgrid = "commonPopUpGrid";
        public static string PC_SerialLookupCloseButton = "commonPopUpCloseBtn";

        //Batch_popup
        public static string PC_BatchAddpopup = "confirmLoginDialogue";
        public static string PC_BatchAddpopupYes = "commonCfmYesbtn";
        public static string PC_BatchAddpopupNo = "commonCfmNobtn";

        //BatchNo Lookup
        public static string PC_BatchLookupgrid = "commonPopUpGrid";
        public static string PC_BatchLookupCloseButton = "commonPopUpCloseBtn";

        //-------------------------------------------------------SO_Delivery-----------------------------------------------------------------------------
        public static string SideMenu_Outbound = "outboundSidenav";
        public static string SO_DeliveryLink = "15035";

        public static string SO_CustomerInput = "outCustomerCustomerCodeInput";
        public static string SO_Customer_Lookupbtn = "customerCodeLookupBtn";
        public static string SO_Customer_list_Grid = "commonPopUpGrid";
        public static string SO_Customer_list_Grid_Closebtn = "commonPopUpCloseBtn";
        public static string SO_CustomerName = "outCustomerCustomerName";
        public static string SalesOrderInput = "outCustomerSOInput";
        public static string SalesOrder_Lookupbtn = "soInputLookupBtn";
        public static string SalesOrder_list_grid = "commonPopUpGrid";
        public static string SalesOrder_list_grid_closebtn = "commonPopUpCloseBtn";
        public static string TrackingNo = "scanTracking";
        public static string CustomerRefNo = "custRefNoId";
        public static string SO_Cancelbtn = "cancelBtn";
        public static string SO_Nextbtn = "customerSoLookupBtn";
        public static string SO_udfBtn = "udfBtn";
        public static string SO_AddFreightBtn = "outOrder_AddFreightBtn";
        public static string SO_DeleiveryCollectionBtn = "prepareDeleiveryCollectionBtn";

        
        public static string SO_DTC_CustomerName = "outOrderTitle";
        public static string SO_DTC_SalesOrderInput = "OutOrderOrderNoInput";
        public static string SO_DTC_SalesOrder_Lookupbtn = "orderLookupBtn";
        public static string SO_DTC_SalesOrder_list_grid = "commonPopUpGrid";
        public static string SO_DTC_SalesOrder_list_grid_closebtn = "commonPopUpCloseBtn";
        public static string SO_DTC_PalletNoInput = "outOrderPalletNoInput";
        public static string SO_DTC_PalletNo_Lookupbtn = "palletListBtn";
        public static string SO_DTC_PalletNo_list_grid = "commonPopUpGrid";
        public static string SO_DTC_PalletNo_list_grid_closebtn = "commonPopUpCloseBtn";
        public static string SO_DTC_ItemCodeInput = "outOrderItemcodeinput";
        public static string SO_DTC_PackingNoInput = "packingNo";
        public static string SO_DTC_PackingNo_Lookupbtn = "orderLookupBtn";
        public static string SO_DTC_PackingNo_list_grid = "commonPopUpGrid";
        public static string SO_DTC_PackingNo_list_grid_closebtn = "commonPopUpCloseBtn";
        public static string SO_DTC_PackingType = "typeValue";
        public static string SO_DTC_ItemDetailGrid = "soItemDetailGrid";
        public static int SO_DTC_ItemGrid_ItemColID = 2;
        public static string SO_DTC_Backbtn = "outboundBackBtn";

        public static string SO_DFS_SalesOrder = "outProdissueTitle"; 
        public static string SO_DFS_SelectBatchSerial = "outboundSelectScanInput"; 
        public static string SO_DFS_BatchSerialGrid = "gridSelectedMeterial"; 

        public static string SO_DFS_SelectScanInput = "outboundSelectScanInput";
        public static string SO_DFS_SelectScan_Lookupbtn = "openMaterialBtn";
        public static string SO_DFS_SelectScan_list_grid = "commonPopUpGrid";
        public static string SO_DFS_SelectScan_list_grid_closebtn = "commonPopUpCloseBtn";
        public static string SO_DFS_SelectScan_list_grid_Donebtn = "btnDone";


        public static int SO_DFS_BatchSerialID = 1;
        public static int SO_DFS_ = 1;

        public static int SO_DFS_BatchSerialColID = 2;
        public static int SO_DFS_CheckboxID = 1;

        public static string SO_DFS_Cancelbtn = "outProdissueCancelBtn";
        public static string SO_DFS_Savebtn = "outProdissueSaveBtn";

        public static string SO_Backbtn = "outboundBackBtn";
        public static string SO_AddFreightbtn = "outOrder_AddFreightBtn";
        public static string SO_AddToDelivery = "addDeliverBtn";
        public static string SO_Deliverybtn = "outboundDeliverBtn";

        public static string SO_FreightGrid = "FreightGridData";
        public static string SO_FreightCancelbtn = "freight_CancelBtn";
        public static string SO_FreightApplybtn = "freight_SaveBtn";

        public static int SO_FreightNameColId = 1;
        public static int SO_FreightRemarkColId = 2;
        public static int SO_FreightTaxCodeColId = 3;
        public static int SO_FreightDistribMethodDropdownColId = 5;
        public static int SO_FreightNetAmountColId = 6;


        public static string SO_delivery_dialog = "kendo-dialog-content-421773";
        public static string SO_delivery_dialog_yes = "commonCfmYesbtn";
        public static string SO_delivery_dialog_No = "commonCfmNobtn";

        public static string SO_ordercollectionGrid = "orderCollectionGrid";
        public static int SO_orderCollectionColId = 1;


        //-------------------------------------------------------Picklist_Delivery-----------------------------------------------------------------------------
        public static string Picklist_DeliveryLink = "15044";
        public static string tosterMessage = "//*[@id='toast-container']";

        public static string CustomerInput = "outCustomerCustomerCodeInput";
        public static string Customer_Lookupbtn = "customerCodeLookupBtn";
        public static string Customer_list_Grid = "commonPopUpGrid";
        public static string Customer_list_Grid_Closebtn = "commonPopUpCloseBtn";


        public static string ShipToInput = "outshipToNoInput";
        public static string ShipTo_Lookupbtn = "shipToLookupBtn";
        public static string ShipTo_list_Grid = "commonPopUpGrid";
        public static string ShipTo_list_Grid_Closebtn = "commonPopUpCloseBtn";


        public static string SOInput = "outCustomerSOInput";
        public static string SO_Lookupbtn = "soInputLookupBtn";
        public static string SO_list_grid = "commonPopUpGrid";
        public static string SO_list_grid_closebtn = "commonPopUpCloseBtn";


        public static string PicklistInput = "selectedPicklistId";
        public static string Picklist_Lookupbtn = "selectedPicklistLookupBtn";
        public static string Picklist_grid = "commonPopUpGrid";
        public static string Picklist_grid_closebtn = "commonPopUpCloseBtn";


        public static string Query = "queryBtn";

        public static string ShowPickListResultGrid = "picklistGrid";
        public static int picklistGridItemCodeID = 3;
        public static string None_Row1_SelectCheckbox = "chkbox-0";
        public static int picklistResultBatchSerialId = 5;
        public static int picklistResultCheckboxId = 1;
        public static string checkboxName = "columnfilter";

        public static string cancelbtn = "cancelBtn";
        public static string udfBtn = "udfBtn";
        public static string Deliverbtn = "deliverPickingBtn";
        public static string AddFreightbtn = "outOrder_AddFreightBtnForPickingDel";

        public static string FreightGrid = "FreightGridData";
        public static string FreightCancelbtn = "freight_CancelBtn";
        public static string FreightApplybtn = "freight_SaveBtn";

        public static int FreightNameColId = 1;
        public static int FreightRemarkColId = 2;
        public static int FreightTaxCodeColId = 3;
        public static int FreightDistribMethodDropdownColId = 5;
        public static int FreightNetAmountColId = 6;


        public static string FreightRemarkinput = "freight_Remark";
        public static string FreightTaxCodeinput = "freight_TaxCode";
        public static string FreightTaxCodeLookupBtn = "freight_TaxCodeLookupBtn";
        //commonPopUpGrid
        public static string TaxCode_grid = "commonPopUpGrid";
        public static string TaxCode_grid_closebtn = "commonPopUpCloseBtn";
        public static string FreightDistribMethodDropdown = "freight_DistribMethodBtn";
        public static string FreightNetAmount = "freight_NetAmount";



    }

}
