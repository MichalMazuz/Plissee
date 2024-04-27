using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    public class City
    {
        DataRow dr;
        private int cityCode;
        private string nameCity;
        public DataRow Dr { get => dr; set => dr = value; }
        public int CityCode { get => cityCode; set => cityCode = value; }
        public string NameCity
        {
            get => nameCity; set
            {
                if (!Validation.IsHebrew(value))
                    throw new Exception("יש להקיש אותיות בעברית");
                nameCity = value;
            }
        }
        public City()
        {

        }
        public City(DataRow dr)
        {
            this.Dr = dr;
            cityCode = Convert.ToInt32(dr["city_code"]);
            NameCity = dr["city_name"].ToString();
        }
        public void FillDataRow()
        {
            dr["city_code"] = cityCode;
            dr["city_name"] = nameCity;
        }
        public override string ToString()
        {
            return nameCity;
        }
    }
   
}
