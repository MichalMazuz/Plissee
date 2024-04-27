using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class SizeDB:GenerlDB
    {
        List<Size> lst = new List<Size>();
        public SizeDB() : base("tbl_sizes")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new Size(dr));
            }
        }
        public List<Size> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(Size s)
        {
            s.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            s.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(s.Dr);//שמירה באקסס דרך הפעולות
        }
        public Size Find(int sizeCode)
        {
            return GetList().Find(x => x.SizeCode == sizeCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(Size c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int sizeCod)
        {
            Size c = this.Find(sizeCod);
            this.GetList().Find(x => x.SizeCode == sizeCod);
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
            return this.GetList().Max(x => x.SizeCode) + 1;
        }
    }
}
