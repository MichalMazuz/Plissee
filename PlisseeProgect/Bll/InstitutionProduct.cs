using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
     public class InstitutionProduct//פריט למוסד
    {
        DataRow dr;
        private int productCode;
        private int institutionCode;
        public int ProductCode { get => productCode; set => productCode = value; }
        public int InstitutionCode { get => institutionCode; set => institutionCode = value; }
        public DataRow Dr { get => dr; set => dr = value; }

        public InstitutionProduct()
        {

        }
        public InstitutionProduct(DataRow dr)
        {
            this.Dr = dr;
            productCode = Convert.ToInt32(dr["product_code"]);
            institutionCode = Convert.ToInt32(dr["institution_code"]);
        }
        public void FillDataRow()
        {
            Dr["product_code"] = productCode;
            Dr["institution_code"] = institutionCode;
        }
        public ProductModels ProductModelsOfInstituation()
        {
            ProductModelsDB tblProductModels = new ProductModelsDB();
            return tblProductModels.Find(productCode);
        }
        public Institution InstituationOfInstProduct()
        {
            InstitutionDB tblInstitution = new InstitutionDB();
            return tblInstitution.Find(institutionCode);
        }
    }
}
