namespace LabTools.Data
{
    public class FFTPoint
    {
        public double Frequency { get; set; }
        public double Decibels { get; set; }
        public bool IncludeInCalculation { get; set; } = true;
    }
}
