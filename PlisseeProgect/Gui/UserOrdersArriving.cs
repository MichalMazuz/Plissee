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
    public partial class UserOrdersArriving : UserControl
    {
        OrderDetail od;
        SuppliersOrder sO;
        SuppliersOrderDB tblSuplierOrder;
        SupplierDB tblSuppliers;
        CompanyDB tblCompany;
        ProductModelsDB tblProductModels;
        ProductSizeDB tblProductSize;
        OrderDetailDB tblOrderDetail;
        SizeDB tbls;
        LengthDB tblLength;
        Bll.Size ss;
        Supplier s;
        Company c;
        ProductModels p;
        ProductSize ps;
        public UserOrdersArriving()
        {
            InitializeComponent();
            tblSuppliers = new SupplierDB();
            tblCompany = new CompanyDB();
            tblSuplierOrder = new SuppliersOrderDB();
            tblProductModels = new ProductModelsDB();
            tblProductSize = new ProductSizeDB();
            tblOrderDetail = new OrderDetailDB();
            s = new Supplier();
            c = new Company();
            p = new ProductModels();
            ps = new ProductSize();
            tbls = new SizeDB();
            tblLength = new LengthDB();
            cmb_search.DataSource = tblSuppliers.GetList().Where(x => x.Status == "פעיל").ToList();
            cmb_search.SelectedIndex = -1;
        }

        private void cmb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_search.SelectedIndex > -1)
            {
                s = ((Supplier)cmb_search.SelectedItem);
                dgv_orders.DataSource = tblSuplierOrder.
                    GetList().Where(x => x.Status == true && x.SupplierCode == s.SupplierCode).
                    Select(x => new {מספר_הזמנה=x.OrderNumber = x.OrderNumber, תאריך_הזמנה = x.Date}).ToList();
            }
            else
                dgv_orders.DataSource = null;
        }
        int orderNumber = 0;
        private void dgv_orders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_orders.SelectedRows.Count > 0)
            {
                 orderNumber = Convert.ToInt32(dgv_orders.SelectedRows[0].Cells[0].Value);
                sO = tblSuplierOrder.Find(orderNumber);
                dgv_orders_details.DataSource = tblOrderDetail.GetList().Where(x => x.OrderNumber == sO.OrderNumber && x.Status=="פעיל")
                    .Select(x => new
                    {
                        מספר_הזמנה = x.OrderNumber,
                        קוד_מוצר=x.ProductCode,
                        כמות = x.OrdersAmount,
                        מידה = x.ProductSizeOfOrderDetail().SizeOfProductSize().Description,
                        אורך = x.ProductSizeOfOrderDetail().LengthOfProductSize().LengthNum,
                        סטטוס=x.Status
                    }).ToList();
            }
        }

        private void dgv_orders_details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_orders_details.SelectedRows.Count>0)
            {
                numericUpDown1.Value= Convert.ToInt32(dgv_orders_details.SelectedRows[0].Cells[2].Value);
            }
        }

        private void btn_change_amount_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (dgv_orders_details.SelectedRows.Count> 0)
            {
                {
                    Bll.Size s = tbls.GetList().FirstOrDefault(x => x.Description == Convert.ToString(dgv_orders_details.SelectedRows[0].Cells[3].Value));
                    Length l = tblLength.GetList().FirstOrDefault(x => x.LengthNum == Convert.ToInt32(dgv_orders_details.SelectedRows[0].Cells[4].Value));
                    od = tblOrderDetail.Find
                    (Convert.ToInt32(dgv_orders_details.SelectedRows[0].Cells[0].Value),
                    Convert.ToInt32(dgv_orders_details.SelectedRows[0].Cells[1].Value), s.SizeCode
                    , l.LengthCode
                  );
                    ps = tblProductSize.GetList().FirstOrDefault
                        (x => x.ProductCode == Convert.ToInt32(dgv_orders_details.SelectedRows[0].Cells[1].Value)
                        && x.SizeCode == s.SizeCode
                        && x.LengthCode == l.LengthCode);
                }
                od.ArrivingAmount = Convert.ToInt32(numericUpDown1.Value);
                od.Status = "לא פעיל";
                ps.StocksAmount += Convert.ToInt32(numericUpDown1.Value);
                od.FinalPrice = Convert.ToInt32(numericUpDown1.Value) * ps.ProductSizeOfModels().PurchasePrice;
                tblOrderDetail.UpDateRow(od);
                tblProductSize.UpDateRow(ps);
                dgv_orders.DataSource = null;
                price += od.FinalPrice;
                dgv_orders_details.DataSource = tblOrderDetail.GetList().Where(x => x.OrderNumber == sO.OrderNumber && x.Status == "פעיל")
                       .Select(x => new
                       {
                           מספר_הזמנה = x.OrderNumber,
                           קוד_מוצר = x.ProductCode,
                           כמות = x.OrdersAmount,
                           מידה = x.ProductSizeOfOrderDetail().SizeOfProductSize().Description,
                           אורך = x.ProductSizeOfOrderDetail().LengthOfProductSize().LengthNum,
                           סטטוס = x.Status,
                           x.ArrivingAmount
                       }).ToList();
                if (dgv_orders_details.Rows.Count == 0)
                {
                    sO = tblSuplierOrder.Find(orderNumber);
                    sO.Status = false;
                    sO.OrderPrice = price;
                    tblSuplierOrder.UpDateRow(sO);
                    if (cmb_search.SelectedIndex > -1)
                    {
                        dgv_orders.DataSource = null;
                        s = ((Supplier)cmb_search.SelectedItem);
                        dgv_orders.DataSource = tblSuplierOrder.
                            GetList().Where(x => x.Status == true && x.SupplierCode == s.SupplierCode).
                            Select(x => new { מספר_הזמנה = x.OrderNumber = x.OrderNumber, תאריך_הזמנה = x.Date }).ToList();
                    }
                    else
                        dgv_orders.DataSource = null;
                }
            }
        }

        private void cmb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }
    }
}
