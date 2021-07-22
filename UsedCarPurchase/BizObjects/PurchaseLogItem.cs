using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedCarPurchase.BizObjects
{
    public class PurchaseLogItem
    {
        public decimal ID { get; set; }

        [StringLength (10, ErrorMessage = "Maximum 10 characters")]
        public string Stk { get; set; }

        [StringLength(10, ErrorMessage = "Maximum 10 characters")]
        public string Ucp_PreStk { get; set; }

        [StringLength(4, ErrorMessage = "Maximum 4 characters")]
        public string Yr { get; set; }

        [StringLength(25, ErrorMessage = "Maximum 25 characters")]
        public string Make { get; set; }

        [StringLength(25, ErrorMessage = "Maximum 25 characters")]
        public string Model { get; set; }

        [StringLength(17, ErrorMessage = "Maximum 17 characters")]
        public string Vin { get; set; }

        [StringLength(20, ErrorMessage = "Maximum 20 characters")]
        public string Color { get; set; }

        [StringLength(10, ErrorMessage = "Maximum 10 characters")]
        public string Mileage { get; set; }

        public DateTime? Ucp_PurchasedDate { get; set; }

        [StringLength(30, ErrorMessage = "Maximum 30 characters")]
        public string Ucp_PurchasedBy { get; set; }

        public DateTime? Ucp_RequestedDate { get; set; }

        [StringLength(35, ErrorMessage = "Maximum 35 characters")]
        public string Ucp_RequestedBy { get; set; }

        [StringLength(50, ErrorMessage = "Maximum 50 characters")]
        public string Ucp_BoughtUnderCom { get; set; }

        [StringLength(35, ErrorMessage = "Maximum 35 characters")]
        public string Ucp_PurchasedFrom { get; set; }

        public decimal Ucp_PurchasedPrice { get; set; }

        [StringLength(10, ErrorMessage = "Maximum 10 characters")]
        public string Ucp_PmtCheckNo { get; set; }

        public decimal Ucp_TransFee { get; set; }

        public decimal Ucp_TransCredits { get; set; }

        [StringLength(10, ErrorMessage = "Maximum 10 characters")]
        public string Ucp_AuctionFee { get; set; }

        [StringLength(10, ErrorMessage = "Maximum 10 characters")]
        public string Ucp_JJFMSmarkup { get; set; }

        [StringLength(10, ErrorMessage = "Maximum 10 characters")]
        public string Ucp_AmtDuetoJJF { get; set; }

        [StringLength(3, ErrorMessage = "Maximum 3 characters")]
        public string Ucp_StoreAssigned { get; set; }

        [StringLength(10, ErrorMessage = "Maximum 10 characters")]
        public string Ucp_CheckNoToJJF { get; set; }

        [StringLength(15, ErrorMessage = "Maximum 15 characters")]
        public string Ucp_DemoStock { get; set; }

        [StringLength(15, ErrorMessage = "Maximum 15 characters")]
        public string Ucp_TitleStatus { get; set; }

        [StringLength(500, ErrorMessage = "Maximum 500 characters")]
        public string Ucp_Comment { get; set; }

        public DateTime? Ucp_Update { get; set; }

        [StringLength(15, ErrorMessage = "Maximum 15 characters")]
        public string Ucp_Users { get; set; }


        [StringLength(10, ErrorMessage = "Maximum 10 characters")]
        public string Ucp_TranFeePayByCk { get; set; }

        public decimal Ucp_ttlgp { get; set; }

        [StringLength(1, ErrorMessage = "Maximum 1 character")]
        public string Ucp_Sold { get; set; }

        public DateTime? Ucp_SoldDate { get; set; }
    }
}