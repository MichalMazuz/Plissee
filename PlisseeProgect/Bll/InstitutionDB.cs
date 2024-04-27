using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class InstitutionDB:GenerlDB
    {
        List<Institution> list = new List<Institution>();
        public InstitutionDB() : base("tbl_instituation")
        {

        }

        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Institution(dr));
            }
        }
        public List<Institution> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public void AddNew(Institution i)
        {
            i.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            i.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(i.Dr);//שמירה באקסס דרך הפעולות
        }
        public Institution Find(int institutionCode)
        {
            return GetList().Find(x => x.InstitutionCode == institutionCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(Institution c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int institutionCode)
        {
            Institution c = this.Find(institutionCode);
            this.GetList().Find(x => x.InstitutionCode == institutionCode);
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
