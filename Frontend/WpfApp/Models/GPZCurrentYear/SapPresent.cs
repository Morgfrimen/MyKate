namespace WpfApp.Models.GPZCurrentYear
{
    public sealed class SapPresent
    {
        private readonly CountAndSum _first010121;
        private readonly CountAndSum _first311221;

        public SapPresent(CountAndSum first010121,CountAndSum first311221)
        {
            _first010121 = first010121;
            _first311221 = first311221;
        }
    }
}