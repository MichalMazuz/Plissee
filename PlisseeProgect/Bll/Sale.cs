using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class Sale
    {
        DataRow dr;
        private string customerTz;
        private string status;
        private int salesCode;
        private double finalPurchase;
        private DateTime date;
        public Sale()
        {

        }
        public Sale(DataRow dr)
        {
            this.Dr = dr;
            CustomerTz = dr["customer_tz"].ToString();
            Status = dr["status"].ToString();
            SalesCode = Convert.ToInt32(dr["sales_code"]);
            FinalPurchase = Convert.ToDouble(dr["final_purchase"]);
            date = Convert.ToDateTime(dr["sales_date"]);
        }

        public DataRow Dr { get => dr; set => dr = value; }
        public string CustomerTz { get => customerTz; set => customerTz = value; }
        public string Status { get => status; set => status = value; }
        public int SalesCode { get => salesCode; set => salesCode = value; }
        public double FinalPurchase { get => finalPurchase; set => finalPurchase = value; }
        public DateTime Date { get => date; set => date = value; }

        public void FillDataRow()
        {
            Dr["customer_tz"] = CustomerTz;
            Dr["status"] = Status;
            Dr["sales_code"] = SalesCode;
            Dr["final_purchase"] = FinalPurchase;
            Dr["sales_date"] = date;
        }
        public override string ToString()
        {
            return salesCode.ToString();
        }
    }
}
