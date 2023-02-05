using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        // List: Orders - Class Level
        List<Order> orders = new List<Order>();

        private void OrderForm_Load(object sender, EventArgs e)
        {
            Order defaultOrder = new Order()
            {
                Name = "Noah Rogers"
            };
            orders.Add(defaultOrder);

            string student = "Michael McDonald";
            bool deliver = false;
            decimal amount = -10m;

            Order order2 = new Order(student, deliver, amount);
            orders.Add(order2);

            DisplayList();
        }

        private void DisplayList()
        {
            lstOrders.Items.Clear();

            foreach (Order order in orders)
            {
                lstOrders.Items.Add(order.DisplayData());
            }
        }
    }
}
