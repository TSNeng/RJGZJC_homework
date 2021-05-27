using System;
using System.Collections.Generic;
using System.Text;

namespace OrderApi
{
    [Serializable]
    public class OrderDetails
    {
        public OrderDetails()
        {
        }

        public OrderDetails(OrderDetails od)
            : this(od.ProductName, od.ProductNumber)
        {
        }

        public OrderDetails(string productName, int productNumber)
        {
            ProductName = productName;
            ProductNumber = productNumber;
        }

        public int Id { get; set; }

        public int OrderId { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// 产品数量
        /// </summary>
        public int ProductNumber { get; set; }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   ProductName == details.ProductName &&
                   ProductNumber == details.ProductNumber;
        }

        public override int GetHashCode()
        {
            int hashCode = 699931452;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProductName);
            hashCode = hashCode * -1521134295 + ProductNumber.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"商品名称：{ProductName} 商品数量：{ProductNumber}";
        }


    }
}
