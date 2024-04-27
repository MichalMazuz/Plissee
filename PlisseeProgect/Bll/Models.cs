using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PlisseeProgect.Bll
{
    class Models
    {
        DataRow dr;
        private int productCode;
        private int typeCode;
        private int purchasePrice;
        private int sallingPrice;
        private int companyCode;
        private string status;
        private string typeDescription;
        public Models()
        {

        }
        public Models(DataRow dr)
        {
            this.Dr = dr;
            productCode = Convert.ToInt32(dr["product_code"]);
            CompanyCode = Convert.ToInt32(dr["company_code"]);
            typeCode = Convert.ToInt32(dr["type_code"]);
            purchasePrice = Convert.ToInt32(dr["purchase_price"]);
            sallingPrice = Convert.ToInt32(dr["salling_price"]);
            typeDescription = dr["type_description"].ToString();
            status = dr["status"].ToString();
        }

        public int ProductCode { get => productCode; set => productCode = value; }
        public string TypeDescription { get => typeDescription; set => typeDescription = value; }
        public int TypeCode { get => typeCode; set => typeCode = value; }
        public int PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public int SallingPrice { get => sallingPrice; set => sallingPrice = value; }
        public string Status { get => status; set => status = value; }
        public DataRow Dr { get => dr; set => dr = value; }
        public int CompanyCode { get => companyCode; set => companyCode = value; }
        public void FillDataRow()
        {
            Dr["product_code"] =productCode;
            Dr["type_description"] = typeDescription;
            Dr["type_code"] = typeCode;
            Dr["purchase_price"] = purchasePrice;
            Dr["salling_price"] = sallingPrice;
            Dr["company_code"] = companyCode;
            Dr["status"] = status;
        }
    }
}
