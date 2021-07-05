namespace WpfApp.Models.Reports
{
    public sealed class HelpAboutGPZModels
    {
        public string Division { get; set; }
        public ParaValue Plan { get; set; }
        public ParaValue Zakl { get; set; }
        public ParaValue Provedeno { get; set; }
        public ParaValue Result { get; set; }
        public string ProcGPZ { get; set; }
    }

    public sealed class ParaValue
    {
        public int Count { get; set; }
        public string Sum { get; set; }
    }
}