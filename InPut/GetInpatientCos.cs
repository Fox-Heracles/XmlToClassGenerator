
                using System;
                using System.Collections.Generic;
                using System.ComponentModel;
                using System.Data;
                using System.Drawing;
                using System.Linq;
                using System.Text;
                using System.Windows.Forms;
                using System.Xml;
                
                namespace WeChat.Models.InPut
                {
                   public class res
                    {
                        public string resultCode {get;set;}
            public string resultDesc {get;set;}
            public costContent _costContent =new costContent();
            public class costContent
                    {
                        public string name {get;set;}
            public string gender {get;set;}
            public string inpatientNo {get;set;}
            public string birthday {get;set;}
            public string address {get;set;}
            public string phone {get;set;}
            public string bedNo {get;set;}
            public string deptName {get;set;}
            public string infPatchName {get;set;}
            public string totalMoney {get;set;}
            public string inAdvanceMoney {get;set;}
            public string inDate {get;set;}
            public string outDate {get;set;}
            public string feeType {get;set;}
            public string idenNo {get;set;}
            public List<costTotalInfo> costTotalList=new List<costTotalInfo>();
            public class costTotalInfo
                    {
                        public string itemType {get;set;}
            public string itemTypeName {get;set;}
            public string itemMoney {get;set;}
            public List<costItemInfo> costItemList=new List<costItemInfo>();
            public class costItemInfo
                    {
                        public string itemQuantity {get;set;}
            public string itemName {get;set;}
            public string itemUnit {get;set;}
            public string itemSpec {get;set;}
            public string itemPrice {get;set;}
            public string itemMoney {get;set;}
            public string productPlace {get;set;}
            
                    } 
                    } 
                    } 
                    } 
                    
                }