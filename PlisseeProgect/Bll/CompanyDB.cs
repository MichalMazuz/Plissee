using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class CompanyDB:GenerlDB
    {
        List<Company> lst = new List<Company>();
        public CompanyDB() : base("tbl_company")
        {

        }
        public void DataTableToList()
        {
            foreach (DataRow dr in table.Rows)
            {
                lst.Add(new Company(dr));
            }
        }
        public List<Company> GetList()
        {
            lst.Clear();
            DataTableToList();
            return lst;
        }
        public void AddNew(Company c)
        {
            c.Dr = table.NewRow();//יצירת שורה חדשה לטבלת לקוח עם עמודות הטבלה ללא נתונים  ושמורה בעצם שורה שבמחלקת לקוח
            c.FillDataRow();//הכנסת הערכים מתכונות העצם לשורה
            this.Add(c.Dr);//שמירה באקסס דרך הפעולות
        }
        public Company Find(int companyCode)
        {
            return GetList().Find(x => x.CompanyCode == companyCode);
        }
        //Update row in the table by the noun
        public void UpDateRow(Company c)
        {
            c.FillDataRow();
            this.Update();
        }

        //Delete row in the table by the key
        public void DeleteRow(int companyCode)
        {
            Company c = this.Find(companyCode);
            this.GetList().Find(x => x.CompanyCode == companyCode);
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
            return this.GetList().Max(x => x.CompanyCode) + 1;
        }

    }
}
