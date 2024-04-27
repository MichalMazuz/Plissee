using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    public class SuppliersOrder
    {
        DataRow dr;
        private int orderNumber;
        private int supplierCode;
        private double orderPrice;
        private bool status;
        private DateTime date;
        public SuppliersOrder()
        {

        }
        public SuppliersOrder(DataRow dr)
        {
            this.Dr = dr;
            orderNumber = Convert.ToInt32(dr["order_number"]);
            supplierCode = Convert.ToInt32(dr["supplier_code"]);
            orderPrice =Convert.ToDouble(dr["order_price"]);
            status = Convert.ToBoolean(dr["status"]);
            date = Convert.ToDateTime(dr["order_date"]);
        }

        public DataRow Dr { get => dr; set => dr = value; }
        public int OrderNumber { get => orderNumber; set => orderNumber = value; }
        public int SupplierCode { get => supplierCode; set => supplierCode = value; }
        public double OrderPrice { get => orderPrice; set => orderPrice = value; }
        public bool Status { get => status; set => status = value; }
        public DateTime Date { get => date; set => date = value; }

        public void FillDataRow()
        {
            Dr["order_number"] = orderNumber;
            Dr["supplier_code"] = supplierCode;
            Dr["order_price"] = orderPrice;
            Dr["order_date"] = date;
            Dr["status"] = status;
        }
        public Supplier SupplierOfOrders()
        {
            SupplierDB tblsupplier = new SupplierDB();
            return tblsupplier.Find(supplierCode);
        }
    }
}
