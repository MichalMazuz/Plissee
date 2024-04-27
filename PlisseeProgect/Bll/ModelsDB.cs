using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class ModelsDB:GenerlDB
    {
        List<Models> lst = new List<Models>();
        public ModelsDB() : base("tbl_models")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new Models(dr));
            }
        }
        public List<Models> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(Models m)
        {
            m.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            m.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(m.Dr);//שמירה באקסס דרך הפעולות
        }
        public Models Find(int typeCode)
        {
            return GetList().Find(x => x.TypeCode == typeCode);
        }
    }
}
