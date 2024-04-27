using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class LengthDB:GenerlDB
    {
        List<Length> lst = new List<Length>();
        public LengthDB() : base("tbl_length")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new Length(dr));
            }
        }
        public List<Length> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(Length l)
        {
            l.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            l.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(l.Dr);//שמירה באקסס דרך הפעולות
        }
        public Length Find(int lengthCode)
        {
            return GetList().Find(x => x.LengthCode == lengthCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(Length c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int lengthCode)
        {
            Length c = this.Find(lengthCode);
            this.GetList().Find(x => x.LengthCode == lengthCode);
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
            return this.GetList().Max(x => x.LengthCode) + 1;
        }
      
    }
}
