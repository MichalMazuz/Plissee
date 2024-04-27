using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
   public class ProductType
    {
        DataRow dr;
        private int typeCode;
        private string typeDescription;
        public ProductType()
        {

        }
        public ProductType(DataRow dr)
        {
            this.Dr = dr;
            typeCode = Convert.ToInt32(dr["type_code"]);
            TypeDescription = dr["type_description"].ToString();
        }

        public DataRow Dr { get => dr; set => dr = value; }
        public int TypeCode { get => typeCode; set => typeCode = value; }
        public string TypeDescription
        {
            get => typeDescription; set
            {
                if(!Validation.IsHebrew(value))
                    throw new Exception("יש להקיש אותיות בעברית");
                typeDescription = value;
            }
        }

        public void FillDataRow()
        {
            Dr["type_code"] = typeCode;
            Dr["type_description"] = TypeDescription;
        }
        public override string ToString()
        {
            return typeDescription;
        }
    }
}
