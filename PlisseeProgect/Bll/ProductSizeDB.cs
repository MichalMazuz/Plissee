using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class ProductSizeDB:GenerlDB
    {
        List<ProductSize> lst = new List<ProductSize>();
        public ProductSizeDB() : base("tbl_products_sizes")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new ProductSize(dr));
            }
        }
        public List<ProductSize> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(ProductSize p)
        {
            p.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            p.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(p.Dr);//שמירה באקסס דרך הפעולות
        }
        public ProductSize Find(int productCode,int sizeCode,int lengthCode)
        {
            return GetList().Find(x => x.ProductCode == productCode&&x.SizeCode== sizeCode&&x.LengthCode== lengthCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(ProductSize c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int productCode, int sizeCode, int lengthCode)
        {
            ProductSize c = this.Find(productCode, sizeCode,lengthCode);
            this.GetList().Find(x => x.ProductCode == productCode && x.SizeCode == sizeCode && x.LengthCode == lengthCode);
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
