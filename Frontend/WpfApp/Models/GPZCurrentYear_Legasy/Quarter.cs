namespace WpfApp.Models.GPZCurrentYear_Legasy
{
    public sealed class Quarter
    {
        public CountAndSum AddFirst { get; set; }
        public CountAndSum AddSecond { get; set; }

        public Quarter(CountAndSum addFirst, CountAndSum addSecond)
        {
            AddFirst = addFirst;
            AddSecond = addSecond;
        }

        public Quarter() { }
    }
}