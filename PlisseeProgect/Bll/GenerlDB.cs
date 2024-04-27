using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class GenerlDB
    {
        protected DataTable table;
        public GenerlDB(string NameTable)
        {
            table = Dal.Dal.GetInstance()./*כתובת הגישה לאקס*/GetTable(NameTable)/*בודק האם הטבלה עם השם המתבקש קיימת אצלו כבר משאילתות קודמות.אחרת מבקש אותה מהאקסס ןשומר בטייבל*/;
        }
        public void Update()
        {
            Dal.Dal.GetInstance().Update(table.TableName);
        }

        public void Add(DataRow dr)//מקבל את השורה החדשה
        {
            table.Rows.Add(dr);// מוסיף את השורוה לעצם מסוג דטהטבל המכיל את טבלת לקוחות
            this.Save();//מפעיל את הפעולה שמבצעת את השמירה באקסס
        }
        public virtual void Save()//שמירה סופית באקסס
        {
            Dal.Dal.GetInstance().Update(table.TableName);
        }
        public int Size()
        {
            return table.Rows.Count;
        }
        
    }
}
