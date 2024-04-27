using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlisseeProgect.Bll;

namespace PlisseeProgect.Gui
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void butsupplier_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            panel4.Visible = true;
            panbutton.Height = butsupplier.Height;
            panbutton.Top = butsupplier.Top;
            panel4.Controls.Clear();
            FormSupplier s = new FormSupplier();
            s.Location = new Point(148, 98);
            panel4.Controls.Add(s);
            s.Dock = DockStyle.Fill;
            SupplierDB tblSuppliers = new SupplierDB();
            s.dgv_supplier.DataSource = tblSuppliers.GetList().Where(x=>x.Status=="פעיל").Select(a => new 
            {
                קוד_ספק = a.SupplierCode,
                הערות = a.Note1,
                שם = a.SupplierName,
                טלפון = a.Phone,
                עיר = a.CityOfSupplier().NameCity 
            }
            ).OrderBy(x=>x.שם).ToList();
           
        }

        private void butcust_Click(object sender, EventArgs e)
        {
            panbutton.Height = butcust.Height;
            panbutton.Top = butcust.Top;
            pictureBox2.Visible = false;
            panel4.Visible = true;
            panel4.Controls.Clear();
            UserCustomer s = new UserCustomer();
            s.Location = new Point(148, 98);
            panel4.Controls.Add(s);
            s.Dock = DockStyle.Fill;
            CustomerDB tblCustomers = new CustomerDB();
            s.dgv_customers.DataSource= tblCustomers.GetList().Where(x => x.Status == "פעיל").Select
                (x => new
            {
                תעודת_זהות=x.Tz,
                שם_פרטי=x.FirstName,
                שם_משפחה=x.LastName,
                טלפון=x.Phone,עיר=x.CityOfC().NameCity,
                מייל=x.Mail,
                הערות=x.Note
            }
               )
                .OrderBy(x=>x.שם_משפחה).ToList();
            
        }
        
        private void butprod_Click(object sender, EventArgs e)
        {
            panbutton.Height = butprod.Height;
            panbutton.Top = butprod.Top;
            pictureBox2.Visible = false;
            panel4.Visible = true;
            panel4.Controls.Clear();
            UserProducts s = new UserProducts();
            s.Location = new Point(148, 98);
            panel4.Controls.Add(s);
            s.Dock = DockStyle.Fill;
            ProductModelsDB tblProducts = new ProductModelsDB();
            s.dgv_products.DataSource = tblProducts.GetList().Where(x => x.Status == "פעיל").Select(x => new
            {
                קוד_מוצר = x.ProductCode,
                מחיר_קניה = x.PurchasePrice,
                מחיר_מכירה = x.SallingPrice,
                שם_החברה = x.CompanyOfP().CompanyName,
                סוג_מוצר = x.ProductOfModels().TypeDescription,
                תאור_מוצר = x.ProductDescription,
                שם_ספק=x.CompanyOfP().SupplierOfCompany().SupplierName
            }
            ).OrderBy(x => x.סוג_מוצר).ToList();
        }

        private void butorder_Click(object sender, EventArgs e)
        {
            panbutton.Height = butorder.Height;
            panbutton.Top = butorder.Top;
            panel4.Controls.Clear();
            UserOrders s = new UserOrders();
            s.Location = new Point(148, 98);
            panel4.Controls.Add(s);
            s.Dock = DockStyle.Fill;
            ProductModelsDB tblProducts = new ProductModelsDB();
        }

        private void butcompa_Click(object sender, EventArgs e)
        {
            panbutton.Height = but_salling.Height;
            panbutton.Top = but_salling.Top;
            panel4.Controls.Clear();
            UserSale s = new UserSale();
            s.Location = new Point(148, 98);
            panel4.Controls.Add(s);
            s.Dock = DockStyle.Fill;
        }

        private void btn_management_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            panel4.Visible = true;
            panel4.Controls.Clear();
            UserManagement s = new UserManagement();
            s.Location = new Point(148, 98);
            panel4.Controls.Add(s);
            s.Dock = DockStyle.Fill;
        }

        private void btn_orders_arriving_Click(object sender, EventArgs e)
        {
            panbutton.Height = btn_orders_arriving.Height;
            panbutton.Top = btn_orders_arriving.Top;
            panel4.Controls.Clear();
            UserOrdersArriving s = new UserOrdersArriving();
            s.Location = new Point(148, 98);
            panel4.Controls.Add(s);
            s.Dock = DockStyle.Fill;
        }
    }
}
