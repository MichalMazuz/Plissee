using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class SupplierDB:GenerlDB
    {
        List<Supplier> lst = new List<Supplier>();
        public SupplierDB() : base("tbl_suppliers")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new Supplier(dr));
            }
        }
        public List<Supplier> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(Supplier s)
        {
            s.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            s.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(s.Dr);//שמירה באקסס דרך הפעולות
        }
        public Supplier Find(int suppliercode)
        {
            return GetList().Find(x => x.SupplierCode == suppliercode);
        }
        public void DeleteRow(int code)
        {
            Supplier supplier =Find(code);
            if(supplier!=null)
            {
                supplier.Dr.Delete();
                Update();
            }
        }
        //Give the next Kode
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.SupplierCode) + 1;
        }
        //Update row in the table by the noun
        public void UpDateRow(Supplier c)
        {
            c.FillDataRow();
            this.Update();
        }

        

    }
}
