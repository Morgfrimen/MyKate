namespace WpfApp.Models.GPZCurrentYear
{
    /// <summary>
    /// Одна строка данных для ГПЗ текущего года
    /// </summary>
    public sealed class RowModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CountAndSum FirstColumnSap { get; set; }
        public CountAndSum FirstQuarter { get; set; }
        public CountAndSum SecondQuarter { get; set; }
        public CountAndSum TreeQuarter { get; set; }
        public CountAndSum FourthQuarter { get; set; }
    }
}