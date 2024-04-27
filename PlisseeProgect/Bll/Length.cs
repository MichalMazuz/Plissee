using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    public class Length
    {
        DataRow dr;
        private int lengthCode;
        private int lengthNum;
        public Length()
        {

        }
        public Length(DataRow dr)
        {
            this.Dr = dr;
            lengthCode = Convert.ToInt32(dr["length_code"]);
            lengthNum = Convert.ToInt32(dr["length_num"]);
        }

        public int LengthCode { get => lengthCode; set => lengthCode = value; }
        public int LengthNum { get => lengthNum; set => lengthNum = value; }
        public DataRow Dr { get => dr; set => dr = value; }

        public void FillDataRow()
        {
            Dr["length_code"] = lengthCode;
            Dr["length_num"] = lengthNum;
        }
        public override string ToString()
        {
            return lengthNum.ToString();
        }
    }
}
