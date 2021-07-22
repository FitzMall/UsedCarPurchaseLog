using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using UsedCarPurchase.BizObjects;
using UsedCarPurchase.Helpers;
using UsedCarPurchase.Models;

namespace UsedCarPurchase.DAL
{
    public static class PurchaseLogHelper
    {
        public static PurchaseLogItem Get(int id)
        {
            var qs = @"Select * FROM UCarsPurchaseLog WHERE ID = @id";
            return SqlMapperUtil.SqlWithParams<PurchaseLogItem>(qs, new { @id = id }).FirstOrDefault();

        }

        public static List<PurchaseLogItem> SearchByVin(string vin)
        {
            var qs = "SELECT *  FROM UCarsPurchaseLog WHERE vin like '%" + vin + "'";
            return SqlMapperUtil.SqlWithParams<PurchaseLogItem>(qs, null).ToList();
        }
        public static List<PurchaseLogItem> SearchAllColumns(string searchCriteria)
        {
            string qs = @"SELECT
                            ID
                            , stk
                            , ucp_prestk
                            , yr
                            , make
                            , model
                            , vin
                            , color
                            , mileage
                            , ucp_purchaseddate
                            , ucp_purchasedby
                            , ucp_boughtundercom
                            , ucp_purchasedfrom
                            , ucp_purchasedprice
                            , ucp_storeAssigned
                            , ucp_demostock
                            , ucp_comment
                            , ucp_update
                            , ucp_users
                        FROM UCarsPurchaseLog
                        WHERE ";

            qs = qs + GenerateAllColumnsWhereClause(searchCriteria);
            return SqlMapperUtil.SqlWithParams<PurchaseLogItem>(qs, null).ToList();
        }

        private static string GenerateAllColumnsWhereClause(string searchCriteria)
        {
            var whereParts = new StringBuilder();
            for (int i = 0; i < Enums.UCarsPurchaseLog_AllColumns.Length; i++)
            {
                if (i == 0)
                {
                    whereParts.Append(Enums.UCarsPurchaseLog_AllColumns[i] + " LIKE '%" + searchCriteria + "%' ");
                }
                else if (Enums.UCarsPurchaseLog_AllColumns[i].ToUpper() == "UCP_PURCHASEDPRICE")
                {
                    whereParts.Append(" OR CAST(" + Enums.UCarsPurchaseLog_AllColumns[i] + " AS char(20)) LIKE '%" + searchCriteria + "%' ");
                }
                else
                {
                    whereParts.Append("OR " + Enums.UCarsPurchaseLog_AllColumns[i] + " LIKE '%" + searchCriteria + "%' ");
                }
            }
            return whereParts.ToString();
        }

        public static void Save(PurchaseLogItem purchaseLogItem)
        {
            SqlMapperUtil.StoredProcWithParams<int>("usp_upsert_UCarsPurchaseLog", purchaseLogItem);
        }

        public static void UpdateEditItem(EditVM editItem)
        {
            var qs = @"UPDATE UCarsPurchaseLog SET
                        stk = @stk
                        ,ucp_PreStk = @Ucp_PreStk
                        ,Yr = @Yr
                        ,Make = @Make
                        ,Model = @Model
                        ,Vin = @Vin
                        ,Color = @Color
                        ,Mileage = @Mileage
                        ,Ucp_PurchasedDate = @Ucp_PurchasedDate
                        ,Ucp_PurchasedBy = @Ucp_PurchasedBy
                        ,Ucp_BoughtUnderCom = @Ucp_BoughtUnderCom
                        ,Ucp_StoreAssigned = @Ucp_StoreAssigned
                        ,Ucp_PurchasedFrom = @Ucp_PurchasedFrom
                        ,Ucp_PurchasedPrice = @Ucp_PurchasedPrice
                        ,Ucp_TransFee = @Ucp_Transfee
                        ,Ucp_JJFMSMarkup = @Ucp_JJFMSMarkup
                        ,Ucp_Comment = @Ucp_Comment
                    WHERE Id = @ID";
            SqlMapperUtil.SqlWithParams<int>(qs, editItem);
        }

        public static void UpdateTransferItem(TransferVM transferItem)
        {
            var qs = @"UPDATE UCarsPurchaseLog SET
                        stk = @stk
                        ,ucp_PreStk = @Ucp_PreStk
                        ,Yr = @Yr
                        ,Make = @Make
                        ,Model = @Model
                        ,Vin = @Vin
                        ,Color = @Color
                        ,Mileage = @Mileage
                        ,Ucp_PurchasedDate = @Ucp_PurchasedDate
                        ,Ucp_PurchasedBy = @Ucp_PurchasedBy
                        ,Ucp_BoughtUnderCom = @Ucp_BoughtUnderCom
                        ,Ucp_StoreAssigned = @Ucp_StoreAssigned
                        ,Ucp_PurchasedFrom = @Ucp_PurchasedFrom
                        ,Ucp_PurchasedPrice = @Ucp_PurchasedPrice
                        ,Ucp_TransFee = @Ucp_Transfee
                        ,Ucp_JJFMSMarkup = @Ucp_JJFMSMarkup
                        ,Ucp_Comment = @Ucp_Comment
                    WHERE Id = @ID";
            SqlMapperUtil.SqlWithParams<int>(qs, transferItem);
        }

    }
}