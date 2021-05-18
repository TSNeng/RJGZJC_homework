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
    public partial class Form2 : Form
    {
        public OrderService orderService { get; set; }
        public Order CurrentOrder { get; set; }
        public string address { get; set; }
        public string receiver { get; set; }
        public string Sender { get; set; }
        public string id { get; set; }

        public Form2(Order order, OrderService orderService)
        {
            InitializeComponent();
            
            txtAddress.DataBindings.Add("Text", this, "address");
            txtId.DataBindings.Add("Text", this, "id");
            txtSender.DataBindings.Add("Text", this, "Sender");
            cbxReceiver.DataBindings.Add("SelectedItem", this, "receiver");
            CurrentOrder = order;
            this.orderService = orderService;
            bdsOrderDetails.DataSource = CurrentOrder.orderDetails;
        }

       

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(receiver);
            CurrentOrder = new Order(customer, Sender, address, id);
            orderService.AddOrder(CurrentOrder);
            this.DialogResult = DialogResult.OK;
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(new OrderDetails(), CurrentOrder);
            //form3.ShowDialog();
            if (form3.ShowDialog() == DialogResult.OK)
            {
                CurrentOrder = form3.CurrentOrder;
                form3.Close();
            }
            bdsOrderDetails.DataSource = CurrentOrder.orderDetails;
            bdsOrderDetails.ResetBindings(true);
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = bdsOrderDetails.Current as OrderDetails;
            if (orderDetails == null)
            {
                MessageBox.Show("请选择一个订单明细进行删除");
                return;
            }
            CurrentOrder.RemoveDetails(orderDetails);
            bdsOrderDetails.DataSource = CurrentOrder.orderDetails;
            bdsOrderDetails.ResetBindings(true);
        }
    }
}
