namespace WpfApp.Models.GPZCurrentYear
{
    public sealed class Quarter
    {
        public Quarter(CountAndSum addFirst, CountAndSum addSecond)
        {
            AddFirst = addFirst;
            AddSecond = addSecond;
        }

        public Quarter() { }
        public CountAndSum AddFirst { get; set; }
        public CountAndSum AddSecond { get; set; }
    }
}