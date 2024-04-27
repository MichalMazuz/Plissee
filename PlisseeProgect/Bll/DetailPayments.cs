using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    public class DetailPayments//פרוט תשלום
    {
        DataRow dr;
        private int paymentCode;//קוד תשלום
        private int paymentNumber;//מספר תשלומים
        private string creditNumber;//מס אשראי
        private string creditCw;//3 ספרות בגב הכרטיס 
        private string chequeNumber;//מספר המחאה
        private string branchNumber;//מספר סניף
        private string paymentWay;//אופן התשלום
        private string customerTz;//מס זהות של הלקוח
        private string bankNumber;//מספר בנק
        private string userAccount;//מספר חשבון
        private DateTime creditForce;//תוקף הכרטיס
        private int salesCode;

        public DataRow Dr { get => dr; set => dr = value; }
        public int PaymentCode { get => paymentCode; set => paymentCode = value; }
        public int PaymentNumber { get => paymentNumber; set => paymentNumber = value; }
        public string CreditNumber { get => creditNumber; set => creditNumber = value; }
        public string CreditCw { get => creditCw; set => creditCw = value; }
        public string ChequeNumber { get => chequeNumber; set => chequeNumber = value; }
        public string BranchNumber { get => branchNumber; set => branchNumber = value; }
        public string PaymentWay { get => paymentWay; set => paymentWay = value; }
        public string CustomerTz { get => customerTz; set => customerTz = value; }
        public int SalesCode { get => salesCode; set => salesCode = value; }
        public string BankNumber { get => bankNumber; set => bankNumber = value; }
        public string UserAccount { get => userAccount; set => userAccount = value; }
        public DateTime CreditForce { get => creditForce; set => creditForce = value; }

        public DetailPayments()
        {

        }
        public DetailPayments(DataRow dr)
        {
            this.Dr = dr;
            PaymentCode = Convert.ToInt32(dr["payment_code"]);
            PaymentNumber = Convert.ToInt32(dr["payment_number"]);
            CreditNumber = dr["credit_number"].ToString();
            CreditCw = dr["credit_cw"].ToString();
            ChequeNumber = dr["cheque_number"].ToString();
            BranchNumber = dr["branch_number"].ToString();
            PaymentWay = dr["payment_way"].ToString();
            CustomerTz = dr["customer_tz"].ToString();
            BankNumber = dr["bank_number"].ToString();
            UserAccount = dr["user_account"].ToString();
            creditForce = Convert.ToDateTime(dr["credit_force"]);
            SalesCode = Convert.ToInt32(dr["sales_code"]);
        }
        public void FillDataRow()
        {
            dr["payment_code"] = PaymentCode;
            dr["payment_number"] = PaymentNumber;
            dr["credit_number"] = CreditNumber;
            dr["credit_cw"] = CreditCw;
            dr["cheque_number"] = ChequeNumber;
            dr["branch_number"] = BranchNumber;
            dr["payment_way"] = PaymentWay;
            dr["customer_tz"] = CustomerTz;
            dr["bank_number"] = BankNumber;
            dr["user_account"] = UserAccount;
            dr["credit_force"] = creditForce;
            Dr["sales_code"] = SalesCode;
        }
        public Payments PaymentOfDrtail()
        {
            PaymentsDB tblPayments = new PaymentsDB();
            return tblPayments.Find(paymentCode);
        }
    }
}
