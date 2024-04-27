using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace PlisseeProgect.Bll
{
    public class ProductModels
    {
        DataRow dr;
        private int productCode;
        private int typeCode;
        private double purchasePrice;
        private double sallingPrice;
        private int companyCode;
        private string status;
        private string productDescription;
        public ProductModels()
        {

        }
        public ProductModels(DataRow dr)
        {
            this.Dr = dr;
            productCode = Convert.ToInt32(dr["product_code"]);
            CompanyCode = Convert.ToInt32(dr["company_code"]);
            typeCode = Convert.ToInt32(dr["type_code"]);
            purchasePrice = Convert.ToDouble(dr["purchase_price"]);
            sallingPrice = Convert.ToDouble(dr["salling_price"]);
            status = dr["status"].ToString();
            ProductDescription = dr["type_product"].ToString();
        }

        public int ProductCode { get => productCode; set => productCode = value; }
        public int TypeCode { get => typeCode; set => typeCode = value; }
        public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public double SallingPrice { get => sallingPrice; set => sallingPrice = value; }
        public string Status { get => status; set => status = value; }
        public DataRow Dr { get => dr; set => dr = value; }
        public int CompanyCode { get => companyCode; set => companyCode = value; }
        public string ProductDescription
        {
            get => productDescription; set
            {
                if(!Validation.IsHebrew(value))
                    throw new Exception("יש להקיש אותיות בעברית");
                productDescription = value;
            }
        }
        public void FillDataRow()
        {
            Dr["product_code"] =productCode;
            Dr["type_code"] = typeCode;
            Dr["purchase_price"] = purchasePrice;
            Dr["salling_price"] = sallingPrice;
            Dr["company_code"] = companyCode;
            Dr["status"] = status;
            Dr["type_product"] = ProductDescription;
        }
        public Company CompanyOfP()
        {
            CompanyDB tblCompany = new CompanyDB();
            return tblCompany.Find(companyCode);
        }
        public ProductType ProductOfModels()
        {
            ProductTypeDB tblProduct = new ProductTypeDB();
            return tblProduct.Find(typeCode);
        }
    }
}
