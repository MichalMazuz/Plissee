using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace PlisseeProgect.Bll
{
    class ProductTypeDB:GenerlDB
    {
        List<ProductType> lst = new List<ProductType>();
        public ProductTypeDB() : base("tbl_product_type")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new ProductType(dr));
            }
        }
        public List<ProductType> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(ProductType p)
        {
            p.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            p.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(p.Dr);//שמירה באקסס דרך הפעולות
        }
        public ProductType Find(int typeCode)
        {
            return GetList().Find(x => x.TypeCode == typeCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(ProductType c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int typeCode)
        {
            ProductType c = this.Find(typeCode);
            this.GetList().Find(x => x.TypeCode == typeCode);
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
            return this.GetList().Max(x => x.TypeCode) + 1;
        }
    }
}
