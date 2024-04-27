using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class SaleDetailDB:GenerlDB
    {
        List<SaleDetail> lst = new List<SaleDetail>();
        public SaleDetailDB() : base("tbl_sale_detail")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new SaleDetail(dr));
            }
        }
        public List<SaleDetail> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(SaleDetail s)
        {
            s.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            s.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(s.Dr);//שמירה באקסס דרך הפעולות
        }
        public SaleDetail Find(int saleCode,int productCode, int sizeCode, int lengthCode)
        {
            return GetList().Find(x =>x.SaleCode==saleCode&& x.ProductCode == productCode && x.SizeCode == sizeCode && x.LengthCode == lengthCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(SaleDetail c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int saleCode, int productCode, int sizeCode, int lengthCode)
        {
            SaleDetail c = this.Find(saleCode,productCode,sizeCode,lengthCode);
            this.GetList().Find(x => x.SaleCode == saleCode && x.ProductCode == productCode && x.SizeCode == sizeCode && x.LengthCode == lengthCode);
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
            return this.GetList().Max(x => x.SaleCode) + 1;
        }
    }
}
