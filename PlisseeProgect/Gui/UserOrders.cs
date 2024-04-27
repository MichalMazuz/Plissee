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
    public partial class UserOrders : UserControl
    {
        OrderDetail od;
        SuppliersOrder sO;
        SuppliersOrderDB tblSuplierOrder;
        SupplierDB tblSuppliers;
        CompanyDB tblCompany;
        ProductModelsDB tblProductModels;
        ProductSizeDB tblProductSize;
        OrderDetailDB tblOrderDetail;
        Supplier s;
        Company c;
        ProductModels p;
        ProductSize ps;
        bool flag = false;
        public UserOrders()
        {
            InitializeComponent();
            tblSuppliers = new SupplierDB();
            tblCompany = new CompanyDB();
            tblSuplierOrder = new SuppliersOrderDB();
            tblProductModels = new ProductModelsDB();
            tblProductSize = new ProductSizeDB();
            tblOrderDetail = new OrderDetailDB();
            tblSuplierOrder = new SuppliersOrderDB();
            s = new Supplier();
            c = new Company();
            p = new ProductModels();
            ps = new ProductSize();
            cmb_search.DataSource = tblSuppliers.GetList().Where(x => x.Status == "פעיל").ToList();
            cmb_search.SelectedIndex = -1;
            flag = true;
            btn_continue.Visible = false;
            btn_save.Visible = false;
            btn_remove.Visible = false;
            dgv_orders.DataSource = null;
        }
        private void cmb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_search.SelectedIndex > -1)
            {
                s = ((Supplier)cmb_search.SelectedItem);
                listbox_company.DataSource=tblCompany.
                    GetList().Where(x => x.SupplierCode == s.SupplierCode).
                    Select(x => x.CompanyName.ToString()).ToList();
                listbox_company.SelectedIndex = -1;
            }
            else
                listbox_company.DataSource=null;
          
        }
        private void company_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_company.SelectedItems.Count > 0)
            {
                c = tblCompany.GetList().FirstOrDefault(x => x.CompanyName == Convert.ToString(listbox_company.SelectedItem));
                dgv_orders.DataSource = tblProductModels.GetList().
                   Where(x => x.CompanyCode == c.CompanyCode).
                    Select(x => new
                    {
                        קוד_מוצר = x.ProductCode,
                        תאור_מוצר = x.ProductDescription,
                        סןג_מוצר = x.ProductOfModels().TypeDescription
                    }).ToList();
            }
        }
        private void btn_save_p_Click(object sender, EventArgs e)
        {
            double price = 0.0;
            bool flag = true;
            bool flag1 = true;//בדיקה אם מוסיך כמות למוצר המופיע בליסט ויו
            cmb_search.Enabled = false;
            foreach (UserSiseLength us in ua.Controls)
            { 
                if (us.numericUpDown1.Value > 0)
                {
                    int x = Convert.ToInt32(us.numericUpDown1.Value);
                    foreach (ListViewItem itemList in listView1.Items)
                    {
                        
                        if (Convert.ToInt32(itemList.SubItems[0].Text)==us.ps.ProductCode &&
                           (itemList.SubItems[5].Text) == us.ps.SizeOfProductSize().Description && 
                           Convert.ToInt32(itemList.SubItems[6].Text) == us.ps.LengthOfProductSize().LengthNum)
                        {
                            MessageBox.Show("האם ברצונך לעדכן את הכמות");
                            x += Convert.ToInt32(itemList.SubItems[3].Text);
                            listView1.Items.Remove(itemList);
                        }
                    } 
                    price = 0.0;
                    for (int i = 1; i <=x; i++)
                    {
                        price += us.ps.ProductSizeOfModels().PurchasePrice;//חישוב מחיר על פי המוצר המשויך ליוזר הנוכחי
                    }
                    p = us.ps.ProductSizeOfModels();
                    ListViewItem listView2 = new ListViewItem(new string[]
                        {
                        p.ProductCode.ToString(),
                        p.ProductOfModels().TypeDescription,
                        p.PurchasePrice.ToString(),
                        x.ToString(),
                        p.ProductDescription,
                        us.textBox1.Text,
                        us.textBox2.Text,
                        price.ToString()
                        });
                    listView1.Items.Add(listView2);
                }
            }
            panel1.Controls.Remove(ua);
            foreach (Control item in panel1.Controls)
            {
                item.Visible = true;
            }

            if (flag)
            {
                int code = Convert.ToInt32(dgv_orders.SelectedRows[0].Cells[0].Value);
                p = tblProductModels.Find(code);
                //for (int i = 1; i <= numericUpDown1.Value; i++)
                //{
                //    price += p.PurchasePrice;
                //}
                ListViewItem listView2 = new ListViewItem(new string[]
                {
                        p.ProductCode.ToString(),
                        p.ProductOfModels().TypeDescription,
                        p.PurchasePrice.ToString(),
                        p.ProductDescription,
                        price.ToString()
                });
                //listView1.Items.Add(listView2);
                btn_save.Visible = true;
                btn_remove.Visible = true;
            }
        }
        private void btn_home1_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count>0)
            {
                sO = new SuppliersOrder();
                sO.OrderNumber = tblSuplierOrder.GetNextKey();
                sO.SupplierCode = ((Supplier)cmb_search.SelectedItem).SupplierCode;
                sO.OrderPrice = 0;
                sO.Status = true;
                sO.Date = DateTime.Now;
                tblSuplierOrder.AddNew(sO);
                //הוספת הזמנה
                foreach (ListViewItem item in listView1.Items)
                {
                    ps = tblProductSize.GetList().FirstOrDefault
                        (x =>
                        (x.ProductCode == Convert.ToInt32(item.SubItems[0].Text)) &&
                        x.SizeOfProductSize().Description == item.SubItems[5].Text &&
                        x.LengthOfProductSize().LengthNum.ToString() == item.SubItems[6].Text);
                    od = new OrderDetail();
                    od.OrderNumber = sO.OrderNumber;
                    od.OrdersAmount = Convert.ToInt32(item.SubItems[3].Text);
                    od.ProductCode = ps.ProductCode;
                    od.SizeCode = ps.SizeCode;
                    od.LengthCode = ps.LengthCode;
                    od.ArrivingAmount = 0;
                    p = tblProductModels.Find(ps.ProductCode);
                    od.FinalPrice = Convert.ToInt32(item.SubItems[7].Text);
                    od.Status = "פעיל";
                    tblOrderDetail.AddNew(od);
                }
                DialogResult d = MessageBox.Show("?האם בצונך להוסיף הזמנה זו", "אישור הוספה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (d == DialogResult.Yes)
                {
                    MessageBox.Show("ההזמנה נשמרה בהצלחה");
                }
            }

        }
        UserAllSizeLength ua;
        private void btn_home2_Click(object sender, EventArgs e)
        {
            bool flag=true;
            if(cmb_search.SelectedIndex==-1)
            {
                MessageBox.Show("בחר ספק");
                flag = false;
            }
            if (flag)
            {
                foreach (Control item in panel1.Controls)
                {
                    item.Visible = false;
                }
                ua = new UserAllSizeLength();
                UserSiseLength s = new UserSiseLength();
                int code = Convert.ToInt32(dgv_orders.SelectedRows[0].Cells[0].Value);
                p = tblProductModels.Find(code);
                foreach (ProductSize item in tblProductSize.GetList().Where(x => x.ProductCode == p.ProductCode))
                {
                    s = new UserSiseLength();
                    s.ps = item;
                    s.textBox1.Text = item.SizeOfProductSize().ToString();
                    s.textBox2.Text = item.LengthOfProductSize().ToString();
                    ua.Controls.Add(s);
                    s.Dock = DockStyle.Top;
                }
                panel1.Visible = true;
                //ua.Location = new Point(100, 3);
                //   panel1.Visible = false;
                panel1.Controls.Add(ua);
                // this.Parent.Controls.Add(s);
                //this.Parent.Visible = true;
                ua.Dock = DockStyle.Fill;
                btn_continue.Visible = true;
            }
        }
        private void btn_remove_Click_1(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    DialogResult s = MessageBox.Show("?האם ברצונך למחוק מוצר זה", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (s == DialogResult.Yes)
                    {
                        listView1.Items.Remove(listView1.SelectedItems[0]);
                    }
                }
            }
        }

        private void cmb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsHebrewChar(e.KeyChar);

        }
    }
}