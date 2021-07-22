using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsedCarPurchase.Models
{
    public class PurchaseVM
    {
        public decimal ID { get; set; }
        public string Stk { get; set; }
        public string Yr { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Vin { get; set; }
        public string Color { get; set; }
        public string Mileage { get; set; }
        public DateTime? Ucp_PurchasedDate { get; set; }
        public string Ucp_PurchasedBy { get; set; }
        public string Ucp_BoughtUnderCom { get; set; }
        public string Ucp_StoreAssigned { get; set; }
        public string Ucp_PurchasedFrom { get; set; }
        public decimal Ucp_PurchasedPrice { get; set; }
        public string Source { get; set; }
        public string TransporterName { get; set; }
        public decimal Ucp_TransFee { get; set; }
        public bool PreviousRental { get; set; }
        public string Ucp_JJFMSmarkup { get; set; }
        public string BankName { get; set; }
        public decimal PayoffAmount { get; set; }
        public string Ucp_Comment { get; set; }

        public List<string> StoreList { get; set; }
        public List<string> Purchasers { get; set; }
    }
}