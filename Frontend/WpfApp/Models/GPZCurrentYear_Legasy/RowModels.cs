namespace WpfApp.Models.GPZCurrentYear_Legasy
{
    /// <summary>
    ///     Одна строка данных для ГПЗ текущего года
    /// </summary>
    public sealed class RowModels
    {
        public SapPresent FirstColumnSap { get; set; }
        public Quarter FirstQuarter { get; set; }
        public Quarter FourthQuarter { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public Quarter SecondQuarter { get; set; }
        public Quarter TreeQuarter { get; set; }
    }
}