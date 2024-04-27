using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    public class Institution//מוסד
    {
        DataRow dr;
        private int institutionCode;
        private string institutionName;

        public int InstitutionCode { get => institutionCode; set => institutionCode = value; }
        public string InstitutionName
        {
            get => institutionName; set
            {
                if (!Validation.IsHebrew(value))
                    throw new Exception("יש להקיש אותיות בעברית");
                institutionName = value;
            }
        }

        public DataRow Dr { get => dr; set => dr = value; }
        public Institution()
        {

        }
        public Institution(DataRow dr)
        {
            this.Dr = dr;
            institutionCode = Convert.ToInt32(dr["institution_code"]);
            institutionName = dr["institution_name"].ToString();
        }
        public void FillDataRow()
        {
            dr["institution_code"] = institutionCode;
            dr["institution_name"] = institutionName;
        }
        public override string ToString()
        {
            return institutionName;
        }
    }
}
