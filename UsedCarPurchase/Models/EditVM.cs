using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsedCarPurchase.BizObjects;
using UsedCarPurchase.DAL;
using UsedCarPurchase.Helpers;

namespace UsedCarPurchase.Models
{
    public class EditVM
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
        public string VehicleLocation { get; set; }
        public string TitleSentTo { get; set; }
        public string BankName { get; set; }
        public decimal PayoffAmount { get; set; }
        public string Ucp_Comment { get; set; }

        public List<string> StoreList { get; set; }
        public List<string> Purchasers { get; set; }

        public void AddStoreToList(string newStore)
        {
            StoreList.Add(newStore);
        }

        public void AddPurchaserToList(string newPurchaser)
        {
            Purchasers.Add(newPurchaser);
        }

        public static void Save(EditVM editVM)
        {
            PurchaseLogItem purchaseLogItem = new PurchaseLogItem();
            purchaseLogItem.ID = editVM.ID;
            purchaseLogItem.Stk = editVM.Stk;
            purchaseLogItem.Yr = editVM.Yr;
            purchaseLogItem.Make = editVM.Make;
            purchaseLogItem.Model = editVM.Model;
            purchaseLogItem.Vin = editVM.Vin;
            purchaseLogItem.Color = editVM.Color;
            purchaseLogItem.Mileage = editVM.Mileage;
            purchaseLogItem.Ucp_Comment = editVM.Ucp_Comment;

            //Missing properties to be saved
            //Vehicle Location
            //Title Sent
            //Bank Name
            //PayoffAmount

            PurchaseLogHelper.Save(purchaseLogItem);

        }

        public static EditVM Get(int id)
        {
            var editVM = new EditVM();
            if (id > 0)
            {
                var viewPurchase = DAL.PurchaseLogHelper.Get(id);

                editVM.ID = viewPurchase.ID;
                editVM.Stk = viewPurchase.Stk;
                editVM.Ucp_PreStk = viewPurchase.Ucp_PreStk;
                editVM.Yr = viewPurchase.Yr;
                editVM.Make = viewPurchase.Make;
                editVM.Model = viewPurchase.Model;
                editVM.Vin = viewPurchase.Vin;
                editVM.Color = viewPurchase.Color;
                editVM.Mileage = viewPurchase.Mileage;
                editVM.Ucp_PurchasedDate = viewPurchase.Ucp_PurchasedDate;
                editVM.Ucp_PurchasedBy = viewPurchase.Ucp_PurchasedBy;
                editVM.Ucp_BoughtUnderCom = viewPurchase.Ucp_BoughtUnderCom;
                editVM.Ucp_StoreAssigned = viewPurchase.Ucp_StoreAssigned;
                editVM.Ucp_PurchasedFrom = viewPurchase.Ucp_PurchasedFrom;
                editVM.Ucp_PurchasedPrice = viewPurchase.Ucp_PurchasedPrice;
                editVM.Source = viewPurchase.Ucp_DemoStock;
                editVM.TransporterName = viewPurchase.Ucp_RequestedBy;
                editVM.Ucp_TransFee = viewPurchase.Ucp_TransFee;
                //editVM.PreviousRental = viewPurchase.PreViousRental;
                editVM.Ucp_JJFMSmarkup = viewPurchase.Ucp_JJFMSmarkup;
                editVM.VehicleLocation = viewPurchase.Ucp_Users;
                editVM.TitleSentTo = viewPurchase.Ucp_TitleStatus;
                editVM.BankName = viewPurchase.Ucp_PmtCheckNo;
                editVM.PayoffAmount = viewPurchase.Ucp_ttlgp;
                editVM.Ucp_Comment = viewPurchase.Ucp_Comment;
            }
            return editVM;

        }

    }
}