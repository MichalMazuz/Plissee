using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class DetailPaymentsDB:GenerlDB
    {
        List<DetailPayments> list = new List<DetailPayments>();
        public DetailPaymentsDB() : base("tbl_detail_payments")
        {

        }

        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new DetailPayments(dr));
            }
        }
        public List<DetailPayments> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public void AddNew(DetailPayments d)
        {
            d.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            d.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(d.Dr);//שמירה באקסס דרך הפעולות
        }
        public DetailPayments Find(int paymentCode,int paymentNumber)
        {
            return GetList().Find(x => x.PaymentCode == paymentCode&&x.PaymentNumber==paymentNumber);
        }
        //Update row in the table by the noun
        public void UpDateRow(DetailPayments c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int paymentCode, int paymentNumber)
        {
            DetailPayments c = this.Find(paymentCode, paymentNumber);
            this.GetList().Find(x => x.PaymentCode == paymentCode && x.PaymentNumber == paymentNumber);
            if (c != null)
            {
                c.Dr.Delete();
                this.Update();
            }
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.PaymentCode) + 1;
        }
    }
}
