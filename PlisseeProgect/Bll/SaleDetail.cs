using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
    class SaleDetail
    {
        DataRow dr;
        private int saleCode;
        private int productCode;
        private int sizeCode;
        private int lengthCode;
        private int amount;
        private double finalPrice;
        private bool status;
        public SaleDetail()
        {

        }
        public SaleDetail(DataRow dr)
        {
            this.Dr = dr;
            SaleCode = Convert.ToInt32(dr["sale_code1"]);
            ProductCode = Convert.ToInt32(dr["product_code1"]);
            SizeCode = Convert.ToInt32(dr["size_code1"]);
            LengthCode = Convert.ToInt32(dr["length_code1"]);
            Amount = Convert.ToInt32(dr["amount1"]);
            FinalPrice = Convert.ToInt32(dr["final_price1"]);
            if (dr["status1"].Equals(true))
                this.Status = true;
            else
                this.Status = false;
        }

        public DataRow Dr { get => dr; set => dr = value; }
        public int SaleCode { get => saleCode; set => saleCode = value; }
        public int ProductCode { get => productCode; set => productCode = value; }
        public int SizeCode { get => sizeCode; set => sizeCode = value; }
        public int LengthCode { get => lengthCode; set => lengthCode = value; }
        public int Amount { get => amount; set => amount = value; }
        public double FinalPrice { get => finalPrice; set => finalPrice = value; }
        public bool Status { get => status; set => status = value; }

        public void FillDataRow()
        {
            Dr["sale_code1"] = SaleCode;
            Dr["product_code1"] = ProductCode;
            Dr["size_code1"] = SizeCode;
            Dr["length_code1"] = LengthCode;
            Dr["amount1"] = Amount;
            Dr["final_price1"] = FinalPrice;
            Dr["status1"] = Status;
        }
        public ProductSize SaleDetailOFSize()
        {
            ProductSizeDB tblProductSize = new ProductSizeDB();
            return tblProductSize.Find(productCode, sizeCode, lengthCode);
        }
    }
}
