using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class SuppliersOrderDB:GenerlDB
    {
        List<SuppliersOrder> lst = new List<SuppliersOrder>();
        public SuppliersOrderDB() : base("tbl_suppliers_order")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new SuppliersOrder(dr));
            }
        }
        public List<SuppliersOrder> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(SuppliersOrder s)
        {
            s.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            s.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(s.Dr);//שמירה באקסס דרך הפעולות
        }
        public SuppliersOrder Find(int orderNumber)
        {
            return GetList().Find(x => x.OrderNumber == orderNumber);
        }
        //Update row in the table by the noun
        public void UpDateRow(SuppliersOrder c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int ordernumber)
        {
            SuppliersOrder c = this.Find(ordernumber);
            this.GetList().Find(x => x.OrderNumber == ordernumber);
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
            return this.GetList().Max(x => x.OrderNumber) + 1;
        }

    }
}
