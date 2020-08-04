using System.Collections;
using System.Collections.Generic;

namespace Claytondus.ShippyPro.Models
{
    public class Ship
    {
        public string Method => "Ship";
        public ShipParams Params { get; set; }
    }

    public class ShipParams
    {
        public Address to_address { get; set; }
        public Address from_address { get; set; }
        public IEnumerable<Parcel> parcels { get; set; }
        public string TotalValue { get; set; }
        public string TransactionID { get; set; }
        public string ContentDescription { get; set; }
        public decimal Insurance { get; set; }
        public string InsuranceCurrency { get; set; }
        public decimal CashOnDelivery { get; set; }
        public string CashOnDeliveryCurrency { get; set; }
        public int CashOnDeliveryType { get; set; }
        public decimal ShipmentAmountPaid { get; set; }
        public decimal ShipmentCost { get; set; }
        public string ShipmentCostCurrency { get; set; }
        public string CarrierName { get; set; }
        public string CarrierService { get; set; }
        public int CarrierID { get; set; }
        public string OrderID { get; set; }
        public string RateID { get; set; }
        public string Incoterm { get; set; }
        public string BillAccountNumber { get; set; }
        public string PaymentMethod { get; set; }
        public string Note { get; set; }
        public string CarrierNote { get; set; }
        public bool Async { get; set; }

    }

    public class ShipResponse
    {
        public string Result { get; set; }
        public string NewOrderID { get; set; }
        public string LabelURL { get; set; }
        public IEnumerable<string> PDF { get; set; }
        public IEnumerable<string> ZPL { get; set; }
        public string TrackingCarrier { get; set; }
        public string TrackingNumber { get; set; }
        public string TrackingExternalLink { get; set; }
        public IEnumerable<string> AdditionalTrackingNumbers { get; set; }
        public string Status { get; set; }
    }
}
