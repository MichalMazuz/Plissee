using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    public class Supplier
    {
        DataRow dr;
        private string supplierName;
        private string phone;
        private string note1;
        private string mail;
        private int citycode;
        private int supplierCode;
        private string status;
        public Supplier()
        {

        }
        public Supplier(DataRow dr)
        {
            this.Dr = dr;
            Status = dr["status"].ToString();
            SupplierCode = Convert.ToInt32(dr["supplier_code"]);
            Citycode = Convert.ToInt32(dr["city_code"]);
            SupplierName = dr["supplier_name"].ToString();
            Phone = dr["phone"].ToString();
            Note1 = dr["note1"].ToString();
            Mail = dr["mail"].ToString();
           
        }
        
        public DataRow Dr { get => dr; set => dr = value; }
       
        public string SupplierName { get => supplierName; set 
        {
                if (!Validation.IsHebrew(value))
                    throw new Exception("יש להקיש אותיות בעברית");
                supplierName = value;
            }
        }
        public string Phone
        {
            get => phone; set
            {
                if (!Validation.IsPelepon(value))
                    throw new Exception("יש להקיש מספרים");
                phone = value;
            }
        }
        public string Note1 { get => note1; set => note1 = value; }
        public int Citycode { get => citycode; set => citycode = value; }
        public string Status { get => status; set => status = value; }
        public string Mail
        {
            get => mail; set
            {
                if (!Validation.IsMail(value))
                    throw new Exception("כתובת המייל אינה תקינה");
                mail = value;
            }
        }
        public int SupplierCode { get => supplierCode; set => supplierCode = value; }

        public void FillDataRow()
        {
            Dr["supplier_code"] = SupplierCode;
            Dr["supplier_name"] = SupplierName;
            Dr["phone"] = Phone;
            Dr["note1"] = Note1;
            Dr["city_code"] = Citycode;
            Dr["status"] = Status;
            Dr["mail"] = Mail;
        }
       
        public override string ToString()
        {
            return SupplierName;
        }
        public City  CityOfSupplier()
        {
            CityDB tblCity = new CityDB();
            return tblCity.Find(citycode);
        }
    }
}
