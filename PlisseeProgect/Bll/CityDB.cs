using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class CityDB:GenerlDB
    { 
        List<City> lst = new List<City>();
        public CityDB() : base("tbl_city")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new City(dr));
            }
        }
        public List<City> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(City c)
        {
            c.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            c.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(c.Dr);//שמירה באקסס דרך הפעולות
        }
        public City Find(int codeC)
        {
            return GetList().Find(x => x.CityCode == codeC);
        }
        //Update row in the table by the noun
        public void UpDateRow(City c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int cityCode)
        {
            City c = this.Find(cityCode);
            this.GetList().Find(x => x.CityCode == cityCode);
            if (c != null)
            {
                c.Dr.Delete();
                this.Update();
            }
        }
        public int GetNextKey()
        {
            if (this.Size() == 0)
                return 1;
            return this.GetList().Max(x => x.CityCode) + 1;
        }
    }
}

