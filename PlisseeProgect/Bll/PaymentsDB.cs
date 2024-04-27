using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class PaymentsDB:GenerlDB
    {
        List<Payments> lst = new List<Payments>();
        public PaymentsDB() : base("tbl_payments")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new Payments(dr));
            }
        }
        public List<Payments> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(Payments m)
        {
            m.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            m.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(m.Dr);//שמירה באקסס דרך הפעולות
        }
        public Payments Find(int paymentCode)
        {
            return GetList().Find(x => x.PaymentCode == paymentCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(Payments c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int paymentCode)
        {
            Payments c = this.Find(paymentCode);
            this.GetList().Find(x => x.PaymentCode == paymentCode);
            if (c != null)
            {
                c.Dr.Delete();
                this.Update();
            }
        }

        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.PaymentCode) + 1;
        }
    }
}
