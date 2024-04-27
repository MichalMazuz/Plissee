using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class ProductModelsDB:GenerlDB
    {
        List<ProductModels> lst = new List<ProductModels>();
        public ProductModelsDB() : base("tbl_products_models")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new ProductModels(dr));
            }
        }
        public List<ProductModels> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(ProductModels m)
        {
            m.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            m.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(m.Dr);//שמירה באקסס דרך הפעולות
        }
        public ProductModels Find(int pCode)
        {
            return GetList().Find(x => x.ProductCode == pCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(ProductModels c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int typeCode)
        {
            ProductModels c = this.Find(typeCode);
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
            return this.GetList().Max(x => x.ProductCode) + 1;
        }
    }
}
