using System.Collections;
using System.Collections.Generic;

namespace Claytondus.ShippyPro.Models
{
    public class PutOrder
    {
        public string Method => "PutOrder";
        public PutOrderParams Params { get; set; }
    }

    public class PutOrderParams
    {
        public Address to_address { get; set; }
        public IEnumerable<Parcel> parcels { get; set; }
        public IEnumerable<Item> items { get; set; }
        public string TransactionID { get; set; }
        public long Date { get; set; }
        public string Currency { get; set; }
        public int ItemsCount { get; set; }
        public string ContentDescription { get; set; }
        public decimal Total { get; set; }
        public string Status { get; set; }
        public decimal ShipmentAmountPaid { get; set; }
        public int APIOrdersID { get; set; }
        public string Incoterm { get; set; }
        public string BillAccountNumber { get; set; }
        public string PaymentMethod { get; set; }
        public string ShippingService { get; set; }
        public string Note { get; set; }

    }
}
