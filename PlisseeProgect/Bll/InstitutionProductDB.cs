using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class InstitutionProductDB:GenerlDB
    {
        List<InstitutionProduct> lst = new List<InstitutionProduct>();
        public InstitutionProductDB() : base("tbl_institutions_product")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new InstitutionProduct(dr));
            }
        }
        public List<InstitutionProduct> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(InstitutionProduct i)
        {
            i.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            i.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(i.Dr);//שמירה באקסס דרך הפעולות
        }
        public InstitutionProduct Find(int productCode,int institutionCode)
        {
            return GetList().Find(x => x.ProductCode == productCode&&x.InstitutionCode==institutionCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(InstitutionProduct c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int productCode, int institutionCode)
        {
            InstitutionProduct c = this.Find(productCode,institutionCode);
            this.GetList().Find(x => x.ProductCode == productCode && x.InstitutionCode == institutionCode);
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
            return this.GetList().Max(x => x.InstitutionCode) + 1;
        }
    }
}
