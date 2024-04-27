using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class Street
    {
        DataRow dr;
        private int streetCode;
        private string streetName;
        public Street()
        {

        }
        public Street(DataRow dr)
        {
            this.Dr = dr;
            streetCode = Convert.ToInt32(dr["street_code"]);
            streetName = dr["street_name"].ToString();
        }

        public DataRow Dr { get => dr; set => dr = value; }
        public int StreetCode { get => streetCode; set => streetCode = value; }
        public string StreetName { get => streetName; set => streetName = value; }

        public void FillDataRow()
        {
            Dr["street_code"] = streetCode;
            Dr["street_name"] = streetName;
        }
        public override string ToString()
        {
            return streetName;
        }
    }
}
