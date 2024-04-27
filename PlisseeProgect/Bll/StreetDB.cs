using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class StreetDB:GenerlDB
    {
        List<Street> lst = new List<Street>();
        public StreetDB() : base("tbl_street")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new Street(dr));
            }
        }
        public List<Street> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(Street s)
        {
            s.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            s.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(s.Dr);//שמירה באקסס דרך הפעולות
        }
        public Street Find(int streetCode)
        {
            return GetList().Find(x => x.StreetCode == streetCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(Street c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int streetCode)
        {
            Street c = this.Find(streetCode);
            this.GetList().Find(x => x.StreetCode == streetCode);
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
            return this.GetList().Max(x => x.StreetCode) + 1;
        }
    }
}
