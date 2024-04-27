using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PlisseeProgect.Bll
{
    public class Payments
    {
        DataRow dr;
        private int salesCode;
        private int paymentCode;
        private int paymentNumber;
        public Payments()
        {

        }
        public Payments(DataRow dr)
        {
            this.Dr = dr;
            SalesCode = Convert.ToInt32(dr["sales_code"]);
            PaymentCode = Convert.ToInt32(dr["payment_code"]);
            PaymentNumber = Convert.ToInt32(dr["payment_number"]);
        }

        public DataRow Dr { get => dr; set => dr = value; }
        public int SalesCode { get => salesCode; set => salesCode = value; }
        public int PaymentCode { get => paymentCode; set => paymentCode = value; }
        public int PaymentNumber { get => paymentNumber; set => paymentNumber = value; }

        public void FillDataRow()
        {
            Dr["sales_code"] = SalesCode;
            Dr["payment_code"] = PaymentCode;
            Dr["payment_number"] = PaymentNumber;
        }
    }
}
