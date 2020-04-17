using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPrograms
{
    public class RetailStore
    {
        private int recieptNumber;
        private DateTime dateofPurchase;
        private int customerNumber;
        private string customerName;
        private string Address;
        private int phonenumber;
        private int itemNumber;
        private string itemDescription;
        private double unitPrice;
        private int quantityPurchased;

        public int RecieptNumber
        {
            get
            {
                return recieptNumber;
            }
            set
            {
                if (value > 0)
                    recieptNumber = value;
                else
                    Console.WriteLine("Please provide a valid value" +
                        " reciept Number can not be zero");

            }
        }
        public DateTime DateOfPurchase { get; set; }
        public string CustomerName { get; set; }
        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                if (value > 0)
                    customerNumber = value;
                else
                    Console.WriteLine("Please provide a valid value" +
                        " customer Number can not be zero");

            }
        }
        public int ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                if (value > 0 && value < 9999)
                    itemNumber = value;
                else
                    Console.WriteLine("Please provide a valid Item Number Between 0 - 9999");

            }
        }
        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                if (value > 0 && value < 9999)
                    unitPrice = value;
                else
                    Console.WriteLine("Please provide a valid Unit Price Between 0 - 9999");

            }
        }
        public int QuantityPurchased
        {
            get
            {
                return quantityPurchased;
            }
            set
            {
                if (value > 0)
                    quantityPurchased = value;
                else
                    Console.WriteLine("Please provide a valid value, Quantity Purchase can not be zero");

            }
        }

        public RetailStore(int RecieptNum, DateTime PurchaseDate,string CustName, int CustNumber, int ItemNum,double ItemUnitPrice, int ItemPurchased)
        {
            RecieptNumber = RecieptNum;
            DateOfPurchase = PurchaseDate;
            CustomerName = CustName;
            CustomerNumber = CustNumber;
            ItemNumber = ItemNum;
            UnitPrice = ItemUnitPrice;
            QuantityPurchased = ItemPurchased;
        }

        public double TotalCost()
        {
            return quantityPurchased * unitPrice;
        }

        public override string ToString()
        {
            return "Customer Name: - " + customerName +
                "CustomerName Contact - " + customerNumber +
                "Total Purchase - " + quantityPurchased * unitPrice;
        }

    }
}
