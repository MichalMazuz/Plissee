using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class CustomerDB:GenerlDB
    {
        List<Customer> list = new List<Customer>();
        public CustomerDB() : base("tbl_customers")
        {

        }

        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                list.Add(new Customer(dr));
            }
        }
        public List<Customer> GetList()
        {
            list.Clear();
            DataTableToList();
            return list;
        }
        public void AddNew(Customer c)
        {
            c.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            c.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(c.Dr);//שמירה באקסס דרך הפעולות
        }
        public Customer Find(string tz)
        {
            return GetList().Find(x => x.Tz == tz);
        }
        //Update row in the table by the noun
        public void UpDateRow(Customer c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(string tz)
        {
            Customer c = this.Find(tz);
            this.GetList().Find(x => x.Tz == tz);
            if (c != null)
            {
                c.Dr.Delete();
                this.Update();
            }
        }

        //Give the next Kode
        public string GetNextKey()
        {
            if (this.Size() == 0)
                return "1";
            return this.GetList().Max(x => x.Tz) + 1;
        }
    }
}
