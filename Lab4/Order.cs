using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Order
    {
        // Fields
        private int orderID;
        private string name;
        private bool delivery;
        private decimal amount;
        private static int nextID = 500;

        //properties
        public int OrderID {
            get { return orderID; }
            set { orderID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Delivery
        {
            get {return delivery; }
            set { delivery = value; }
        }

        public decimal Amount
        {
            get { return amount; }
            set { 
                if (Amount < 0) { 
                    amount = 0m;
                }
                amount = value;
            }
        }

        // Methods
        public Order()
        {
            SetID();
            delivery = true;
            amount = 159.99m;
        }

        public Order(string Name, bool deliver, decimal amount)
        {
            orderID = SetID();
            name = Name;
            delivery = deliver;
            amount = Amount;
        }

        private int SetID()
        {
            orderID = nextID;
            nextID = nextID + 10;
            return orderID; 
        }

        public string DisplayData()
        {
            string deliveryStatus = "N";
            if (delivery == true) deliveryStatus = "Y";
            string orderFormat = String.Format("{0,-3}{1,-25}{2,1}{3,8}",orderID.ToString() + "\t", name, deliveryStatus, amount.ToString("c"));

            return orderFormat;
        }
    }
}
