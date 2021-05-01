namespace WpfApp.Models.GPZCurrentYear
{
    /// <summary>
    ///     Одна строка данных для ГПЗ текущего года
    /// </summary>
    public sealed class RowModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SapPresent FirstColumnSap { get; set; }
        public Quarter FirstQuarter { get; set; }
        public Quarter SecondQuarter { get; set; }
        public Quarter TreeQuarter { get; set; }
        public Quarter FourthQuarter { get; set; }
    }
}