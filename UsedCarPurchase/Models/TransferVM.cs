using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsedCarPurchase.BizObjects;

namespace UsedCarPurchase.Models
{
    public class TransferVM
    {
        public decimal ID { get; set; }
        public string Stk { get; set; }
        public string Ucp_PreStk { get; set; }
        public string Yr { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Vin { get; set; }
        public string Color { get; set; }
        public string Mileage { get; set; }
        public DateTime? Ucp_PurchasedDate { get; set; }
        public string Ucp_BoughtUnderCom { get; set; }
        public string Ucp_StoreAssigned { get; set; }
        public decimal Ucp_PurchasedPrice { get; set; }
        public string TransporterName { get; set; }
        public decimal Ucp_TransFee { get; set; }
        public string PreviousRental { get; set; }
        public string VehicleLocation { get; set; }
        public string TitleSentTo { get; set; }
        public string Ucp_Comment { get; set; }

        public List<string> StoreList { get; set; }
        public List<string> Purchasers { get; set; }
        public List<PurchaseLogItem> MatchingVehicles { get; set; }

        public static TransferVM Get(int id)
        {
            var transferVm = new TransferVM();
            if (id > 0)
            {
                var viewPurchase = DAL.PurchaseLogHelper.Get(id);

                transferVm.ID = viewPurchase.ID;
                transferVm.Stk = viewPurchase.Stk;
                transferVm.Ucp_PreStk = viewPurchase.Ucp_PreStk;
                transferVm.Yr = viewPurchase.Yr;
                transferVm.Make = viewPurchase.Make;
                transferVm.Model = viewPurchase.Model;
                transferVm.Vin = viewPurchase.Vin;
                transferVm.Color = viewPurchase.Color;
                transferVm.Mileage = viewPurchase.Mileage;
                transferVm.Ucp_PurchasedDate = (DateTime)viewPurchase.Ucp_PurchasedDate;
                transferVm.Ucp_BoughtUnderCom = viewPurchase.Ucp_BoughtUnderCom;
                transferVm.Ucp_StoreAssigned = viewPurchase.Ucp_StoreAssigned;
                transferVm.Ucp_PurchasedPrice = viewPurchase.Ucp_PurchasedPrice;
                transferVm.TransporterName = viewPurchase.Ucp_RequestedBy;
                transferVm.Ucp_TransFee = viewPurchase.Ucp_TransFee;
                transferVm.PreviousRental = viewPurchase.Ucp_Sold;
                transferVm.VehicleLocation = viewPurchase.Ucp_Users;
                transferVm.TitleSentTo = viewPurchase.Ucp_TitleStatus;
                transferVm.Ucp_Comment = viewPurchase.Ucp_Comment;
            }
            return transferVm;
        }

    }
}