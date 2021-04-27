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
    public partial class Form1 : Form
    {
        public OrderService orderService;
        public Action<Form2> ShowForm2 { get; set; }
        public String Keyword { get; set; }

        public Form1()
        {
            InitializeComponent();
            orderService = new OrderService();
            Goods goods = new Goods("apple", 3.5);
            Goods goods2 = new Goods("banana", 6.8);
            Goods goods3 = new Goods("orange", 3);
            Customer customer1 = new Customer("wang");
            Customer customer2 = new Customer("Li");
            OrderDetails orderDetails = new OrderDetails(goods, 3);
            OrderDetails orderDetails2 = new OrderDetails(goods2, 2);
            Order order = new Order(customer1, "Li", "wuhan", "1");
            Order order2 = new Order(customer2, "hu", "WHU", "2");

            order.AddOrderDetails(orderDetails);
            order2.AddOrderDetails(orderDetails2);

            orderService.AddOrder(order);
            orderService.AddOrder(order2);
            bdsOrderlist.DataSource = orderService.orders;
            txtLookUp.DataBindings.Add("Text", this, "Keyword");
            cbxLookUp.SelectedIndex = 0;
        }


        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnLookUp_Click(object sender, EventArgs e)
        {
            switch (cbxLookUp.SelectedIndex)
            {
                case 0://根据ID查询  
                    bdsOrderlist.DataSource = orderService.LookUpOrderById(Keyword);
                    break;
                case 1://根据总金额查询
                    double.TryParse(Keyword, out double result);
                    bdsOrderlist.DataSource = orderService.LookUpOrderBySumCost(result);
                    break;
                case 2://根据地点查询
                    bdsOrderlist.DataSource = orderService.LookUpOrderByItemName(Keyword);
                    break;
            }
            bdsOrderlist.ResetBindings(true);
        }

        private void btnShowAllOrders_Click(object sender, EventArgs e)
        {
            bdsOrderlist.DataSource = orderService.orders;
            bdsOrderlist.ResetBindings(true);
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(new Order(), orderService);
            form2.ShowDialog();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                orderService = form2.orderService;
                form2.Close();
            }
            bdsOrderlist.DataSource = orderService.orders;
            bdsOrderlist.ResetBindings(true);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                orderService.Export(fileName);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                orderService.Import(fileName);
                bdsOrderlist.DataSource = orderService.orders;
                bdsOrderlist.ResetBindings(true);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            Order order = bdsOrderlist.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行删除");
                return;
            }
            orderService.RemoveOrder(order.id);
            bdsOrderlist.DataSource = orderService.orders;
            bdsOrderlist.ResetBindings(true);
        }

        private void btnChangeOrder_Click(object sender, EventArgs e)
        {
            Order order = bdsOrderlist.Current as Order;
            if (order == null)
            {
                MessageBox.Show("请选择一个订单进行修改");
                return;
            }
            orderService.RemoveOrder(order.id);
            Form2 form2 = new Form2(order, orderService);
            form2.ShowDialog();
            bdsOrderlist.DataSource = orderService.orders;
            bdsOrderlist.ResetBindings(true);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
