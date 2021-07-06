namespace WpfApp.Models.GPZMuvo
{
	public sealed class GPZMuvo
    {
        public uint NumberPositionZak { get; set; }
        public string ObjectZak { get; set; }
        public string FieldActivity { get; set; }
        public string SourceFunding { get; set; }
        public string GroupProductsWorksServices { get; set; }
        public decimal PlannedPrice { get; set; }
        public string OKPDCodeName { get; set; }
        public string RussianManufacturer { get; set; }
        public string UniqueGYPSUMRegistrationNumber { get; set; }
        public string DetailedInformationGIS { get; set; }
        public string PlannedPurchaseMethod { get; set; }
        public string InAccordanceEEA { get; set; }
        public string UnitMeasurement { get; set; }
        public uint Quantity { get; set; }
        public string OrderLetterJSC { get; set; }
        public IntegrationEIC IntegrationEic { get; set; }
        public StatusRow Status { get; set; }
    }

    public sealed class IntegrationEIC
    {
        public string DataPublishProc { get; set; }
        public string Deadline { get; set; }
        public string DAtaPublishItog { get; set; }
        public string DataZaklDogovor { get; set; }
        public string StatusProc { get; set; }
    }

    public enum StatusRow : byte
    {
        Green,
        Yellow,
        Blue,
        Red,
        Common
    }
}