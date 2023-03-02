namespace Capture
{
    public class mSpectrometerSettings
    {
        public enum mode
        {
            OnDemand = 0,
        };

        public bool StrobEnable { get; set; }
        public int IntegrationTime { get; set; }
        public int ScansToAverage { get; set; }
        public int BoxcarWidth { get; set; }
        public bool ElectricDark { get; set; }
        public bool NonlinearityCorrection { get; set; }
        public mode TriggerMode { get; set; }
    }
}
