using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class OrderDetailDB:GenerlDB
    {
        List<OrderDetail> lst = new List<OrderDetail>();
        public OrderDetailDB() : base("tbl_order_detail")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new OrderDetail(dr));
            }
        }
        public List<OrderDetail> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(OrderDetail o)
        {
            o.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            o.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(o.Dr);//שמירה באקסס דרך הפעולות
        }
        public OrderDetail Find(int orderNumber,int productCode,int sizeCode,int lengthCode)
        {
            return GetList().Find(x => x.OrderNumber == orderNumber && x.ProductCode == productCode && x.SizeCode == sizeCode&&x.LengthCode==lengthCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(OrderDetail c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int orderNumber, int productCode, int sizeCode, int lengthCode)
        {
            OrderDetail c = this.Find(orderNumber, productCode,sizeCode,lengthCode);
            this.GetList().Find(x => x.OrderNumber == orderNumber && x.ProductCode == productCode && x.SizeCode == sizeCode && x.LengthCode == lengthCode);
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