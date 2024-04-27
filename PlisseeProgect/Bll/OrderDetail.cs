using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class OrderDetail
    {
        DataRow dr;
        private int orderNumber;
        private int productCode;
        private int sizeCode;
        private int lengthCode;
        private int ordersAmount;
        private int arrivingAmount;
        private double finalPrice;
        private string status;
        public OrderDetail()
        {

        }
        public OrderDetail(DataRow dr)
        {
            this.Dr = dr;
            orderNumber = Convert.ToInt32(dr["order_number"]);
            productCode = Convert.ToInt32(dr["product_code"]);
            sizeCode = Convert.ToInt32(dr["size_code"]);
            lengthCode = Convert.ToInt32(dr["length_code"]);
            ordersAmount = Convert.ToInt32(dr["orders_amount"]);
            arrivingAmount = Convert.ToInt32(dr["arriving_amount"]);
            finalPrice = Convert.ToDouble(dr["final_price"]);
            status= dr["status"].ToString();
        }

        public DataRow Dr { get => dr; set => dr = value; }
        public int OrderNumber { get => orderNumber; set => orderNumber = value; }
        public int ProductCode { get => productCode; set => productCode = value; }
        public int SizeCode { get => sizeCode; set => sizeCode = value; }
        public int LengthCode { get => lengthCode; set => lengthCode = value; }
        public int OrdersAmount { get => ordersAmount; set => ordersAmount = value; }
        public int ArrivingAmount { get => arrivingAmount; set => arrivingAmount = value; }
        public double FinalPrice { get => finalPrice; set => finalPrice = value; }
        public string Status { get => status; set => status = value; }

        public void FillDataRow()
        {
            Dr["order_number"] = orderNumber;
            Dr["product_code"] = productCode;
            Dr["size_code"] = sizeCode;
            Dr["length_code"] = lengthCode;
            Dr["orders_amount"] = ordersAmount;
            Dr["arriving_amount"] = arrivingAmount;
            Dr["final_price"] = finalPrice;
            Dr["status"] = status;
        }
        public SuppliersOrder SuppliersOrderOfDetail()
        {
            SuppliersOrderDB tblSupplierOrder = new SuppliersOrderDB();
            return tblSupplierOrder.Find(orderNumber);
        }
        public ProductSize ProductSizeOfOrderDetail()
        {
            ProductSizeDB tblProductSize = new ProductSizeDB();
            return tblProductSize.Find(productCode, sizeCode, lengthCode);
        }
    }
}
