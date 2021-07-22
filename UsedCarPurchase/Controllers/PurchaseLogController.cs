using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsedCarPurchase.BizObjects;
using UsedCarPurchase.DAL;
using UsedCarPurchase.Helpers;
using UsedCarPurchase.Models;

namespace UsedCarPurchase.Controllers
{
    public class PurchaseLogController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(string searchString)
        {
            var searchResults = PurchaseLogHelper.SearchAllColumns(searchString);
            return View(searchResults);
        }

        public ActionResult Transfer(int? id)
        {
            ViewBag.Message = "";
            var transferVM = PopulateTransferViewModel(id);
            return View(transferVM);
        }


        [HttpPost]
        public ActionResult Transfer(string submit, string vin, TransferVM transferVM)
        {
            ViewBag.Message = "";
            ModelState.Clear();

            var newTransferVM = new TransferVM();
            newTransferVM.StoreList = new List<string>();
            newTransferVM.StoreList.AddRange(Enums.StoreAbbreviations);

            newTransferVM.Purchasers = new List<string>();
            newTransferVM.Purchasers.AddRange(Enums.PurchasedBy);

            if (!String.IsNullOrEmpty(submit))
            {
                if (submit.ToUpper() == "SAVE")
                {
                    
                }
                else
                {
                    if (!String.IsNullOrEmpty(vin))
                    {
                        var matchingVehicles = PurchaseLogHelper.SearchByVin(vin);
                        if (matchingVehicles != null && matchingVehicles.Count > 0)
                        {
                            if (matchingVehicles.Count == 1)
                            {
                                var newtransferVM = PopulateTransferViewModel((Int32)matchingVehicles[0].ID);
                                return View(newtransferVM);

                            }
                            else
                            {
                                newTransferVM.MatchingVehicles = matchingVehicles;
                            }
                            return View(newTransferVM);
                        }
                        else
                        {
                            ViewBag.Message = "No vehicles found";
                        }
                    }
                }
            }
            //else if (id != null && id > 0)
            //{
            //    //populate form with match
            //}
            else if (transferVM != null)
            {
                return View(newTransferVM);
            }

            return View();
        }

        public ActionResult Purchase(int? id)
        {
            var purchaseVM = new PurchaseVM();

            purchaseVM.Ucp_PurchasedDate = DateTime.Now;

            purchaseVM.Purchasers = new List<string>();
            purchaseVM.Purchasers.AddRange(Enums.PurchasedBy);

            purchaseVM.StoreList = new List<string>();
            purchaseVM.StoreList.AddRange(Enums.StoreAbbreviations);


            return View(purchaseVM);
        }

        [HttpPost]
        public ActionResult Purchase(PurchaseVM purchaseVM)
        {
            return View();
        }

        public ActionResult Edit(int? id)
        {
            EditVM editVM;
            if (id != null && id.Value > 0)
            {
                editVM = EditVM.Get(id.Value);
            }
            else
            {
                editVM = EditVM.Get(0);
            }
            editVM.Purchasers = new List<string>();
            editVM.Purchasers.AddRange(Enums.PurchasedBy);
            if (!editVM.Purchasers.Contains(editVM.Ucp_PurchasedBy))
            {
                editVM.Purchasers.Add(editVM.Ucp_PurchasedBy);
            }

            editVM.StoreList = new List<string>();
            editVM.StoreList.AddRange(Enums.StoreAbbreviations);

            if (!editVM.StoreList.Contains(editVM.Ucp_BoughtUnderCom))
                editVM.AddStoreToList(editVM.Ucp_BoughtUnderCom);

            if (!editVM.StoreList.Contains(editVM.Ucp_StoreAssigned))
                editVM.StoreList.Add(editVM.Ucp_StoreAssigned);

            if (!editVM.StoreList.Contains(editVM.TitleSentTo))
                editVM.StoreList.Add(editVM.TitleSentTo);

            return View(editVM);
        }

        [HttpPost]
        public ActionResult Edit(EditVM editItem)
        {
            PurchaseLogHelper.UpdateEditItem(editItem);
            return View("Index");
        }

        private object PopulateTransferViewModel(int? id)
        {
            TransferVM transferVm;
            if (id != null && id > 0)
                transferVm = TransferVM.Get(id.Value);
            else
                transferVm = TransferVM.Get(0);


            if (transferVm.Ucp_PurchasedDate == null)
            {
                transferVm.Ucp_PurchasedDate = DateTime.Now;
            }

            transferVm.Purchasers = new List<string>();

            transferVm.StoreList = new List<string>();
            transferVm.StoreList.AddRange(Enums.StoreAbbreviations);


            if (!transferVm.StoreList.Contains(transferVm.Ucp_StoreAssigned))
                transferVm.StoreList.Add(transferVm.Ucp_StoreAssigned);

            if (!transferVm.StoreList.Contains(transferVm.TitleSentTo))
                transferVm.StoreList.Add(transferVm.TitleSentTo);

            transferVm.MatchingVehicles = new List<PurchaseLogItem>();

            return transferVm;
        }
    }
}