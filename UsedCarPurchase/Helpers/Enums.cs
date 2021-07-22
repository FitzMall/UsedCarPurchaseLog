using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsedCarPurchase.Helpers
{
    public class Enums
    {

        public static string[] UCarsPurchaseLog_AllColumns =
        {

            "ID"
            , "stk"
            , "ucp_prestk"
            , "yr"
            , "make"
            , "model"
            , "vin"
            , "color"
            , "mileage"
            , "ucp_purchaseddate"
            , "ucp_purchasedby"
            , "ucp_requesteddate"
            , "ucp_requestedby"
            , "ucp_boughtundercom"
            , "ucp_purchasedfrom"
            , "ucp_purchasedprice"
            , "ucp_pmtcheckno"
            , "ucp_transFee"
            , "ucp_transcredits"
            , "ucp_auctionFee"
            , "ucp_JJFMSmarkup"
            , "ucp_amtduetoJJF"
            , "ucp_storeAssigned"
            , "ucp_checknotoJJF"
            , "ucp_demostock"
            , "ucp_titlestatus"
            , "ucp_comment"
            , "ucp_update"
            , "ucp_users"
            , "ucp_tranfeepaybyck"
            , "ucp_ttlgp"
            , "ucp_sold"
            , "ucp_solddate"
        };

        public static string[] StoreAbbreviations =
        {
            "CDO",
            "CJE",
            "COC",
            "CSS",
            "CHY",
            "LFC",
            "LFH",
            "LFM",
            "LFO",
            "LFT",
            "LFU",
            "FAM",
            "FBS",
            "FBN",
            "FLP",
            "FMM",
            "FOC",
            "FSS",
            "FTN",
            "WDC",
            "FHT",
            "FHG"
        };

        public static string[] PurchasedBy =
        {
            "AJ TUCKER",
            "AMIR KAPLAN",
            "BILL BLUMENFELD",
            "BILL RITTER",
            "BOB KING JR",
            "CATHY SPEECKAERT",
            "CHRIS COLLINS",
            "CODY MOUSE",
            "COREY PARDUE",
            "CORINNA BAKER",
            "DAVID ASCHER",
            "DAVID BANNING",
            "DWAYNE DICKENS",
            "EDWARD RACIS",
            "EMILY MOORE",
            "ERIC ANDERSON",
            "EYAL TOUEG",
            "FELIPE TEIXEIRA",
            "GEORGE SYDNOR",
            "GORDON HATCH",
            "GREG LEWIS",
            "JAKE D'ALESSIO",
            "JAY SHAFER",
            "JEFF SHAVER",
            "JOHN ULSH",
            "JONATHAN AKERS",
            "JORGE SANTIAGO",
            "JUNE BURTON",
            "KEN MCALPINE",
            "KENNY CRESSWELL",
            "KEVIN FLYNN",
            "LANE CAMPBELL",
            "LLOYD MONN",
            "MARC SCHUMACHER",
            "MARLIN HICKS",
            "MATT GROLLER",
            "MINDY WEITZ",
            "PHIL FORMICHELLI",
            "ROB WARD",
            "ROD ECKERT",
            "ROD RITTER",
            "RON PARSONS",
            "ROY DAVES",
            "RYAN SILVER",
            "SCOTT ASCHER",
            "STEVE SMITH",
            "SUE MONTY",
            "TONY HANAGAN",
            "VICTOR BERNALES"
        };

        public static string[] Source =
        {
            "KBB/ICO",
            "Craigslist",
            "Fitz Buys Cars",
            "Rental Co",
            "Lease Buyout",
            "Service Dept",
            "Facebook Marketplace",
            "Body Shop",
            "Auction",
            "Wholesale Dealer",
            "Customer Direct",
            "Nextcar",
            "Trade Outside Deal"
        };
    }


}