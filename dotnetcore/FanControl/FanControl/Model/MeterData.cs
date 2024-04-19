namespace FanControl.Model
{
    public class MeterData
    {
        public int ImportAmount { get; set; }

        public int ExportAmount { get; set; }

        public string MeterURL { get; set; }

        public MeterData(string url)
        {
            MeterURL = url;
        }
    }
}
