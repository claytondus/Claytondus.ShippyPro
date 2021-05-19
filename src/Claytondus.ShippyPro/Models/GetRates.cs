using System.Collections;
using System.Collections.Generic;

namespace Claytondus.ShippyPro.Models
{
    public class GetRates
    {
        public string Method => "GetRates";
        public GetRatesParams? Params { get; set; }
    }

    public class GetRatesParams
    {
        public Address? to_address { get; set; }
        public Address? from_address { get; set; }
        public IEnumerable<Parcel>? parcels { get; set; }
        public decimal Insurance { get; set; }
        public string? InsuranceCurrency { get; set; }
        public decimal CashOnDelivery { get; set; }
        public string? CashOnDeliveryCurrency { get; set; }
        public string? ContentDescription { get; set; }
        public string? TotalValue { get; set; }
        public string? ShippingService { get; set; }
        public IEnumerable<string>? RateCarriers { get; set; }
    }

    public class GetRatesResponse
    {
        public IEnumerable<Rate>? Rates { get; set; }
    }
}
