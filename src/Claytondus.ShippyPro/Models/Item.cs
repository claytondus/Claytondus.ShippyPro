namespace Claytondus.ShippyPro.Models
{
    public class Item
    {
        public string title { get; set; }
        public string imageurl { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public string sku { get; set; }
        public string origin_country { get; set; }
        public string hs_code { get; set; }
    }
}
