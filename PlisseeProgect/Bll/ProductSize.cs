using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PlisseeProgect.Bll
{
 public   class ProductSize
    {
        DataRow dr;
        private int productCode;
        private int sizeCode;
        private int lengthCode;
        private int stocksAmount;
        private int status;
        public ProductSize()
        {

        }
        public ProductSize(DataRow dr)
        {
            this.Dr = dr;
            ProductCode = Convert.ToInt32(dr["product_code"]);
            SizeCode = Convert.ToInt32(dr["size_code"]);
            LengthCode = Convert.ToInt32(dr["length_code"]);
            StocksAmount = Convert.ToInt32(dr["stocks_amount"]);
            Status = Convert.ToInt32(dr["status"]);
          
        }

        public DataRow Dr { get => dr; set => dr = value; }
        public int ProductCode { get => productCode; set => productCode = value; }
        public int SizeCode { get => sizeCode; set => sizeCode = value; }
        public int LengthCode { get => lengthCode; set => lengthCode = value; }
        public int StocksAmount { get => stocksAmount; set => stocksAmount = value; }
        public int Status { get => status; set => status = value; }

        public void FillDataRow()
        {
            Dr["product_code"] = ProductCode;
            Dr["size_code"] = SizeCode;
            Dr["length_code"] = LengthCode;
            Dr["stocks_amount"] = StocksAmount;
            Dr["status"] = Status;
        }
        public ProductModels ProductSizeOfModels()
        {
            ProductModelsDB tblProductModels = new ProductModelsDB();
            return tblProductModels.Find(productCode);
        }
        public Size SizeOfProductSize()
        {
            SizeDB tblSize = new SizeDB();
            return tblSize.Find(sizeCode);
        }
        public Length LengthOfProductSize()
        {
            LengthDB tblLength = new LengthDB();
            return tblLength.Find(lengthCode);
        }
    }
}
