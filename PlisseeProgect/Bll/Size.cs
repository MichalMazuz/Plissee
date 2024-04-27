using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    public class Size
    {
        DataRow dr;
        private int sizeCode;
        private string description;
        public Size()
        {

        }
        public Size(DataRow dr)
        {
            this.Dr = dr;
            sizeCode = Convert.ToInt32(dr["size_code"]);
            description = dr["description"].ToString();
        }

        public DataRow Dr { get => dr; set => dr = value; }
        public int SizeCode { get => sizeCode; set => sizeCode = value; }
        public string Description
        {
            get => description; set
            {
                if (!Validation.IsNum(value))
                    throw new Exception("יש להקיש מספרים");
                description = value;
            }
        }

        public void FillDataRow()
        {
            Dr["size_code"] = sizeCode;
            Dr["description"] = description;
        }
        public override string ToString()
        {
            return description;
        }
    }
}
