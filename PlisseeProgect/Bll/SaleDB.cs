using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace PlisseeProgect.Bll
{
    class SaleDB:GenerlDB
    {
        List<Sale> lst = new List<Sale>();
        public SaleDB() : base("tbl_sale")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new Sale(dr));
            }
        }
        public List<Sale> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(Sale s)
        {
            s.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            s.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(s.Dr);//שמירה באקסס דרך הפעולות
        }
        public Sale Find(int salesCode)
        {
            return GetList().Find(x => x.SalesCode == salesCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(Sale c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int salesCode)
        {
            Sale c = this.Find(salesCode);
            this.GetList().Find(x => x.SalesCode == salesCode);
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
            return this.GetList().Max(x => x.SalesCode) + 1;
        }
    }
}
