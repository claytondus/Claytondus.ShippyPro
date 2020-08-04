namespace Claytondus.ShippyPro.Models
{
    public class Rate
    {
        public string carrier { get; set; }
        public string carrier_id { get; set; }
        public string carrier_label { get; set; }
        public decimal rate { get; set; }
        public string rate_id { get; set; }
        public string order_id { get; set; }
        public string delivery_days { get; set; }
        public string service { get; set; }
    }
}
