namespace Claytondus.ShippyPro.Models
{
    public class CustomsDetail
    {
        public string Description { get; set; }

        public decimal Weight { get; set; }

        public int Quantity { get; set; }

        public decimal UnitValue { get; set; }

        public string OriginCountry { get; set; }
        public string Currency { get; set; }
        public string HSCode { get; set; }

    }
}
