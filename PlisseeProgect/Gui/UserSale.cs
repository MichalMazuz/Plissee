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
    public partial class UserSale : UserControl
    {
        OrderDetail od;
        SuppliersOrder sO;
        SuppliersOrderDB tblSuplierOrder;
        SupplierDB tblSuppliers;
        CompanyDB tblCompany;
        ProductModelsDB tblProductModels;
        ProductSizeDB tblProductSize;
        OrderDetailDB tblOrderDetail;
        DetailPaymentsDB tblDetailPayments;
        SaleDetailDB tblSaleDetail;
        SaleDB tblSale;
        SizeDB tblSize=new SizeDB();
        LengthDB tblLength=new LengthDB();
        Supplier s;
        Company c;
        Customer cus;
        ProductModels p;
        ProductSize ps;
        DetailPayments dp;
        Sale sale;
        SaleDetail saleD;
        CustomerDB tblCustomer;
        bool flag_d_t_p=false;

        public UserSale()
        {
            InitializeComponent();
            tblSuppliers = new SupplierDB();
            tblCompany = new CompanyDB();
            tblSuplierOrder = new SuppliersOrderDB();
            tblProductModels = new ProductModelsDB();
            tblProductSize = new ProductSizeDB();
            tblOrderDetail = new OrderDetailDB();
            tblSize = new SizeDB();
            tblLength = new LengthDB();
            tblCustomer = new CustomerDB();
            tblSale = new SaleDB();
            tblDetailPayments = new DetailPaymentsDB();
            tblSaleDetail = new SaleDetailDB();
            s = new Supplier();
            c = new Company();
            p = new ProductModels();
            ps = new ProductSize();
            cus = new Customer();
            cmb_search.DataSource = tblProductSize.GetList().Where(x => x.StocksAmount > 0).Select(z => z.ProductCode).Distinct().ToList();
            cmb_search.SelectedIndex = -1;
            panel_payment.Visible = false;
            panel_visa.Visible = false;
            panel_check.Visible = false;
            txt_id.Visible = false;
            textBox1.Visible = false;
        }
        public UserSale(string tz) : this()
        {
            txt_id.Text = tz;
            txt_id.ReadOnly = true;
        }
        private void cmb_search_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_size.DataSource = tblProductSize.GetList().Where
               (x => x.ProductCode == Convert.ToInt32(cmb_search.SelectedItem)&&x.Status==0&&x.StocksAmount>0)
               .Select(x => x.SizeOfProductSize().Description).Distinct().ToList();
        }

        private void cmb_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_length.DataSource = tblProductSize.GetList().Where
                (x =>x.SizeOfProductSize().Description==Convert.ToString(cmb_size.SelectedItem)
                && x.ProductCode == Convert.ToInt32(cmb_search.SelectedItem)&&x.StocksAmount>0)
                .Select(x => x.LengthOfProductSize().LengthNum).ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cmb_length.SelectedIndex > -1 && numericUpDown1.Value > 0)
            {
                int codeSize = tblSize.GetList().FirstOrDefault(x=>x.Description==cmb_size.SelectedItem.ToString()).SizeCode;
                int  codeLength  = tblLength.GetList().FirstOrDefault(x => x.LengthNum == Convert.ToInt32(cmb_length.SelectedItem.ToString())).LengthCode;
                ps = tblProductSize.Find(Convert.ToInt32(cmb_search.SelectedItem), codeSize,codeLength);
                int amount = Convert.ToInt32(numericUpDown1.Value);
                bool flag = true;
                //בדיקה אם יש את הכמות במלאי
                if (amount > ps.StocksAmount)
                    MessageBox.Show("הכמות במלאי:" + ps.StocksAmount + " בחר כמות מתאימה");
                //הוספה לליטס
                else
                {
                    //בדיקה אם המוצר כבר קיים
                    foreach (ListViewItem item in listview_salling.Items)
                    {
                        if (Convert.ToInt32(item.SubItems[0].Text) == ps.ProductCode&&
                            item.SubItems[2].Text == ps.SizeOfProductSize().Description &&
                         Convert.ToInt32(item.SubItems[3].Text) == ps.LengthOfProductSize().LengthNum)
                        {
                            amount += Convert.ToInt32(item.SubItems[4].Text);
                            //בדיקה אם יש את הכמות במלאי
                            if (amount > ps.StocksAmount)
                            {
                                MessageBox.Show("הכמות במלאי:" + ps.StocksAmount + " בחר כמות מתאימה");
                                flag = false;
                            }
                            else
                                listview_salling.Items.Remove(item);
                        }
                    }
                    if (flag)
                    {

                        p = tblProductModels.Find(ps.ProductCode);
                        ListViewItem listview_sale = new ListViewItem(new string[] 
                        { 
                            ps.ProductCode.ToString(),
                            p.ProductDescription,ps.SizeOfProductSize().Description,
                            ps.LengthOfProductSize().LengthNum.ToString(),
                            amount.ToString(),
                            p.SallingPrice.ToString(),
                            (amount*p.SallingPrice).ToString()
                        });
                        listview_salling.Items.Add(listview_sale);
                        double temp = 0;
                        foreach (ListViewItem item in listview_salling.Items)
                        {
                            temp+= Convert.ToDouble(item.SubItems[6].Text);
                        }
                        txt_finalPrice.Text= "";
                        txt_finalPrice.Text=temp.ToString();
                    }
                }

              }
               
            }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listview_salling.Items)
            {
                if (listview_salling.SelectedItems.Count > 0)
                {
                    DialogResult s = MessageBox.Show("?האם ברצונך למחוק מוצר זה", "אישור מחיקה", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (s == DialogResult.Yes)
                    {
                        listview_salling.Items.Remove(listview_salling.SelectedItems[0]);
                    }
                }
            }
        }

        private void btn_payments_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if(listview_salling.Items.Count==0)
            {
                MessageBox.Show("בחר מוצרים");
                flag = false;
            }
            if(flag)
            panel_payment.Visible = true;
        }

        private void radioB_cheq_CheckedChanged(object sender, EventArgs e)
        {
            if (radioB_cheq.Checked)
            {
                panel_check.Location = new Point(53, 240);
                panel_check.Visible = true;
                panel_visa.Visible = false;
            }
        }

        private void radioB_creditcard_CheckedChanged(object sender, EventArgs e)
        {
            if (radioB_creditcard.Checked)
            {
                panel_visa.Visible = true;
                panel_check.Visible = false;
            }
        }

        private void radiob_cash_CheckedChanged(object sender, EventArgs e)
        {
           
            panel_visa.Visible = false;
            panel_check.Visible = false;
        }
        public bool CreateFields(DetailPayments dp)
        {
            bool flagOk=true;
            errorProvider1.Clear();
            if (radioB_creditcard.Checked)
            {
                try
                {
                    if (txt_cw.Text == "")
                        throw new Exception("שדה חובה");
                    if (!Validation.IsNum(txt_cw.Text))
                        throw new Exception("יש להקיש מספרים");
                    if ((Validation.HowLongDigit(txt_cw.Text) != 3))
                        throw new Exception("הקש ספרות בגב הכרטיס");
                    dp.CreditCw = txt_cw.Text;
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txt_cw, ex.Message);
                    flagOk = false;
                }
                try
                {
                    //5326-1053-0326-0981
                    if (maskedTxtb_creditcard.Text == "    -    -    -")
                        throw new Exception("שדה חובה");
                    if (!Validation.CheckVisa(maskedTxtb_creditcard.Text))
                        throw new Exception("יש להקיש מספרים");
                    dp.CreditNumber = maskedTxtb_creditcard.Text;
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(maskedTxtb_creditcard, ex.Message);
                    flagOk = false;
                }
                try
                {
                    if (dateTimePicker1.CustomFormat == "בחר")
                        throw new Exception("שדה חובה");
                    if (dateTimePicker1.Value.Date < DateTime.Now.Date)
                        throw new Exception("כרטיס לא תקף");
                    dp.CreditForce = dateTimePicker1.Value;
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(dateTimePicker1, ex.Message);
                    flagOk = false;
                }
                dp.PaymentCode = tblDetailPayments.GetNextKey();
                dp.PaymentNumber = Convert.ToInt32(nupdown_paymentNumber.Value);
                dp.ChequeNumber = txt_cheque_number.Text;
                dp.BankNumber = txt_bank_number.Text;
                dp.BranchNumber = txt_branch_number.Text;
                dp.UserAccount = txt_user_account.Text;
                dp.SalesCode = tblSale.GetNextKey();

            }
            else
            {
                if (radioB_cheq.Checked)
                {
                   
                    //מספר מחאה
                    try
                    {
                        if (txt_cheque_number.Text == "")
                            throw new Exception("שדה חובה");
                        if (!Validation.IsNum(txt_cheque_number.Text))
                            throw new Exception("יש להקיש מספרים");
                        if ((Validation.HowLongDigit(txt_cheque_number.Text) != 7))
                            throw new Exception("יש להקיש מספר המחאה תקין");
                        dp.ChequeNumber = txt_cheque_number.Text;
                    }
                    catch (Exception ex)
                    {
                        errorProvider1.SetError(txt_cheque_number, ex.Message);
                        flagOk = false;
                    }
                    //מספר בנק
                    try
                    {
                        if (txt_bank_number.Text == "")
                            throw new Exception("שדה חובה");
                        if ((Validation.HowLongDigit(txt_cheque_number.Text) != 7))
                            throw new Exception("יש להקיש מספר המחאה תקין");

                        dp.BankNumber = txt_bank_number.Text;
                    }
                    catch (Exception ex)
                    {
                        errorProvider1.SetError(txt_bank_number, ex.Message);
                        flagOk = false;
                    }
                    //סניף בנק
                    try
                    {
                        if (txt_branch_number.Text == "")
                            throw new Exception("שדה חובה");
                        if (!Validation.IsNum(txt_branch_number.Text))
                            throw new Exception("יש להקיש מספרים");
                        if ((Validation.HowLongDigit(txt_branch_number.Text) < 3) || (Validation.HowLongDigit(txt_branch_number.Text) > 3))
                            throw new Exception("לא תקין מספר סניף");
                        dp.BranchNumber = txt_branch_number.Text;
                    }
                    catch (Exception ex)
                    {
                        errorProvider1.SetError(txt_branch_number, ex.Message);
                        flagOk = false;
                    }
                    //מספר חשבון
                    try
                    {
                        if (txt_user_account.Text == "")
                            throw new Exception("שדה חובה");
                        if (!Validation.IsNum(txt_user_account.Text))
                            throw new Exception("יש להקיש מספרים");
                        if ((Validation.HowLongDigit(txt_user_account.Text) < 6) || (Validation.HowLongDigit(txt_user_account.Text) > 9))
                            throw new Exception("הקש מספר חשבון תקין");
                        dp.UserAccount = txt_user_account.Text;
                    }
                    catch (Exception ex)
                    {
                        errorProvider1.SetError(txt_user_account, ex.Message);
                        flagOk = false;
                    }
                    dp.PaymentCode = tblDetailPayments.GetNextKey();
                    dp.PaymentNumber = Convert.ToInt32(numericUpDown1.Value);
                    dp.CreditNumber = maskedTxtb_creditcard.Text;
                    dp.CreditForce = DateTime.Today; ;
                    dp.CreditCw = txt_cw.Text;
                    dp.SalesCode = tblSale.GetNextKey();
                }
                else
                {
                    if (radiob_cash.Checked)
                    {
                        dp.PaymentCode = tblDetailPayments.GetNextKey();
                        dp.PaymentNumber = 0;
                        dp.CreditNumber = "0000000000000000";
                        dp.CreditForce = DateTime.Today;
                        dp.CreditCw = "000";
                        dp.SalesCode = tblSale.GetNextKey();
                    }
                }
            }
                    
            if (rb_members.Checked)
            {
                try
                {
                    if (txt_id.Text == "")
                        throw new Exception("שדה חובה");
                    if (txt_id.Text == "")
                        throw new Exception("הקש תעודת זהות");
                    dp.CustomerTz = txt_id.Text;
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txt_id, ex.Message);
                    flagOk = false;
                }
            }
            if (radiob_cash.Checked)
                dp.PaymentWay = "מזומן";
            else
                if (radioB_cheq.Checked)
                dp.PaymentWay = "צ'ק";
            dp.PaymentWay = "אשראי";
            if (rb_general.Checked)
                dp.CustomerTz = tblCustomer.Find( textBox1.Text).Tz;
            if (!radiob_cash.Checked && !radioB_cheq.Checked && !radioB_creditcard.Checked)
                flagOk = false;
            if (!rb_general.Checked && !rb_members.Checked)
                flagOk = false;
           
            return flagOk;
        }

        private void btn_sale_Click(object sender, EventArgs e)
        {
            dp = new DetailPayments();
            if(CreateFields(dp))
            { 
            tblDetailPayments.AddNew(dp);
            sale = new Sale();
            if (rb_general.Checked)
                sale.CustomerTz = textBox1.Text;
            else
               sale.CustomerTz = txt_id.Text;
            sale.SalesCode = tblSale.GetNextKey();
            sale.Date = DateTime.Now;
            sale.FinalPurchase = Convert.ToInt32(txt_finalPrice.Text);
            sale.Status = "פעיל";
            tblSale.AddNew(sale);
           
             foreach (ListViewItem items in listview_salling.Items)
             {
                saleD = new SaleDetail();
                saleD.SaleCode = sale.SalesCode;
                
                ProductSize ps = new ProductSize();
                ps = tblProductSize.Find(Convert.ToInt32(items.SubItems[0].Text),
                    tblSize.GetList().FirstOrDefault(x => x.Description == (items.SubItems[2].Text)).SizeCode,
                    tblLength.GetList().FirstOrDefault(x => x.LengthNum == Convert.ToInt32(items.SubItems[3].Text)).LengthCode);
                saleD.ProductCode = ps.ProductCode;
                saleD.SizeCode = ps.SizeCode;
                saleD.LengthCode = ps.LengthCode;
                saleD.Amount = Convert.ToInt32(items.SubItems[4].Text);
                saleD.FinalPrice = Convert.ToInt32(items.SubItems[6].Text);
                saleD.Status = true;
                tblSaleDetail.AddNew(saleD);
                ps.StocksAmount=ps.StocksAmount- Convert.ToInt32(items.SubItems[4].Text);
                tblProductSize.UpDateRow(ps);
             }
                MessageBox.Show("הקניה הושלמה בהצלחה");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            flag_d_t_p = true;
            dateTimePicker1.CustomFormat = "MM / yy";
        }

        private void rb_members_CheckedChanged(object sender, EventArgs e)
        {
            txt_id.Visible = true;
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            if(txt_id.Text.Length==9)
            {
                cus = tblCustomer.GetList().FirstOrDefault(x => x.Tz == txt_id.Text);
                if (cus == null)
                {
                    if ((Validation.CheckId(txt_id.Text)) && (tblCustomer.Find(txt_id.Text)==null))
                    {
                        UserSingleCustomer up = new UserSingleCustomer(txt_id.Text, 1);
                        Control c = this.Parent;
                        up.Location = new Point(0, 0);
                        txt_id.ReadOnly = true;
                        this.Visible = false;
                        c.Controls.Add(up);
                        up.Dock = DockStyle.Fill;
                        errorProvider1.Clear();
                    }
                    else
                    {
                        try
                        { 
                            if (Validation.CheckId(txt_id.Text))
                            throw new Exception("הקש תעודת זהות תקינה");
                            MessageBox.Show("הקש ת.ז תקינה");
                        }
                        catch (Exception ex)
                        {
                            errorProvider1.SetError(txt_id, ex.Message);
                            
                        }
                    }
                }
                else
                {
                    txt_id.Visible = true;
                    txt_id.ReadOnly = true;
                    MessageBox.Show("ת.ז זו קימת במערכת");
                }
            }
        }

        private void UserSale_Load(object sender, EventArgs e)
        {

        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            UserReturnProduct s = new UserReturnProduct();
            s.Location = new Point(148, 98);
            this.Controls.Add(s);
            s.Dock = DockStyle.Fill;
        }

        private void rb_general_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "111111111";
        }

        private void txt_cw_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void maskedTxtb_creditcard_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void cmb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void cmb_size_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void cmb_length_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void txt_cheque_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void txt_user_account_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void txt_branch_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }

        private void txt_bank_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validation.IsNumberChar(e.KeyChar);

        }
    }
}
