using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    public class Customer
    {
        DataRow dr;
        private string tz;
        private string firstName;
        private string lastName;
        private string phone;
        private string note;
        private int citycode;
        private string status;
        private string mail;

        public string Tz
        {
            get => tz; set
            {
                if (!Validation.CheckId(value))
                    throw new Exception("יש להקיש מספרים");
                tz = value;
            }
        }
        public string FirstName
        {
            get => firstName; set
            {
                if (!Validation.IsHebrew(value))
                    throw new Exception("יש להקיש אותיות בעברית");
                firstName = value;
            }
        }
        public string LastName
        {
            get => lastName; set
            {
                if (!Validation.IsHebrew(value))
                    throw new Exception("יש להקיש אותיות בעברית");
                lastName = value;
            }
        }
        public int Citycode { get => citycode; set => citycode = value; }
        public DataRow Dr { get => dr; set => dr = value; }
        public string Phone
        {
            get => phone; set
            {
                if (!Validation.IsPelepon(value))
                    throw new Exception("יש להקיש מספרים");
                phone = value;
            }
        }
        public string Mail
        {
            get => mail; set
            {
                if (!Validation.IsMail(value))
                    throw new Exception("כתובת המייל אינה תקינה");
                mail = value;
            }
        }
        public string Note { get => note; set => note = value; }
        public string Status { get => status; set => status = value; }

        public Customer()
        {

        }
        public Customer(DataRow dr)
        {
            this.Dr = dr;
            tz = dr["customer_tz"].ToString();
            firstName = dr["first_name"].ToString();
            lastName = dr["last_name"].ToString();
            phone = dr["phone"].ToString();
            note= dr["note1"].ToString();
            citycode =Convert.ToInt32 (dr["city_code"]);
            status= Convert.ToString(dr["status"]);
            Mail = dr["mail"].ToString();
        }
        public void FillDataRow()
        {
            dr["customer_tz"] = tz;
            dr["first_name"] = firstName;
            dr["last_name"] = lastName;
            dr["phone"] = phone;
            dr["note1"] = note;
            dr["city_code"] = citycode;
            dr["status"] = status;
            dr["mail"] = Mail;
        }
        public override string ToString()
        {
            return firstName + " " + lastName;
        }
        public City CityOfC()
        {
            CityDB tblCity = new CityDB();
            return tblCity.Find(citycode);
        }
    }
}
