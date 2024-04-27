using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlisseeProgect.Bll;

namespace PlisseeProgect.Gui
{
    public partial class UserReturnProduct : UserControl
    {
        SizeDB tbls;
        LengthDB tblLength;
        Supplier s;
        Company c;
        ProductModels p;
        ProductSize ps;
        Sale sale;
        SaleDetail saleD;
        SaleDB tblSale;
        SaleDetailDB tblSaleDetail;
        ProductSizeDB tblProductSize;
        public UserReturnProduct()
        {
            InitializeComponent();
            s = new Supplier();
            c = new Company();
            p = new ProductModels();
            ps = new ProductSize();
            tbls = new SizeDB();
            tblLength = new LengthDB();
            tblSale = new SaleDB();
            tblSaleDetail = new SaleDetailDB();
            tblProductSize = new ProductSizeDB();
            cmb_search.DataSource = tblSale.GetList().Where(x => x.Status == "פעיל").ToList();
            cmb_search.SelectedIndex = -1;
        }

        private void cmb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_search.SelectedIndex > -1)
            {
                sale = ((Sale)cmb_search.SelectedItem);
                dgv_salling.DataSource = tblSale.
                    GetList().Where(x => x.Status=="פעיל" && x.SalesCode == sale.SalesCode).
                    Select(x => new 
                    {
                        קוד_קניה=x.SalesCode
                        ,תאריך_קניה=x.Date
                        ,מחיר_הקניה=x.FinalPurchase
                    }).ToList();
            }
            else
                dgv_salling.DataSource = null;
        }

        private void dgv_salling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_salling.SelectedRows.Count > 0)
            {
                int sale_code = Convert.ToInt32(dgv_salling.SelectedRows[0].Cells[0].Value.ToString());
                sale = tblSale.Find(sale_code);
                dgv_salling_details.DataSource = tblSaleDetail.GetList().Where(x => x.SaleCode == sale.SalesCode && x.Status/*&&x.Amount>0*/)
                    .Select(x => new
                    {
                        קוד_מוצר=x.ProductCode,
                        שם_מוצר=x.SaleDetailOFSize().ProductSizeOfModels().ProductDescription,
                        מידה=x.SaleDetailOFSize().SizeOfProductSize().Description,
                        אורך=x.SaleDetailOFSize().LengthOfProductSize().LengthNum,
                        כמות=x.Amount,
                        מחיר_ליחידה=x.SaleDetailOFSize().ProductSizeOfModels().SallingPrice,
                        מחיר_סופי=x.FinalPrice
                    }).ToList();
            }
        }

        private void dgv_salling_details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_salling_details.SelectedRows.Count > 0)
            {
                numericUpDown1.Maximum= Convert.ToInt32(dgv_salling_details.SelectedRows[0].Cells[4].Value);
                numericUpDown1.Value = Convert.ToInt32(dgv_salling_details.SelectedRows[0].Cells[4].Value);
            }
        }

        private void btn_change_amount_Click(object sender, EventArgs e)
        {
            //if (dgv_salling_details.SelectedRows.Count > 0)
            //{
            //    Bll.Size s = tbls.GetList().FirstOrDefault(x => x.Description == Convert.ToString(dgv_salling_details.SelectedRows[0].Cells[2].Value));
            //    Length l = tblLength.GetList().FirstOrDefault(x => x.LengthNum == Convert.ToInt32(dgv_salling_details.SelectedRows[0].Cells[3].Value));
            //    saleD = tblSaleDetail.Find
            //    (Convert.ToInt32(dgv_salling.SelectedRows[0].Cells[0].Value),
            //    Convert.ToInt32(dgv_salling_details.SelectedRows[0].Cells[0].Value),
            //    s.SizeCode,
            //    l.LengthCode
            //  );
            //    ps = tblProductSize.GetList().FirstOrDefault
            //    (x => x.ProductCode == Convert.ToInt32(dgv_salling_details.SelectedRows[0].Cells[0].Value)
            //    && x.SizeCode == s.SizeCode && x.LengthCode == l.LengthCode);
            //    saleD.Amount = Convert.ToInt32(dgv_salling_details.SelectedRows[0].Cells[4].Value) - Convert.ToInt32(numericUpDown1.Value);
            //    ps.StocksAmount += Convert.ToInt32(numericUpDown1.Value);
            //    tblSaleDetail.UpDateRow(saleD);
            //    tblProductSize.UpDateRow(ps);
            //    dgv_salling.DataSource = null;
            //    dgv_salling_details.DataSource = tblSaleDetail.GetList().Where(x => x.SaleCode == saleD.SaleCode && x.Status&&x.Amount>0)
            //       .Select(x => new
            //       {
            //           קוד_מוצר = x.ProductCode,
            //           שם_מוצר = x.SaleDetailOFSize().ProductSizeOfModels().ProductDescription,
            //           מידה = x.SaleDetailOFSize().SizeOfProductSize().Description,
            //           אורך = x.SaleDetailOFSize().LengthOfProductSize().LengthNum,
            //           כמות = x.Amount,
            //           מחיר_ליחידה = x.SaleDetailOFSize().ProductSizeOfModels().SallingPrice,
            //           מחיר_סופי = x.FinalPrice
            //       }).ToList();
            //    if (dgv_salling_details.Rows.Count == 0)
            //    {

            //        int sale_code = Convert.ToInt32(dgv_salling.SelectedRows[0].Cells[0].Value);
            //        sale = tblSale.Find(sale_code);
            //        sale.Status = "לא פעיל";
            //        tblSale.UpDateRow(sale);
            //        //if (cmb_search.SelectedIndex > -1)
            //        //{
            //        //    dgv_salling.DataSource = null;
            //        //    sale = ((Sale)cmb_search.SelectedItem);
            //        //    dgv_salling.DataSource = tblSale.
            //        //        GetList().Where(x => x.Status == "פעיל" && x.SalesCode == sale.SalesCode).
            //        //        Select(x => new
            //        //        {
            //        //            קוד_קניה = x.SalesCode,
            //        //            תאריך_קניה = x.Date,
            //        //            מחיר_הקניה = x.FinalPurchase
            //        //        }).ToList();
            //        //}
            //        //else
            //        //    dgv_salling.DataSource = null;

            //    }
            //    double price = saleD.SaleDetailOFSize().ProductSizeOfModels().SallingPrice * Convert.ToDouble(numericUpDown1.Value);
            //    MessageBox.Show("הזיכוי בסך" + " " + price);
            //    dgv_salling_details.DataSource = tblSaleDetail.GetList().Where(x => x.SaleCode == sale.SalesCode && x.Status && x.Amount > 0)
            //       .Select(x => new
            //       {
            //           קוד_מוצר = x.ProductCode,
            //           שם_מוצר = x.SaleDetailOFSize().ProductSizeOfModels().ProductDescription,
            //           מידה = x.SaleDetailOFSize().SizeOfProductSize().Description,
            //           אורך = x.SaleDetailOFSize().LengthOfProductSize().LengthNum,
            //           כמות = x.Amount,
            //           מחיר_ליחידה = x.SaleDetailOFSize().ProductSizeOfModels().SallingPrice,
            //           מחיר_סופי = x.FinalPrice
            //       }).ToList();
            //}
            if (numericUpDown1.Value > 0 && numericUpDown1.Value <= Convert.ToInt32(dgv_salling_details.SelectedRows[0].Cells[4].Value))
            {
                Bll.Size s = tbls.GetList().FirstOrDefault(x => x.Description == Convert.ToString(dgv_salling_details.SelectedRows[0].Cells[2].Value));
                Length l = tblLength.GetList().FirstOrDefault(x => x.LengthNum == Convert.ToInt32(dgv_salling_details.SelectedRows[0].Cells[3].Value));
                saleD = tblSaleDetail.Find
                (Convert.ToInt32(dgv_salling.SelectedRows[0].Cells[0].Value),
                Convert.ToInt32(dgv_salling_details.SelectedRows[0].Cells[0].Value),
                s.SizeCode,
                l.LengthCode
              );
                ps = tblProductSize.GetList().FirstOrDefault
                (x => x.ProductCode == Convert.ToInt32(dgv_salling_details.SelectedRows[0].Cells[0].Value)
                && x.SizeCode == s.SizeCode && x.LengthCode == l.LengthCode);
                saleD.Amount = Convert.ToInt32(dgv_salling_details.SelectedRows[0].Cells[4].Value) - Convert.ToInt32(numericUpDown1.Value);
                if (saleD.Amount == 0)
                    saleD.Status = false;
                ps.StocksAmount += Convert.ToInt32(numericUpDown1.Value);
                tblSaleDetail.UpDateRow(saleD);
                tblProductSize.UpDateRow(ps);
                dgv_salling.DataSource = null;
                dgv_salling_details.DataSource = tblSaleDetail.GetList().Where(x => x.SaleCode == saleD.SaleCode && x.Status)
                   .Select(x => new
                   {
                       קוד_מוצר = x.ProductCode,
                       שם_מוצר = x.SaleDetailOFSize().ProductSizeOfModels().ProductDescription,
                       מידה = x.SaleDetailOFSize().SizeOfProductSize().Description,
                       אורך = x.SaleDetailOFSize().LengthOfProductSize().LengthNum,
                       כמות = x.Amount,
                       מחיר_ליחידה = x.SaleDetailOFSize().ProductSizeOfModels().SallingPrice,
                       מחיר_סופי = x.FinalPrice
                   }).ToList();
                if (dgv_salling_details.Rows.Count == 0|| Convert.ToInt32(dgv_salling_details.SelectedRows[0].Cells[4].Value)==0)
                {
                    int sale_code = sale.SalesCode;
                    sale = tblSale.Find(sale_code);
                    sale.Status = "לא פעיל";
                    tblSale.UpDateRow(sale);
                    if (cmb_search.SelectedIndex > -1)
                    {
                        dgv_salling.DataSource = null;
                        sale = ((Sale)cmb_search.SelectedItem);
                        dgv_salling.DataSource = tblSale.
                            GetList().Where(x => x.Status == "פעיל" && x.SalesCode == sale.SalesCode).
                            Select(x => new
                            {
                                קוד_קניה = x.SalesCode,
                                תאריך_קניה = x.Date,
                                מחיר_הקניה = x.FinalPurchase
                            }).ToList();
                    }
                    else
                        dgv_salling.DataSource = null;

                }
                double price = saleD.SaleDetailOFSize().ProductSizeOfModels().SallingPrice * Convert.ToDouble(numericUpDown1.Value);
                MessageBox.Show("הזיכוי בסך" + " " + price);
                RefreshDG();
            }
        }

        private void RefreshDG()
        {
            dgv_salling.DataSource = null;
            dgv_salling.DataSource = tblSale.
            GetList().Where(x => x.Status == "פעיל" && x.SalesCode == sale.SalesCode).
            Select(x => new
            {
              קוד_קניה = x.SalesCode
                                    ,
               תאריך_קניה = x.Date
                                   ,
              מחיר_הקניה = x.FinalPurchase
            }).ToList();

            dgv_salling_details.DataSource = tblSaleDetail.GetList().Where(x => x.SaleCode == sale.SalesCode && x.Status/*&&x.Amount>0*/)
               .Select(x => new
               {
                   קוד_מוצר = x.ProductCode,
                   שם_מוצר = x.SaleDetailOFSize().ProductSizeOfModels().ProductDescription,
                   מידה = x.SaleDetailOFSize().SizeOfProductSize().Description,
                   אורך = x.SaleDetailOFSize().LengthOfProductSize().LengthNum,
                   כמות = x.Amount,
                   מחיר_ליחידה = x.SaleDetailOFSize().ProductSizeOfModels().SallingPrice,
                   מחיר_סופי = x.FinalPrice
               }).ToList();

        }

        private void cmb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }
    }
}
