using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Orders;

namespace OrderForm
{
    public partial class Form3 : Form
    {
        public Order CurrentOrder { get; set; }
        public string itemName { get; set; }
        public double itemPrice { get; set; }
        public int num { get; set; }
        public OrderDetails Details;
        public Form3(OrderDetails orderDetails, Order order)
        {
            InitializeComponent();
            CurrentOrder = order;
            Details = orderDetails;
            txtItemNum.DataBindings.Add("Text", this, "num");
            txtGoodsName.DataBindings.Add("Text", this, "itemName");
            txtGoodsPrice.DataBindings.Add("Text", this, "itemPrice");
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            Goods goods = new Goods(itemName,itemPrice);
            Details = new OrderDetails(goods, num);
            CurrentOrder.AddOrderDetails(Details);
            this.DialogResult = DialogResult.OK;
        }
    }
}
