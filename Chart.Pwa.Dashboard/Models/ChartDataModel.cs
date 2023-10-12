namespace Chart.Pwa.Dashboard.Models
{
    public class ChartDataModel
    {
        public List<string> Labels { get; set; }
        public List<DataSet> DataSets { get; set; }
    }

    public class DataSet
    {
        public string Label { get; set; }
        public List<decimal> Data { get; set; }
        public List<string> BackgroundColor { get; set; }
        public List<string> BorderColor { get; set; }
        public decimal BorderWidth { get; set; }
    }
}
