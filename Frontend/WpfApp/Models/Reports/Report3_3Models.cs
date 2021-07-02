using System;

namespace WpfApp.Models.Reports
{
    public sealed class Report3_3Models
    {
        public uint NumberPosition { get; set; }
        public string NumberPurchase { get; set; }
        public string PurchaseSubject { get; set; }
        public string NameCounterParty { get; set; }
        public string ContractDetails { get; set; }
        public decimal ContractPrice { get; set; }
        public decimal ActualPayment { get; set; }
    }
}