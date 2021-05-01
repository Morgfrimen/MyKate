namespace WpfApp.Models.GPZCurrentYear
{
    public sealed class SapPresent
    {
        public SapPresent(CountAndSum first, CountAndSum second)
        {
            First = first;
            Second = second;
        }

        public SapPresent() { }
        public CountAndSum First { get; set; }
        public CountAndSum Second { get; set; }
    }
}