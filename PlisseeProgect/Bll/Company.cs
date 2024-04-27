using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace PlisseeProgect.Bll
{
    public class Company
    {
        DataRow dr;
        private string companyName;
        private int companyCode;
        private int supplierCode;

        public string CompanyName
        {
            get => companyName; set
            {
                if (!Validation.IsEnglish1(value))
                    throw new Exception("יש להקיש אותיות באנגלית");
                companyName = value;
            }
        }
        public int CompanyCode { get => companyCode; set => companyCode = value; }
        public int SupplierCode { get => supplierCode; set => supplierCode = value; }
        public DataRow Dr { get => dr; set => dr = value; }

        public Company()
        {

        }
        public Company(DataRow dr)
        {
            this.Dr = dr;
            companyCode = Convert.ToInt32(dr["company_code"]);
            supplierCode = Convert.ToInt32(dr["supplier_code"]);
            companyName = dr["company_name"].ToString();
        }
        public void FillDataRow()
        {
            dr["company_code"]=companyCode;
            dr["company_name"] = companyName;
            dr["supplier_code"] = supplierCode;
        }
        public override string ToString()
        {
            return companyName;
        }
        public Supplier SupplierOfCompany()
        {
            SupplierDB tblSupplier = new SupplierDB();
            return tblSupplier.Find(supplierCode);
        }

    }
}
