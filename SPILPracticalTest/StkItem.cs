//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPILPracticalTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class StkItem
    {
        public int StockLink { get; set; }
        public string Code { get; set; }
        public string Description_1 { get; set; }
        public string Description_2 { get; set; }
        public string Description_3 { get; set; }
        public string ItemGroup { get; set; }
        public string Pack { get; set; }
        public string TTI { get; set; }
        public string TTC { get; set; }
        public string TTG { get; set; }
        public string TTR { get; set; }
        public string Bar_Code { get; set; }
        public Nullable<double> Re_Ord_Lvl { get; set; }
        public Nullable<double> Re_Ord_Qty { get; set; }
        public Nullable<double> Min_Lvl { get; set; }
        public Nullable<double> Max_Lvl { get; set; }
        public Nullable<double> AveUCst { get; set; }
        public Nullable<double> LatUCst { get; set; }
        public Nullable<double> LowUCst { get; set; }
        public Nullable<double> HigUCst { get; set; }
        public Nullable<double> StdUCst { get; set; }
        public Nullable<double> Qty_On_Hand { get; set; }
        public Nullable<double> LGrvCount { get; set; }
        public bool ServiceItem { get; set; }
        public bool ItemActive { get; set; }
        public Nullable<double> ReservedQty { get; set; }
        public Nullable<double> QtyOnPO { get; set; }
        public Nullable<double> QtyOnSO { get; set; }
        public bool WhseItem { get; set; }
        public bool SerialItem { get; set; }
        public bool DuplicateSN { get; set; }
        public bool StrictSN { get; set; }
        public string BomCode { get; set; }
        public Nullable<int> SMtrxCol { get; set; }
        public Nullable<int> PMtrxCol { get; set; }
        public Nullable<double> JobQty { get; set; }
        public string cModel { get; set; }
        public string cRevision { get; set; }
        public string cComponent { get; set; }
        public Nullable<System.DateTime> dDateReleased { get; set; }
        public Nullable<int> iBinLocationID { get; set; }
        public Nullable<System.DateTime> dStkitemTimeStamp { get; set; }
        public Nullable<int> iInvSegValue1ID { get; set; }
        public Nullable<int> iInvSegValue2ID { get; set; }
        public Nullable<int> iInvSegValue3ID { get; set; }
        public Nullable<int> iInvSegValue4ID { get; set; }
        public Nullable<int> iInvSegValue5ID { get; set; }
        public Nullable<int> iInvSegValue6ID { get; set; }
        public Nullable<int> iInvSegValue7ID { get; set; }
        public string cExtDescription { get; set; }
        public string cSimpleCode { get; set; }
        public bool bCommissionItem { get; set; }
        public Nullable<double> MFPQty { get; set; }
        public bool bLotItem { get; set; }
        public Nullable<int> iLotStatus { get; set; }
        public bool bLotMustExpire { get; set; }
        public int iItemCostingMethod { get; set; }
        public double fItemLastGRVCost { get; set; }
        public int iEUCommodityID { get; set; }
        public int iEUSupplementaryUnitID { get; set; }
        public double fNetMass { get; set; }
        public Nullable<int> iUOMStockingUnitID { get; set; }
        public Nullable<int> iUOMDefPurchaseUnitID { get; set; }
        public Nullable<int> iUOMDefSellUnitID { get; set; }
        public Nullable<int> uiIISRVPRICEID { get; set; }
        public Nullable<bool> ubIIEDGEALLOWANCE { get; set; }
        public Nullable<double> ufIIThickness { get; set; }
        public Nullable<bool> ubIITemplate { get; set; }
        public Nullable<int> uiIITemplPriceID { get; set; }
        public Nullable<bool> ubIIGLASSSERVICE { get; set; }
        public Nullable<int> uiIIItemType { get; set; }
        public Nullable<double> ufIIMINCHRG { get; set; }
        public Nullable<double> ufIIMINSQM { get; set; }
        public Nullable<double> ufIIWEIGHT { get; set; }
        public Nullable<int> uiIIPRICETYPEID { get; set; }
        public Nullable<bool> ubIIPrintLabels { get; set; }
        public bool DefaultGlassService { get; set; }
        public bool IsLaminateItem { get; set; }
        public Nullable<double> ufIIQtyInVolume { get; set; }
        public Nullable<int> uiIIMainItemLink { get; set; }
        public Nullable<bool> ubIIAllowNegative { get; set; }
        public Nullable<int> uiIISupplier { get; set; }
        public Nullable<int> uiIIWidth { get; set; }
        public Nullable<int> uiIIHeight { get; set; }
        public Nullable<double> ufIILotQty { get; set; }
        public Nullable<double> ufIIGrvQty { get; set; }
        public Nullable<double> ufIISOQtyVolume { get; set; }
        public Nullable<double> uiIIWarehouse { get; set; }
        public bool ShowPODes { get; set; }
        public bool IsNonStockItem { get; set; }
        public bool IsExternalItem { get; set; }
        public double POMinimumArea { get; set; }
        public string AccountNumber { get; set; }
        public int CostCentre { get; set; }
        public string AddDetails { get; set; }
        public string SalesAccount { get; set; }
        public string PurchaseAccount { get; set; }
        public Nullable<double> Length { get; set; }
        public Nullable<double> BulkQty { get; set; }
        public Nullable<double> BulkRate { get; set; }
        public bool PriceListItem { get; set; }
        public bool CalcPriceAsPercentage { get; set; }
        public double CalcPricePercentage { get; set; }
        public bool BOMItem { get; set; }
    }
}
